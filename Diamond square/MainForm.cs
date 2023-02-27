using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diamond_square
{
    public partial class MainForm : Form
    {
        int imageSize;

        int maxDepth;

        int minOceanDepth;

        int minMountainHeight;

        int snowLineHeight;

        int maxHeight;

        readonly SettingsForm settingsForm = new SettingsForm();

        readonly Random rnd = new Random();

        Bitmap bmp;

        int[,] arrOfHeights;

        Color[] arrOfColors;

        float roughnessFactor;

        public MainForm()
        {
            InitializeComponent();

            pictureResolution.SelectedItem = "513 x 513";

            Initialize();

            roughnessFactor = (float)(rBar.Value * 0.01);

            ClearPicture();
        }

        // Инициализирует частоизменяемые объекты.
        private void Initialize()
        {
            ChangeSettings();

            Color[] definingСolors = settingsForm.Colors;

            arrOfColors = new Color[maxHeight - maxDepth + 1];

            FillColors(definingСolors);
        }

        // Красит "PictureBox", на котором отображается картинка, в белый цвет.
        private void ClearPicture()
        {
            Graphics.FromImage(bmp).Clear(Color.White);

            FillPicture();

            start.Focus();
        }

        // С равной вероятностью выдает либо число 1, либо число -1.
        private int Rand() => rnd.Next(-1, 1) == 0 ? 1 : -1;

        private async void Start_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;

            // Отключает возможность менять настройки программы на время выполнения алгоритма.
            start.Enabled = save.Enabled = clear.Enabled = rBar.Enabled = trackBarP1.Enabled = trackBarP2.Enabled = 
                trackBarP3.Enabled = trackBarP4.Enabled = additionalSettings.Enabled = pictureResolution.Enabled = false; 

            // Инициализация и отрисовка угловых точек.
            arrOfHeights[0, 0] = trackBarP1.Value;

            arrOfHeights[imageSize, 0] = trackBarP2.Value;

            arrOfHeights[imageSize, imageSize] = trackBarP3.Value;

            arrOfHeights[0, imageSize] = trackBarP4.Value;

            Draw(new Point(0, imageSize)); 
            
            Draw(new Point(imageSize, 0));

            Draw(new Point(imageSize, imageSize)); 
            
            Draw(new Point(0, 0));

            // Запуск в новом потоке, чтобы окно программы не зависало.
            Task task = Task.Run(() => DiamondSquare());

            await task;

            picture.Enabled = save.Enabled = clear.Enabled = true;

            save.Focus();
        }

        // Метод для изменения состояния полосы прогресса. Использует метод "Invoke",
        // так как вызывается в отличном от потока, где расположен элемент управления "ProgressBar".
        private void ChangeProgressBarValueSafe(int value)
        {
            if (progressBar.InvokeRequired)
                progressBar.Invoke(new Action<int>((i) => progressBar.Value = i), value);

            else progressBar.Value = value;
        }

        // Основной метод программы. Отвечает за исполнение алгоритма "Diamond-square".
        private void DiamondSquare()
        {
            // Изначально шаг максимален, после будет уменьшаться, пока не станет равен 1.
            int step = imageSize;

            // Счетчик отвечает за кол-во раз, которое отработал метод "Draw".
            int counter = 4;

            while (step != 1)
            {
                for (int i = 0; i < imageSize; i += step)
                {
                    for (int j = 0; j < imageSize; j += step)
                    {
                        // p1 - p4 - угловые точки для данного шага.
                        Point p1 = new Point(j, i);

                        Point p2 = new Point(step + j, i);

                        Point p3 = new Point(step + j, step + i);

                        Point p4 = new Point(j, step + i);

                        // Нахождение срединной точки для квадрата.
                        Point p = Diamond(p1, p2, p3, p4, step);

                        int h = arrOfHeights[p.X, p.Y];

                        int h1 = arrOfHeights[p1.X, p1.Y];

                        int h2 = arrOfHeights[p2.X, p2.Y];

                        int h3 = arrOfHeights[p3.X, p3.Y];

                        int h4 = arrOfHeights[p4.X, p4.Y];

                        Draw(p);

                        // Нахождение срединных точек для ромбов.
                        Draw(Square(new Point(p1.X, p.Y), h1, h4, h, step));

                        Draw(Square(new Point(p2.X, p.Y), h2, h3, h, step));

                        Draw(Square(new Point(p.X, p1.Y), h1, h2, h, step));

                        Draw(Square(new Point(p.X, p4.Y), h3, h4, h, step));

                        counter += 5;
                    }

                    ChangeProgressBarValueSafe(counter);
                }

                step /= 2;
            }

            ChangeProgressBarValueSafe(progressBar.Maximum);

            FillPicture();
        }

        // Отображает на "PictureBox" все точки, отмеченные на "Bitmap".
        private async void FillPicture() => await Task.Run(() => picture.Image = bmp);

        // Устанавливает на "Bitmap" точку, применяя к ней цвет, соответствующий ее высоте.
        private void Draw(Point p)
        {
            Color color = arrOfColors[arrOfHeights[p.X, p.Y] + -maxDepth];

            bmp.SetPixel(p.X, p.Y, color);
        }

        private enum Colors
        {
            oceanStartColor,
            oceanEndColor,
            seaStartColor,
            seaEndColor,
            landStartColor,
            landEndColor,
            mountainStartColor,
            mountainEndColor,
            snowStartColor,
            snowEndColor
        }

        // Полностью заполняет массив цветов. Каждый цвет будет соответствовать определенной высоте точки.
        // Весь цветовой диапазон был разбит на 5 частей, каждая из которых отвечает за свой биом.
        private void FillColors(Color[] colors)
        { 
            int i = 0;

            // Биом океана и других глубоких точек.
            FillBiome(ref i, -maxDepth + minOceanDepth, minOceanDepth - maxDepth,
                colors[(int)Colors.oceanStartColor], colors[(int)Colors.oceanEndColor]);

            // Биом моря и более мелких водоемов.
            FillBiome(ref i, -maxDepth, -minOceanDepth, colors[(int)Colors.seaStartColor], colors[(int)Colors.seaEndColor]);

            // Биом равнин и небольших холмов.
            FillBiome(ref i, -maxDepth + minMountainHeight, minMountainHeight,
                colors[(int)Colors.landStartColor], colors[(int)Colors.landEndColor]);

            // Биом гористой местности и гор.
            FillBiome(ref i, -maxDepth + snowLineHeight, snowLineHeight - minMountainHeight,
                colors[(int)Colors.mountainStartColor], colors[(int)Colors.mountainEndColor]);

            // Биом гор, покрытых снежными шапками.
            FillBiome(ref i, -maxDepth + maxHeight + 1, maxHeight - snowLineHeight,
                colors[(int)Colors.snowStartColor], colors[(int)Colors.snowEndColor]);
        }

        // Равномерно заполняет весь биом на всем его диапазоне начиная с цвета "startColor", пошагово переходя к цвету "endColor".
        private void FillBiome(ref int i, int cycleEnd, int range, Color startColor, Color endColor)
        {
            double[] steps = DefineSteps(startColor, endColor, range);

            for (int j = 0; i < cycleEnd; ++i, ++j)
            {   
                arrOfColors[i] = Color.FromArgb(startColor.R + (int)(j * steps[0]),
                    startColor.G + (int)(j * steps[1]), startColor.B + (int)(j * steps[2]));
            }
        }

        // Рассчитывает шаг для плавного изменения цвета.
        private double[] DefineSteps(Color startColor, Color endColor, int range)
        {
            double[] steps = new double[3];

            steps[0] = (endColor.R - startColor.R) / (double)range;

            steps[1] = (endColor.G - startColor.G) / (double)range;

            steps[2] = (endColor.B - startColor.B) / (double)range;

            return steps;
        }

        // Шаг "diamond" алгоритма "Diamond-square".
        // Нахождение срединной точки, присваивание ей значения, на основе среднего от угловых точек, плюс случайное число.
        private Point Diamond(Point p1, Point p2, Point p3, Point p4, int lenght)
        {
            Point p = new Point(p1.X + lenght / 2, p1.Y + lenght / 2);

            arrOfHeights[p.X, p.Y] = Convert.ToInt32((arrOfHeights[p1.X, p1.Y] + arrOfHeights[p2.X, p2.Y] + 
                arrOfHeights[p3.X, p3.Y] + arrOfHeights[p4.X, p4.Y]) / 4 + roughnessFactor * lenght * Rand());

            CheckExtremeValues(p);

            return p;
        }

        // Шаг "square" алгоритма "Diamond-square".
        // Нахождение срединной точки для одного из 4 ромбов.
        private Point Square(Point p, int h1, int h2, int h3, int lenght)
        {
            arrOfHeights[p.X, p.Y] = Convert.ToInt32((h1 + h2 + h3) / 3 + roughnessFactor * lenght * Rand());

            CheckExtremeValues(p);

            return p;
        }

        // Проверяет, не выходят ли полученные значения за допустимый максимум.
        // Если да, то меняет их на максимальные допустимые. 
        private void CheckExtremeValues(Point p)
        {
            int height = Math.Max(arrOfHeights[p.X, p.Y], maxDepth);

            arrOfHeights[p.X, p.Y] = Math.Min(height, maxHeight);
        }

        // Позволяет сохранить, полученное в ходе работы приложения, изображение.
        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Title = "Сохранить картинку как...",

                OverwritePrompt = true,

                CheckPathExists = true,

                // Форматы, в которых можно сохранить изображение.
                Filter = "JPG (*.JPG)|*.JPG|BMP (*.BMP)|*.BMP|PNG (*.PNG)|*.PNG|GIF (*.GIF)|*.GIF"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Попытка сохранить изображение.
                try
                {
                    picture.Image.Save(sfd.FileName);
                }

                // При ошибке показывает соответствующее окно и делает запись в лог файл.
                catch (Exception ex)
                {
                    string message = "Не удалось сохранить изображение. " + ex.Message;

                    MessageBox.Show(message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _ = new LogWriter(message);
                }
            }
        }

        // Возвращает контроль над элементами, заблокированными после нажатия на кнопку "Старт".
        // Обнуляет данные, полученные в результате алгоритма "Diamond-square", дает возможность вновь его использовать.
        private void Clear_Click(object sender, EventArgs e)
        {
            start.Enabled = rBar.Enabled = trackBarP1.Enabled = trackBarP2.Enabled = trackBarP3.Enabled = 
                trackBarP4.Enabled = additionalSettings.Enabled = pictureResolution.Enabled = true;

            progressBar.Value = 0;

            clear.Enabled = save.Enabled = picture.Enabled = progressBar.Visible = false;

            Initialize();

            ClearPicture();
        }

        // Изменяет значение переменной "roughnessFactor" и надписи "labelR".
        private void Rbar_Scroll(object sender, EventArgs e)
        {
            roughnessFactor = (float)(rBar.Value * 0.01);

            labelR.Text = "R = " + roughnessFactor.ToString();
        }

        private void Scroller(object sender, EventArgs e)
        {
            ChangeTexts();
        }

        // Отвечает за изменение значений надписей "labelHeight".
        private void ChangeTexts()
        {
            labelHeight1.Text = trackBarP1.Value.ToString();

            labelHeight2.Text = trackBarP2.Value.ToString();

            labelHeight3.Text = trackBarP3.Value.ToString();

            labelHeight4.Text = trackBarP4.Value.ToString();
        }

        // Закрывает форму "MainForm", тем самым выходит из программы.
        private void Exit_Click(object sender, EventArgs e) => Close();

        // Открывает форму "SettingsForm", при ее закрытии получает данные.
        private void AdditionalSettings_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();

            settingsForm.FormClosed += (object s, FormClosedEventArgs args) => ChangeSettings();

            Initialize();
        }

        // Применяет полученные данные с формы "SettingsForm".
        private void ChangeSettings()
        {
            maxDepth = settingsForm.MaxDepth;

            minOceanDepth = settingsForm.MinOceanDepth;

            minMountainHeight = settingsForm.MinMountainHeight;

            snowLineHeight = settingsForm.SnowLineHeight;

            maxHeight = settingsForm.MaxHeight;

            trackBarP1.Maximum = trackBarP2.Maximum = trackBarP3.Maximum = trackBarP4.Maximum = maxHeight;

            trackBarP1.Minimum = trackBarP2.Minimum = trackBarP3.Minimum = trackBarP4.Minimum = maxDepth;

            ChangeTexts();
        }

        // Изменяет разрешение изображения, которое будет получено в ходе работы программы.
        private void PictureResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Коэффициент отвечает за частоту повторений закрашивания одного и того же пикселя.
            const double REPET_COEFFICIENT = 1.67;

            // Получает новое разрешение изображения.
            string[] splitComponents = pictureResolution.SelectedItem.ToString().Split();

            imageSize = int.Parse(splitComponents[0]) - 1;

            // Применяет необходимые изменения.
            bmp = new Bitmap(imageSize + 1, imageSize + 1);

            arrOfHeights = new int[imageSize + 1, imageSize + 1];

            progressBar.Maximum = (int)((imageSize + 1) * (imageSize + 1) * REPET_COEFFICIENT);
        }

        // Позволяет рассмотреть полученное изображение в ходе работы программмы в деталях.
        private void Picture_Click(object sender, EventArgs e)
        {
            string imagePath = "Image.jpg";
            
            try
            {
                // Попытка сохранить изображение.
                picture.Image.Save(imagePath);

                // Пытается открыть только что сохраненное изображение программой, установленной по умолчанию, для просмотра фотографий.
                System.Diagnostics.Process.Start(imagePath);
            }

            // При ошибке показывает соответствующее окно и делает запись в лог файл.
            catch (Exception ex)
            {
                string message = "Не удалось открыть изображение. " + ex.Message;

                MessageBox.Show(message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ = new LogWriter(message);
            }
        }

        // Открывают руководство пользователя на необходимой странице.
        private void Start_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Start");
        }

        private void Picture_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Picture");
        }

        private void Save_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Save");
        }

        private void Clear_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Clear");
        }

        private void Resolution_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Resolution");
        }

        private void Roughness_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Roughness");
        }

        private void CornerHeights_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Corner heights");
        }

        private void AdditionalSettings_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Additional settings");
        }

        private void Exit_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            settingsForm.Helper("Exit");
        }
    }
}