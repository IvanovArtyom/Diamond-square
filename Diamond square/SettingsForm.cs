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
            get => (int)NumUpDownMaxDepth.Value; 
        }

        public int minOceanDepth
        {
            get => (int)NumUpDownMinOceanDepth.Value;
        }

        public int minMountainHeight
        {
            get => (int)NumUpDownMinMountainHeight.Value;
        }

        public int snowLineHeight
        {
            get => (int)NumUpDownSnowLineHeight.Value;
        }

        public int maxHeight
        {
            get => (int)NumUpDownMaxHeight.Value;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void NumUpDownMaxDepth_ValueChanged(object sender, System.EventArgs e)
        {
            if (maxDepth >= minOceanDepth)
                NumUpDownMaxDepth.Value = minOceanDepth - 1;
        }

        private void NumUpDownMinOceanDepth_ValueChanged(object sender, System.EventArgs e)
        {
            if (minOceanDepth <= maxDepth)
                NumUpDownMinOceanDepth.Value = maxDepth + 1;
        }

        private void NumUpDownMinMountainHeight_ValueChanged(object sender, System.EventArgs e)
        {
            if (minMountainHeight >= snowLineHeight)
                NumUpDownMinMountainHeight.Value = snowLineHeight - 1;
        }

        private void NumUpDownSnowLineHeight_ValueChanged(object sender, System.EventArgs e)
        {
            if (snowLineHeight <= minMountainHeight)
                NumUpDownSnowLineHeight.Value = minMountainHeight + 1;

            if (snowLineHeight >= maxHeight)
                NumUpDownSnowLineHeight.Value = maxHeight - 1;
        }

        private void NumUpDownMaxHeight_ValueChanged(object sender, System.EventArgs e)
        {
            if (maxHeight <= snowLineHeight)
                NumUpDownMaxHeight.Value = snowLineHeight + 1;
        }
    }
}