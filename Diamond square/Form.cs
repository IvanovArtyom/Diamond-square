using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diamond_square
{
    public partial class Form : System.Windows.Forms.Form
    {
        int LengthArr, NumberSquares;

        Bitmap Bmp;

        int[,] ArrOfHeights;

        Color[] ArrOfColors;

        Random Rnd;

        float R;

        public Form()
        {
            InitializeComponent();
            Initialize();
            ClearPicture();
        }

        private void Initialize()
        {
            LengthArr = 513;
            Bmp = new Bitmap(LengthArr, LengthArr);
            ArrOfHeights = new int[LengthArr, LengthArr];
            ArrOfColors = new Color[4451];
            Rnd = new Random();
            NumberSquares = 1;
            R = (float)(Rbar.Value * 0.01);
        }

        private void ClearPicture()
        {
            Graphics.FromImage(Bmp).Clear(Color.White);
            Picture.Image = Bmp;
        }

        private int Rand()
        {
            return Rnd.Next(-1, 1) == 0 ? 1 : -1;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (NumberSquares == 1)
            {
                ArrOfHeights[0, 0] = P1bar.Value;
                ArrOfHeights[LengthArr - 1, 0] = P2bar.Value;
                ArrOfHeights[LengthArr - 1, LengthArr - 1] = P3bar.Value;
                ArrOfHeights[0, LengthArr - 1] = P4bar.Value;

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

                Draw(0, LengthArr - 1); Draw(LengthArr - 1, 0);
                Draw(LengthArr - 1, LengthArr - 1); Draw(0, 0);
            }

            else if (NumberSquares == 65536)
                Start.Enabled = false;

            int Step = 512 / (int)Math.Sqrt(NumberSquares);

            for (int i = 0; i < 512; i += Step)
            {
                for (int j = 0; j < 512; j += Step)
                    Diamond(j, i, Step + j, i, Step + j, Step + i, j, Step + i);
            }

            NumberSquares *= 4;
            LabelNumSq.Text = "Кол-во квадратов: " + NumberSquares.ToString();
        }

        private void Draw(int x, int y)
        {
            Color color = ArrOfColors[ArrOfHeights[x, y] + 2000];

            Bmp.SetPixel(x, y, color);
            Picture.Image = Bmp;
        }

        private void Cycle(int ind1, int ind2, int R, int G, int B)
        {
            for (int i = ind1; i < ind2; ++i)
                ArrOfColors[i] = Color.FromArgb(R, G, B);
        }

        private void Diamond(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int L = x2 - x1;
            int x = x1 + (L / 2);
            int y = y1 + (L / 2);

            ArrOfHeights[x, y] = Convert.ToInt32((ArrOfHeights[x1, y1] + ArrOfHeights[x2, y2]
                + ArrOfHeights[x3, y3] + ArrOfHeights[x4, y4]) / 4 + R * L * Rand());
            Draw(x, y);

            BuildHeight(x1, y, ArrOfHeights[x1, y1], ArrOfHeights[x4, y4], ArrOfHeights[x, y], L);
            BuildHeight(x2, y, ArrOfHeights[x2, y2], ArrOfHeights[x3, y3], ArrOfHeights[x, y], L);
            BuildHeight(x, y1, ArrOfHeights[x1, y1], ArrOfHeights[x2, y2], ArrOfHeights[x, y], L);
            BuildHeight(x, y4, ArrOfHeights[x3, y3], ArrOfHeights[x4, y4], ArrOfHeights[x, y], L);
        }

        private void BuildHeight(int x, int y, int h1, int h2, int h3, int L)
        {
            ArrOfHeights[x, y] = Convert.ToInt32((h1 + h2 + h3) / 3 + R * L * Rand());
            Draw(x, y);
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
                    Picture.Image.Save(sfd.FileName);
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
            LabelNumSq.Text = "Кол-во квадратов: 1";
            Start.Enabled = true;

            Initialize();
            ClearPicture();
        }

        private void Rbar_Scroll(object sender, EventArgs e)
        {
            R = (float)(Rbar.Value * 0.01);
            LabelR.Text = "R = " + R.ToString();
        }

        private void Scroller(object sender, EventArgs e)
        {
            Label1.Text = P1bar.Value.ToString();
            Label2.Text = P2bar.Value.ToString();
            Label3.Text = P3bar.Value.ToString();
            Label4.Text = P4bar.Value.ToString();
        }

        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}