using System;
using System.Windows.Forms;

namespace Diamond_square
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public int maxDepth
        {
            get => (int)numUpDownMaxDepth.Value; 
        }

        public int minOceanDepth
        {
            get => (int)numUpDownMinOceanDepth.Value;
        }

        public int minMountainHeight
        {
            get => (int)numUpDownMinMountainHeight.Value;
        }

        public int snowLineHeight
        {
            get => (int)numUpDownSnowLineHeight.Value;
        }

        public int maxHeight
        {
            get => (int)numUpDownMaxHeight.Value;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void NumUpDownMaxDepth_ValueChanged(object sender, EventArgs e)
        {
            if (maxDepth >= minOceanDepth)
                numUpDownMaxDepth.Value = minOceanDepth - 1;
        }

        private void NumUpDownMinOceanDepth_ValueChanged(object sender, EventArgs e)
        {
            if (minOceanDepth <= maxDepth)
                numUpDownMinOceanDepth.Value = maxDepth + 1;
        }

        private void NumUpDownMinMountainHeight_ValueChanged(object sender, EventArgs e)
        {
            if (minMountainHeight >= snowLineHeight)
                numUpDownMinMountainHeight.Value = snowLineHeight - 1;
        }

        private void NumUpDownSnowLineHeight_ValueChanged(object sender, EventArgs e)
        {
            if (snowLineHeight <= minMountainHeight)
                numUpDownSnowLineHeight.Value = minMountainHeight + 1;

            if (snowLineHeight >= maxHeight)
                numUpDownSnowLineHeight.Value = maxHeight - 1;
        }

        private void NumUpDownMaxHeight_ValueChanged(object sender, EventArgs e)
        {
            if (maxHeight <= snowLineHeight)
                numUpDownMaxHeight.Value = snowLineHeight + 1;
        }

        private void DefaultSettings_Click(object sender, EventArgs e)
        {
            numUpDownMaxDepth.Value = -11034;

            numUpDownMinOceanDepth.Value = -500;

            numUpDownMinMountainHeight.Value = 1000;

            numUpDownSnowLineHeight.Value = 4675;

            numUpDownMaxHeight.Value = 8848;
        }
    }
}