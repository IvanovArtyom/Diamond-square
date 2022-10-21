using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

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

        private void Initialize()
        {
            ChangeSettings();

            Color[] definingСolors = settingsForm.Colors;

            arrOfColors = new Color[maxHeight - maxDepth + 1];

            FillColors(definingСolors);
        }

        private void ClearPicture()
        {
            Graphics.FromImage(bmp).Clear(Color.White);

            FillPicture();
        }

        private int Rand() => rnd.Next(-1, 1) == 0 ? 1 : -1;

        private async void Start_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;

            start.Enabled = save.Enabled = clear.Enabled = rBar.Enabled = p1Bar.Enabled = p2Bar.Enabled = 
                p3Bar.Enabled = p4Bar.Enabled = settings.Enabled = pictureResolution.Enabled = false; 

            arrOfHeights[0, 0] = p1Bar.Value;

            arrOfHeights[imageSize, 0] = p2Bar.Value;

            arrOfHeights[imageSize, imageSize] = p3Bar.Value;

            arrOfHeights[0, imageSize] = p4Bar.Value;

            Draw(new Point(0, imageSize)); 
            
            Draw(new Point(imageSize, 0));

            Draw(new Point(imageSize, imageSize)); 
            
            Draw(new Point(0, 0));

            Task task = Task.Run(() => DiamondSquare());

            await task;

            save.Enabled = true;

            clear.Enabled = true;

            save.Focus();
        }

        private void ChangeProgressBarValueSafe(int value)
        {
            if (progressBar.InvokeRequired)
                progressBar.Invoke(new Action<int>((i) => progressBar.Value = i), value);

            else progressBar.Value = value;
        }

        private void DiamondSquare()
        {
            int step = imageSize;

            int counter = 4;

            while (step != 1)
            {
                for (int i = 0; i < imageSize; i += step)
                {
                    for (int j = 0; j < imageSize; j += step)
                    {
                        Point p1 = new Point(j, i);

                        Point p2 = new Point(step + j, i);

                        Point p3 = new Point(step + j, step + i);

                        Point p4 = new Point(j, step + i);

                        Point p = Diamond(p1, p2, p3, p4, step);

                        int h = arrOfHeights[p.X, p.Y];

                        int h1 = arrOfHeights[p1.X, p1.Y];

                        int h2 = arrOfHeights[p2.X, p2.Y];

                        int h3 = arrOfHeights[p3.X, p3.Y];

                        int h4 = arrOfHeights[p4.X, p4.Y];

                        Draw(p);

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

        private async void FillPicture() => await Task.Run(() => picture.Image = bmp);

        private void Draw(Point p)
        {
            Color color = arrOfColors[arrOfHeights[p.X, p.Y] + -maxDepth];

            bmp.SetPixel(p.X, p.Y, color);
        }

        private void FillColors(Color[] colors)
        {
            int i = 0;

            FillBiome(ref i, -maxDepth + minOceanDepth, minOceanDepth - maxDepth, colors[0], colors[1]);

            FillBiome(ref i, -maxDepth, -minOceanDepth, colors[2], colors[3]);

            FillBiome(ref i, -maxDepth + minMountainHeight, minMountainHeight, colors[4], colors[5]);

            FillBiome(ref i, -maxDepth + snowLineHeight, snowLineHeight - minMountainHeight, colors[6], colors[7]);

            FillBiome(ref i, -maxDepth + maxHeight + 1, maxHeight - snowLineHeight, colors[8], colors[9]);
        }

        private void FillBiome(ref int i, int cycleEnd, int range, Color startColor, Color endColor)
        {
            double[] steps = DefineSteps(startColor, endColor, range);

            for (int j = 0; i < cycleEnd; ++i, ++j)
            {   
                arrOfColors[i] = Color.FromArgb(startColor.R + (int)(j * steps[0]),
                    startColor.G + (int)(j * steps[1]), startColor.B + (int)(j * steps[2]));
            }
        }

        private double[] DefineSteps(Color startColor, Color endColor, int range)
        {
            double[] steps = new double[3];

            steps[0] = (endColor.R - startColor.R) / (double)range;

            steps[1] = (endColor.G - startColor.G) / (double)range;

            steps[2] = (endColor.B - startColor.B) / (double)range;

            return steps;
        }

        private Point Diamond(Point p1, Point p2, Point p3, Point p4, int lenght)
        {
            Point p = new Point(p1.X + lenght / 2, p1.Y + lenght / 2);

            arrOfHeights[p.X, p.Y] = Convert.ToInt32((arrOfHeights[p1.X, p1.Y] + arrOfHeights[p2.X, p2.Y] + 
                arrOfHeights[p3.X, p3.Y] + arrOfHeights[p4.X, p4.Y]) / 4 + roughnessFactor * lenght * Rand());

            CheckExtremeValues(p);

            return p;
        }

        private Point Square(Point p, int h1, int h2, int h3, int lenght)
        {
            arrOfHeights[p.X, p.Y] = Convert.ToInt32((h1 + h2 + h3) / 3 + roughnessFactor * lenght * Rand());

            CheckExtremeValues(p);

            return p;
        }

        private void CheckExtremeValues(Point p)
        {
            int height = Math.Max(arrOfHeights[p.X, p.Y], maxDepth);

            arrOfHeights[p.X, p.Y] = Math.Min(height, maxHeight);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Title = "Сохранить картинку как...",

                OverwritePrompt = true,

                CheckPathExists = true,

                Filter = "JPG (*.JPG)|*.JPG|BMP (*.BMP)|*.BMP|PNG (*.PNG)|*.PNG|GIF (*.GIF)|*.GIF"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture.Image.Save(sfd.FileName);
                }

                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            start.Enabled = rBar.Enabled = p1Bar.Enabled = p2Bar.Enabled = p3Bar.Enabled = 
                p4Bar.Enabled = settings.Enabled = pictureResolution.Enabled = true;

            clear.Enabled = save.Enabled = false;

            progressBar.Value = 0;

            progressBar.Visible = false;

            Initialize();

            ClearPicture();
        }

        private void Rbar_Scroll(object sender, EventArgs e)
        {
            roughnessFactor = (float)(rBar.Value * 0.01);

            labelR.Text = "R = " + roughnessFactor.ToString();
        }

        private void Scroller(object sender, EventArgs e)
        {
            ChangeTexts();
        }

        private void ChangeTexts()
        {
            label1.Text = p1Bar.Value.ToString();

            label2.Text = p2Bar.Value.ToString();

            label3.Text = p3Bar.Value.ToString();

            label4.Text = p4Bar.Value.ToString();
        }

        private void Exit_Click(object sender, EventArgs e) => Close();

        private void Settings_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();

            settingsForm.FormClosed += (object s, FormClosedEventArgs args) => ChangeSettings();

            Initialize();
        }

        private void ChangeSettings()
        {
            maxDepth = settingsForm.MaxDepth;

            minOceanDepth = settingsForm.MinOceanDepth;

            minMountainHeight = settingsForm.MinMountainHeight;

            snowLineHeight = settingsForm.SnowLineHeight;

            maxHeight = settingsForm.MaxHeight;

            p1Bar.Maximum = p2Bar.Maximum = p3Bar.Maximum = p4Bar.Maximum = maxHeight;

            p1Bar.Minimum = p2Bar.Minimum = p3Bar.Minimum = p4Bar.Minimum = maxDepth;

            ChangeTexts();
        }

        private void PictureResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            start.Focus();

            string[] splitComponents = pictureResolution.SelectedItem.ToString().Split();

            imageSize = int.Parse(splitComponents[0]) - 1;

            bmp = new Bitmap(imageSize + 1, imageSize + 1);

            arrOfHeights = new int[imageSize + 1, imageSize + 1];

            progressBar.Maximum = (int)((imageSize + 1) * (imageSize + 1) * 1.67);
        }
    }
}