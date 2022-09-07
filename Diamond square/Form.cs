using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diamond_square
{
    public partial class Form : System.Windows.Forms.Form
    {
        const int IMAGE_SIZE = 512;

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

            arrOfColors = new Color[4451];

            rnd = new Random();

            roughnessFactor = (float)(rBar.Value * 0.01);

            Cycle(0, 1400, 0, 0, 70);

            Cycle(1400, 1550, 25, 25, 112);

            Cycle(1550, 1700, 35, 35, 150);

            Cycle(1700, 1850, 50, 50, 200);

            Cycle(1850, 2000, 75, 75, 237);

            Cycle(2000, 2100, 0, 180, 0);

            Cycle(2100, 2200, 0, 160, 0);

            Cycle(2200, 2300, 0, 140, 0);

            Cycle(2300, 2400, 0, 120, 0);

            Cycle(2400, 2500, 0, 100, 0);

            Cycle(2500, 2600, 225, 170, 42);

            Cycle(2600, 2750, 195, 140, 34);

            Cycle(2750, 2900, 165, 110, 26);

            Cycle(2900, 3050, 135, 80, 18);

            Cycle(3050, 4450, 105, 50, 10);
        }

        private void ClearPicture()
        {
            Graphics.FromImage(bmp).Clear(Color.White);

            picture.Image = bmp;
        }

        private int Rand() => rnd.Next(-1, 1) == 0 ? 1 : -1;

        private void Start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;

            arrOfHeights[0, 0] = p1bar.Value;

            arrOfHeights[IMAGE_SIZE, 0] = p2bar.Value;

            arrOfHeights[IMAGE_SIZE, IMAGE_SIZE] = p3bar.Value;

            arrOfHeights[0, IMAGE_SIZE] = p4bar.Value;

            Draw(new Point(0, IMAGE_SIZE)); Draw(new Point(IMAGE_SIZE, 0));

            Draw(new Point(IMAGE_SIZE, IMAGE_SIZE)); Draw(new Point(0, 0));

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
        }

        private void Draw(Point p)
        {
            Color color = arrOfColors[arrOfHeights[p.X, p.Y] + 2000];

            bmp.SetPixel(p.X, p.Y, color);

            picture.Image = bmp;
        }

        private void Cycle(int ind1, int ind2, int R, int G, int B)
        {
            for (int i = ind1; i < ind2; ++i)
                arrOfColors[i] = Color.FromArgb(R, G, B);
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