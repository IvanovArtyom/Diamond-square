using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Diamond_square
{
    public partial class MainForm : Form
    {
        const int IMAGE_SIZE = 512;

        int maxDepth;

        int minOceanDepth;

        int minMountainHeight;

        int snowLineHeight;

        int maxHeight;

        SettingsForm settingsForm;

        Bitmap bmp;

        int[,] arrOfHeights;

        Color[] arrOfColors;

        Random rnd;

        float roughnessFactor;

        public MainForm()
        {
            InitializeComponent();

            Initialize();

            ClearPicture();
        }

        private void Initialize()
        {
            settingsForm = new SettingsForm();

            ChangeSettings(settingsForm);

            bmp = new Bitmap(IMAGE_SIZE + 1, IMAGE_SIZE + 1);

            arrOfHeights = new int[IMAGE_SIZE + 1, IMAGE_SIZE + 1];

            arrOfColors = new Color[maxHeight - maxDepth + 1];

            rnd = new Random();

            roughnessFactor = (float)(rBar.Value * 0.01);

            FillColors();
        }

        private void ClearPicture()
        {
            Graphics.FromImage(bmp).Clear(Color.White);

            FillPicture();
        }

        private int Rand() => rnd.Next(-1, 1) == 0 ? 1 : -1;

        private void Start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;

            arrOfHeights[0, 0] = p1bar.Value;

            arrOfHeights[IMAGE_SIZE, 0] = p2bar.Value;

            arrOfHeights[IMAGE_SIZE, IMAGE_SIZE] = p3bar.Value;

            arrOfHeights[0, IMAGE_SIZE] = p4bar.Value;

            Draw(new Point(0, IMAGE_SIZE)); 
            
            Draw(new Point(IMAGE_SIZE, 0));

            Draw(new Point(IMAGE_SIZE, IMAGE_SIZE)); 
            
            Draw(new Point(0, 0));

            Thread secondThread = new Thread(new ThreadStart(DiamondSquare));

            secondThread.Start();
        }

        private void DiamondSquare()
        {
            int step = IMAGE_SIZE;

            while (step != 1)
            {
                for (int i = 0; i < IMAGE_SIZE; i += step)
                {
                    for (int j = 0; j < IMAGE_SIZE; j += step)
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
                    }
                }

                step /= 2;
            }

            FillPicture();
        }

        private async void FillPicture() => await Task.Run(() => picture.Image = bmp);

        private void Draw(Point p)
        {
            Color color = arrOfColors[arrOfHeights[p.X, p.Y] + -maxDepth];

            bmp.SetPixel(p.X, p.Y, color);
        }

        private void FillColors()
        {
            Color oceanStart = Color.FromArgb(0, 0, 0);

            Color oceanEnd = Color.FromArgb(0, 49, 102);

            Color seaStart = Color.FromArgb(0, 49, 102);

            Color seaEnd = Color.FromArgb(66, 170, 250);

            Color landStart = Color.FromArgb(107, 219, 107);

            Color landEnd = Color.FromArgb(14, 59, 14);

            Color mountainStart = Color.FromArgb(255, 218, 158);

            Color mountainEnd = Color.FromArgb(5, 3, 0);

            Color snowStart = Color.FromArgb(5, 3, 0);

            Color snowEnd = Color.FromArgb(255, 250, 250);

            int i = 0;

            FillBiome(ref i, -maxDepth + minOceanDepth, minOceanDepth - maxDepth, oceanStart, oceanEnd);

            FillBiome(ref i, -maxDepth, -minOceanDepth, seaStart, seaEnd);

            FillBiome(ref i, -maxDepth + minMountainHeight, minMountainHeight, landStart, landEnd);

            FillBiome(ref i, -maxDepth + snowLineHeight, snowLineHeight - minMountainHeight, mountainStart, mountainEnd);

            FillBiome(ref i, -maxDepth + maxHeight + 1, maxHeight - snowLineHeight, snowStart, snowEnd);
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

            arrOfHeights[p.X, p.Y] = Convert.ToInt32((arrOfHeights[p1.X, p1.Y] + arrOfHeights[p2.X, p2.Y]
                + arrOfHeights[p3.X, p3.Y] + arrOfHeights[p4.X, p4.Y]) / 4 + roughnessFactor * lenght * Rand());

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
            start.Enabled = true;

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
            label1.Text = p1bar.Value.ToString();

            label2.Text = p2bar.Value.ToString();

            label3.Text = p3bar.Value.ToString();

            label4.Text = p4bar.Value.ToString();
        }

        private void Exit_Click(object sender, EventArgs e) => Close();

        private void Settings_Click(object sender, EventArgs e)
        {     
            settingsForm.FormClosed += (object s, FormClosedEventArgs args) => ChangeSettings(settingsForm);

            settingsForm.ShowDialog();
        }

        private void ChangeSettings(SettingsForm form)
        {
            maxDepth = form.maxDepth;

            minOceanDepth = form.minOceanDepth;

            minMountainHeight = form.minMountainHeight;

            snowLineHeight = form.snowLineHeight;

            maxHeight = form.maxHeight;

            p1bar.Maximum = maxHeight;

            p2bar.Maximum = maxHeight;

            p3bar.Maximum = maxHeight;

            p4bar.Maximum = maxHeight;

            p1bar.Minimum = maxDepth;

            p2bar.Minimum = maxDepth;

            p3bar.Minimum = maxDepth;

            p4bar.Minimum = maxDepth;

            ChangeTexts();
        }
    }
}