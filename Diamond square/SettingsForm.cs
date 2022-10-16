using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diamond_square
{
    public partial class SettingsForm : Form
    {
        private Color[] arrOfColors;

        public SettingsForm()
        {
            InitializeComponent();

            arrOfColors = new Color[] { oceanStartColor.BackColor, oceanEndColor.BackColor, seaStartColor.BackColor,
                seaEndColor.BackColor, landStartColor.BackColor, landEndColor.BackColor, mountainStartColor.BackColor,
                mountainEndColor.BackColor, snowStartColor.BackColor, snowEndColor.BackColor };
        }

        public Color[] Colors
        {
            get => arrOfColors;
        }

        public int MaxDepth
        {
            get => (int)numUpDownMaxDepth.Value; 
        }

        public int MinOceanDepth
        {
            get => (int)numUpDownMinOceanDepth.Value;
        }

        public int MinMountainHeight
        {
            get => (int)numUpDownMinMountainHeight.Value;
        }

        public int SnowLineHeight
        {
            get => (int)numUpDownSnowLineHeight.Value;
        }

        public int MaxHeight
        {
            get => (int)numUpDownMaxHeight.Value;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void NumUpDownMaxDepth_ValueChanged(object sender, EventArgs e)
        {
            if (MaxDepth >= MinOceanDepth)
                numUpDownMaxDepth.Value = MinOceanDepth - 1;
        }

        private void NumUpDownMinOceanDepth_ValueChanged(object sender, EventArgs e)
        {
            if (MinOceanDepth <= MaxDepth)
                numUpDownMinOceanDepth.Value = MaxDepth + 1;
        }

        private void NumUpDownMinMountainHeight_ValueChanged(object sender, EventArgs e)
        {
            if (MinMountainHeight >= SnowLineHeight)
                numUpDownMinMountainHeight.Value = SnowLineHeight - 1;
        }

        private void NumUpDownSnowLineHeight_ValueChanged(object sender, EventArgs e)
        {
            if (SnowLineHeight <= MinMountainHeight)
                numUpDownSnowLineHeight.Value = MinMountainHeight + 1;

            if (SnowLineHeight >= MaxHeight)
                numUpDownSnowLineHeight.Value = MaxHeight - 1;
        }

        private void NumUpDownMaxHeight_ValueChanged(object sender, EventArgs e)
        {
            if (MaxHeight <= SnowLineHeight)
                numUpDownMaxHeight.Value = SnowLineHeight + 1;
        }

        private void OceanStartColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                oceanStartColor.BackColor = arrOfColors[0] = colorInstaller.Color;
        }

        private void OceanEndColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                oceanEndColor.BackColor = arrOfColors[1] = colorInstaller.Color;
        }

        private void SeaStartColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
               seaStartColor.BackColor = arrOfColors[2] = colorInstaller.Color;
        }

        private void SeaEndColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                seaEndColor.BackColor = arrOfColors[3] = colorInstaller.Color;
        }

        private void LandStartColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                landStartColor.BackColor = arrOfColors[4] = colorInstaller.Color;
        }

        private void LandEndColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                landEndColor.BackColor = arrOfColors[5] = colorInstaller.Color;
        }

        private void MountainStartColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                mountainStartColor.BackColor = arrOfColors[6] = colorInstaller.Color;
        }

        private void MountainEndColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                mountainEndColor.BackColor = arrOfColors[7] = colorInstaller.Color;
        }

        private void SnowStartColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                snowStartColor.BackColor = arrOfColors[8] = colorInstaller.Color;
        }

        private void SnowEndColor_Click(object sender, EventArgs e)
        {
            if (colorInstaller.ShowDialog() == DialogResult.OK)
                snowEndColor.BackColor = arrOfColors[9] = colorInstaller.Color;
        }

        private void DefaultSettings_Click(object sender, EventArgs e)
        {
            numUpDownMaxDepth.Value = -11034;

            numUpDownMinOceanDepth.Value = -500;

            numUpDownMinMountainHeight.Value = 1000;

            numUpDownSnowLineHeight.Value = 4675;

            numUpDownMaxHeight.Value = 8848;

            oceanStartColor.BackColor = Color.FromArgb(0, 0, 0);

            oceanEndColor.BackColor = Color.FromArgb(0, 49, 102);

            seaStartColor.BackColor = Color.FromArgb(0, 49, 102);

            seaEndColor.BackColor = Color.FromArgb(66, 170, 250);

            landStartColor.BackColor = Color.FromArgb(107, 219, 107);

            landEndColor.BackColor = Color.FromArgb(14, 59, 14);

            mountainStartColor.BackColor = Color.FromArgb(255, 218, 158);

            mountainEndColor.BackColor = Color.FromArgb(5, 3, 0);

            snowStartColor.BackColor = Color.FromArgb(5, 3, 0);

            snowEndColor.BackColor = Color.FromArgb(255, 250, 250);

            arrOfColors = new Color[] { Color.FromArgb(0, 0, 0), Color.FromArgb(0, 49, 102), Color.FromArgb(0, 49, 102),
                Color.FromArgb(66, 170, 250), Color.FromArgb(107, 219, 107), Color.FromArgb(14, 59, 14),
                Color.FromArgb(255, 218, 158), Color.FromArgb(5, 3, 0),
                Color.FromArgb(5, 3, 0), Color.FromArgb(255, 250, 250) };
        }

        private void OceanStartColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет самой глубокой точки океана", oceanStartColor);
        }

        private void OceanEndColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет глубоководья", oceanEndColor);
        }

        private void SeaStartColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет моря", seaStartColor);
        }

        private void SeaEndColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет мелководья", seaEndColor);
        }

        private void LandStartColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет низины", landStartColor);
        }

        private void LandEndСolor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет холмогорья", landEndColor);
        }

        private void MountainStartColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет мелкогорья", mountainStartColor);
        }

        private void MountainEndСolor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет высокогорья", mountainEndColor);
        }

        private void SnowStartColor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет снеговой линии", snowStartColor);
        }

        private void SnowEndСolor_MouseEnter(object sender, EventArgs e)
        {
            prompt.Show("Цвет самой высокой точки горы", snowEndColor);
        }
    }
}