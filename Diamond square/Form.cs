using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Diamond_square
{
    public partial class Form : System.Windows.Forms.Form
    {
        const int IMAGE_SIZE = 512;

        const int MAX_HEIGHT = 8848;

        const int MIN_HEIGHT = -11034;

        Bitmap bmp;

        int[,] arrOfHeights;

        Color[] arrOfColors;

        Random rnd;

        float roughnessFactor;

        public Form()
        {
            InitializeComponent();

            Initialize();

            ClearPicture();
        }

        private void Initialize()
        {
            bmp = new Bitmap(IMAGE_SIZE + 1, IMAGE_SIZE + 1);

            arrOfHeights = new int[IMAGE_SIZE + 1, IMAGE_SIZE + 1];

            arrOfColors = new Color[MAX_HEIGHT - MIN_HEIGHT + 1];

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
            int height = Math.Max(arrOfHeights[p.X, p.Y], MIN_HEIGHT);

            height = Math.Min(height, MAX_HEIGHT);

            Color color = arrOfColors[height + -MIN_HEIGHT];

            bmp.SetPixel(p.X, p.Y, color);
        }

        private void FillColors()
        {
            const int MIN_MOUNTAIN_HEIGHT = 700;

            double clrStep = 0.0057;

            for (int i = 0; i < -MIN_HEIGHT; ++i)
            {
                int clrValue = (int)(i * clrStep);

                arrOfColors[i] = Color.FromArgb(0 + clrValue, 0 + clrValue, 0 + clrValue * 4);
            }

            clrStep = -0.144;

            for (int i = -MIN_HEIGHT; i < -MIN_HEIGHT + MIN_MOUNTAIN_HEIGHT; ++i)
                arrOfColors[i] = Color.FromArgb(0, 200 + (int)(clrStep * (i + MIN_HEIGHT)), 0);

            clrStep = -0.0123;

            for (int i = -MIN_HEIGHT + MIN_MOUNTAIN_HEIGHT; i < -MIN_HEIGHT + MAX_HEIGHT + 1; ++i)
            {
                int clrValue = (int)((i + MIN_HEIGHT - MIN_MOUNTAIN_HEIGHT) * clrStep);

                arrOfColors[i] = Color.FromArgb(255 + clrValue * 2, 210 + clrValue * 2, 100 + clrValue);
            }
        }

        private Point Diamond(Point p1, Point p2, Point p3, Point p4, int lenght)
        {
            Point p = new Point(p1.X + lenght / 2, p1.Y + lenght / 2);

            arrOfHeights[p.X, p.Y] = Convert.ToInt32((arrOfHeights[p1.X, p1.Y] + arrOfHeights[p2.X, p2.Y]
                + arrOfHeights[p3.X, p3.Y] + arrOfHeights[p4.X, p4.Y]) / 4 + roughnessFactor * lenght * Rand());

            return p;
        }

        private Point Square(Point p, int h1, int h2, int h3, int lenght)
        {
            arrOfHeights[p.X, p.Y] = Convert.ToInt32((h1 + h2 + h3) / 3 + roughnessFactor * lenght * Rand());

            return p;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Title = "Сохранить картинку как...",

                OverwritePrompt = true,

                CheckPathExists = true,

                ShowHelp = true,

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
            label1.Text = p1bar.Value.ToString();

            label2.Text = p2bar.Value.ToString();

            label3.Text = p3bar.Value.ToString();

            label4.Text = p4bar.Value.ToString();
        }

        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}