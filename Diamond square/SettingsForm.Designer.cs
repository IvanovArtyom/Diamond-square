namespace Diamond_square
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.labelMaxDepth = new System.Windows.Forms.Label();
            this.labelMinOceanDepth = new System.Windows.Forms.Label();
            this.labelMinMountainHeight = new System.Windows.Forms.Label();
            this.labelSnowLineHeight = new System.Windows.Forms.Label();
            this.labelMaxHeight = new System.Windows.Forms.Label();
            this.labelExtremePointSetting = new System.Windows.Forms.Label();
            this.defaultSettings = new System.Windows.Forms.Button();
            this.colorInstaller = new System.Windows.Forms.ColorDialog();
            this.labelPaletteSetting = new System.Windows.Forms.Label();
            this.panelExtremePointSetting = new System.Windows.Forms.Panel();
            this.numUpDownMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownSnowLineHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinOceanDepth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinMountainHeight = new System.Windows.Forms.NumericUpDown();
            this.panelPaletteSetting = new System.Windows.Forms.Panel();
            this.snowStartColor = new System.Windows.Forms.PictureBox();
            this.snowEndColor = new System.Windows.Forms.PictureBox();
            this.mountainStartColor = new System.Windows.Forms.PictureBox();
            this.mountainEndColor = new System.Windows.Forms.PictureBox();
            this.landStartColor = new System.Windows.Forms.PictureBox();
            this.landEndColor = new System.Windows.Forms.PictureBox();
            this.seaStartColor = new System.Windows.Forms.PictureBox();
            this.seaEndColor = new System.Windows.Forms.PictureBox();
            this.oceanStartColor = new System.Windows.Forms.PictureBox();
            this.oceanEndColor = new System.Windows.Forms.PictureBox();
            this.prompt = new System.Windows.Forms.ToolTip(this.components);
            this.panelExtremePointSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSnowLineHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinOceanDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMountainHeight)).BeginInit();
            this.panelPaletteSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snowStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowEndColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountainStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountainEndColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landEndColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaEndColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanEndColor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaxDepth
            // 
            this.labelMaxDepth.AutoSize = true;
            this.labelMaxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxDepth.Location = new System.Drawing.Point(33, 36);
            this.labelMaxDepth.Name = "labelMaxDepth";
            this.labelMaxDepth.Size = new System.Drawing.Size(208, 16);
            this.labelMaxDepth.TabIndex = 0;
            this.labelMaxDepth.Text = "Максимальная глубина (м):";
            // 
            // labelMinOceanDepth
            // 
            this.labelMinOceanDepth.AutoSize = true;
            this.labelMinOceanDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinOceanDepth.Location = new System.Drawing.Point(33, 92);
            this.labelMinOceanDepth.Name = "labelMinOceanDepth";
            this.labelMinOceanDepth.Size = new System.Drawing.Size(267, 16);
            this.labelMinOceanDepth.TabIndex = 1;
            this.labelMinOceanDepth.Text = "Минимальная глубина океанов (м):";
            // 
            // labelMinMountainHeight
            // 
            this.labelMinMountainHeight.AutoSize = true;
            this.labelMinMountainHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinMountainHeight.Location = new System.Drawing.Point(33, 148);
            this.labelMinMountainHeight.Name = "labelMinMountainHeight";
            this.labelMinMountainHeight.Size = new System.Drawing.Size(222, 16);
            this.labelMinMountainHeight.TabIndex = 2;
            this.labelMinMountainHeight.Text = "Минимальная высота гор (м):";
            // 
            // labelSnowLineHeight
            // 
            this.labelSnowLineHeight.AutoSize = true;
            this.labelSnowLineHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSnowLineHeight.Location = new System.Drawing.Point(33, 204);
            this.labelSnowLineHeight.Name = "labelSnowLineHeight";
            this.labelSnowLineHeight.Size = new System.Drawing.Size(211, 16);
            this.labelSnowLineHeight.TabIndex = 3;
            this.labelSnowLineHeight.Text = "Высота снеговой линии (м):";
            // 
            // labelMaxHeight
            // 
            this.labelMaxHeight.AutoSize = true;
            this.labelMaxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxHeight.Location = new System.Drawing.Point(33, 260);
            this.labelMaxHeight.Name = "labelMaxHeight";
            this.labelMaxHeight.Size = new System.Drawing.Size(200, 16);
            this.labelMaxHeight.TabIndex = 4;
            this.labelMaxHeight.Text = "Максимальная высота (м):";
            // 
            // labelExtremePointSetting
            // 
            this.labelExtremePointSetting.AutoSize = true;
            this.labelExtremePointSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtremePointSetting.Location = new System.Drawing.Point(65, 9);
            this.labelExtremePointSetting.Name = "labelExtremePointSetting";
            this.labelExtremePointSetting.Size = new System.Drawing.Size(290, 20);
            this.labelExtremePointSetting.TabIndex = 10;
            this.labelExtremePointSetting.Text = "Настройка экстремальных точек";
            this.labelExtremePointSetting.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ExtremePointSetting_HelpRequested);
            // 
            // defaultSettings
            // 
            this.defaultSettings.Location = new System.Drawing.Point(12, 370);
            this.defaultSettings.Name = "defaultSettings";
            this.defaultSettings.Size = new System.Drawing.Size(147, 29);
            this.defaultSettings.TabIndex = 1;
            this.defaultSettings.Text = "Настройки по умолчанию";
            this.defaultSettings.UseVisualStyleBackColor = true;
            this.defaultSettings.Click += new System.EventHandler(this.DefaultSettings_Click);
            this.defaultSettings.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DefaultSettings_HelpRequested);
            // 
            // labelPaletteSetting
            // 
            this.labelPaletteSetting.AutoSize = true;
            this.labelPaletteSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaletteSetting.Location = new System.Drawing.Point(491, 9);
            this.labelPaletteSetting.Name = "labelPaletteSetting";
            this.labelPaletteSetting.Size = new System.Drawing.Size(178, 20);
            this.labelPaletteSetting.TabIndex = 14;
            this.labelPaletteSetting.Text = "Настройка палитры";
            this.labelPaletteSetting.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PaletteSetting_HelpRequested);
            // 
            // panelExtremePointSetting
            // 
            this.panelExtremePointSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelExtremePointSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelExtremePointSetting.Controls.Add(this.labelMinOceanDepth);
            this.panelExtremePointSetting.Controls.Add(this.labelMaxDepth);
            this.panelExtremePointSetting.Controls.Add(this.labelMinMountainHeight);
            this.panelExtremePointSetting.Controls.Add(this.labelSnowLineHeight);
            this.panelExtremePointSetting.Controls.Add(this.labelMaxHeight);
            this.panelExtremePointSetting.Controls.Add(this.numUpDownMaxHeight);
            this.panelExtremePointSetting.Controls.Add(this.numUpDownMaxDepth);
            this.panelExtremePointSetting.Controls.Add(this.numUpDownSnowLineHeight);
            this.panelExtremePointSetting.Controls.Add(this.numUpDownMinOceanDepth);
            this.panelExtremePointSetting.Controls.Add(this.numUpDownMinMountainHeight);
            this.panelExtremePointSetting.Location = new System.Drawing.Point(12, 41);
            this.panelExtremePointSetting.Name = "panelExtremePointSetting";
            this.panelExtremePointSetting.Size = new System.Drawing.Size(420, 317);
            this.panelExtremePointSetting.TabIndex = 15;
            this.panelExtremePointSetting.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ExtremePointSetting_HelpRequested);
            // 
            // numUpDownMaxHeight
            // 
            this.numUpDownMaxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MaxHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMaxHeight.Location = new System.Drawing.Point(320, 260);
            this.numUpDownMaxHeight.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpDownMaxHeight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownMaxHeight.Name = "numUpDownMaxHeight";
            this.numUpDownMaxHeight.Size = new System.Drawing.Size(60, 20);
            this.numUpDownMaxHeight.TabIndex = 6;
            this.numUpDownMaxHeight.Value = global::Diamond_square.Properties.Settings.Default.MaxHeight;
            this.numUpDownMaxHeight.ValueChanged += new System.EventHandler(this.NumUpDownMaxHeight_ValueChanged);
            // 
            // numUpDownMaxDepth
            // 
            this.numUpDownMaxDepth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MaxDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMaxDepth.Location = new System.Drawing.Point(320, 36);
            this.numUpDownMaxDepth.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUpDownMaxDepth.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numUpDownMaxDepth.Name = "numUpDownMaxDepth";
            this.numUpDownMaxDepth.Size = new System.Drawing.Size(60, 20);
            this.numUpDownMaxDepth.TabIndex = 2;
            this.numUpDownMaxDepth.Value = global::Diamond_square.Properties.Settings.Default.MaxDepth;
            this.numUpDownMaxDepth.ValueChanged += new System.EventHandler(this.NumUpDownMaxDepth_ValueChanged);
            // 
            // numUpDownSnowLineHeight
            // 
            this.numUpDownSnowLineHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "SnowLineHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownSnowLineHeight.Location = new System.Drawing.Point(320, 204);
            this.numUpDownSnowLineHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownSnowLineHeight.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownSnowLineHeight.Name = "numUpDownSnowLineHeight";
            this.numUpDownSnowLineHeight.Size = new System.Drawing.Size(60, 20);
            this.numUpDownSnowLineHeight.TabIndex = 5;
            this.numUpDownSnowLineHeight.Value = global::Diamond_square.Properties.Settings.Default.SnowLineHeight;
            this.numUpDownSnowLineHeight.ValueChanged += new System.EventHandler(this.NumUpDownSnowLineHeight_ValueChanged);
            // 
            // numUpDownMinOceanDepth
            // 
            this.numUpDownMinOceanDepth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MinOceanDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMinOceanDepth.Location = new System.Drawing.Point(320, 92);
            this.numUpDownMinOceanDepth.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numUpDownMinOceanDepth.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.numUpDownMinOceanDepth.Name = "numUpDownMinOceanDepth";
            this.numUpDownMinOceanDepth.Size = new System.Drawing.Size(60, 20);
            this.numUpDownMinOceanDepth.TabIndex = 3;
            this.numUpDownMinOceanDepth.Value = global::Diamond_square.Properties.Settings.Default.MinOceanDepth;
            this.numUpDownMinOceanDepth.ValueChanged += new System.EventHandler(this.NumUpDownMinOceanDepth_ValueChanged);
            // 
            // numUpDownMinMountainHeight
            // 
            this.numUpDownMinMountainHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MinMountainHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMinMountainHeight.Location = new System.Drawing.Point(320, 148);
            this.numUpDownMinMountainHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDownMinMountainHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownMinMountainHeight.Name = "numUpDownMinMountainHeight";
            this.numUpDownMinMountainHeight.Size = new System.Drawing.Size(60, 20);
            this.numUpDownMinMountainHeight.TabIndex = 4;
            this.numUpDownMinMountainHeight.Value = global::Diamond_square.Properties.Settings.Default.MinMountainHeight;
            this.numUpDownMinMountainHeight.ValueChanged += new System.EventHandler(this.NumUpDownMinMountainHeight_ValueChanged);
            // 
            // panelPaletteSetting
            // 
            this.panelPaletteSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPaletteSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPaletteSetting.Controls.Add(this.snowStartColor);
            this.panelPaletteSetting.Controls.Add(this.snowEndColor);
            this.panelPaletteSetting.Controls.Add(this.mountainStartColor);
            this.panelPaletteSetting.Controls.Add(this.mountainEndColor);
            this.panelPaletteSetting.Controls.Add(this.landStartColor);
            this.panelPaletteSetting.Controls.Add(this.landEndColor);
            this.panelPaletteSetting.Controls.Add(this.seaStartColor);
            this.panelPaletteSetting.Controls.Add(this.seaEndColor);
            this.panelPaletteSetting.Controls.Add(this.oceanStartColor);
            this.panelPaletteSetting.Controls.Add(this.oceanEndColor);
            this.panelPaletteSetting.Location = new System.Drawing.Point(443, 40);
            this.panelPaletteSetting.Name = "panelPaletteSetting";
            this.panelPaletteSetting.Size = new System.Drawing.Size(279, 359);
            this.panelPaletteSetting.TabIndex = 16;
            this.panelPaletteSetting.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PaletteSetting_HelpRequested);
            // 
            // snowStartColor
            // 
            this.snowStartColor.BackColor = global::Diamond_square.Properties.Settings.Default.SnowStartColor;
            this.snowStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snowStartColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "SnowStartColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.snowStartColor.Location = new System.Drawing.Point(3, 287);
            this.snowStartColor.Name = "snowStartColor";
            this.snowStartColor.Size = new System.Drawing.Size(130, 65);
            this.snowStartColor.TabIndex = 20;
            this.snowStartColor.TabStop = false;
            this.snowStartColor.Click += new System.EventHandler(this.SnowStartColor_Click);
            this.snowStartColor.MouseEnter += new System.EventHandler(this.SnowStartColor_MouseEnter);
            // 
            // snowEndColor
            // 
            this.snowEndColor.BackColor = global::Diamond_square.Properties.Settings.Default.SnowEndColor;
            this.snowEndColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snowEndColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "SnowEndColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.snowEndColor.Location = new System.Drawing.Point(142, 287);
            this.snowEndColor.Name = "snowEndColor";
            this.snowEndColor.Size = new System.Drawing.Size(130, 65);
            this.snowEndColor.TabIndex = 21;
            this.snowEndColor.TabStop = false;
            this.snowEndColor.Click += new System.EventHandler(this.SnowEndColor_Click);
            this.snowEndColor.MouseEnter += new System.EventHandler(this.SnowEndСolor_MouseEnter);
            // 
            // mountainStartColor
            // 
            this.mountainStartColor.BackColor = global::Diamond_square.Properties.Settings.Default.MountainStartColor;
            this.mountainStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mountainStartColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "MountainStartColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mountainStartColor.Location = new System.Drawing.Point(3, 216);
            this.mountainStartColor.Name = "mountainStartColor";
            this.mountainStartColor.Size = new System.Drawing.Size(130, 65);
            this.mountainStartColor.TabIndex = 18;
            this.mountainStartColor.TabStop = false;
            this.mountainStartColor.Click += new System.EventHandler(this.MountainStartColor_Click);
            this.mountainStartColor.MouseEnter += new System.EventHandler(this.MountainStartColor_MouseEnter);
            // 
            // mountainEndColor
            // 
            this.mountainEndColor.BackColor = global::Diamond_square.Properties.Settings.Default.MountainEndColor;
            this.mountainEndColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mountainEndColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "MountainEndColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mountainEndColor.Location = new System.Drawing.Point(142, 216);
            this.mountainEndColor.Name = "mountainEndColor";
            this.mountainEndColor.Size = new System.Drawing.Size(130, 65);
            this.mountainEndColor.TabIndex = 19;
            this.mountainEndColor.TabStop = false;
            this.mountainEndColor.Click += new System.EventHandler(this.MountainEndColor_Click);
            this.mountainEndColor.MouseEnter += new System.EventHandler(this.MountainEndСolor_MouseEnter);
            // 
            // landStartColor
            // 
            this.landStartColor.BackColor = global::Diamond_square.Properties.Settings.Default.LandStartColor;
            this.landStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.landStartColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "LandStartColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.landStartColor.Location = new System.Drawing.Point(3, 145);
            this.landStartColor.Name = "landStartColor";
            this.landStartColor.Size = new System.Drawing.Size(130, 65);
            this.landStartColor.TabIndex = 16;
            this.landStartColor.TabStop = false;
            this.landStartColor.Click += new System.EventHandler(this.LandStartColor_Click);
            this.landStartColor.MouseEnter += new System.EventHandler(this.LandStartColor_MouseEnter);
            // 
            // landEndColor
            // 
            this.landEndColor.BackColor = global::Diamond_square.Properties.Settings.Default.LandEndColor;
            this.landEndColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.landEndColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "LandEndColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.landEndColor.Location = new System.Drawing.Point(142, 145);
            this.landEndColor.Name = "landEndColor";
            this.landEndColor.Size = new System.Drawing.Size(130, 65);
            this.landEndColor.TabIndex = 17;
            this.landEndColor.TabStop = false;
            this.landEndColor.Click += new System.EventHandler(this.LandEndColor_Click);
            this.landEndColor.MouseEnter += new System.EventHandler(this.LandEndСolor_MouseEnter);
            // 
            // seaStartColor
            // 
            this.seaStartColor.BackColor = global::Diamond_square.Properties.Settings.Default.SeaStartColor;
            this.seaStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seaStartColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "SeaStartColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seaStartColor.Location = new System.Drawing.Point(3, 74);
            this.seaStartColor.Name = "seaStartColor";
            this.seaStartColor.Size = new System.Drawing.Size(130, 65);
            this.seaStartColor.TabIndex = 14;
            this.seaStartColor.TabStop = false;
            this.seaStartColor.Click += new System.EventHandler(this.SeaStartColor_Click);
            this.seaStartColor.MouseEnter += new System.EventHandler(this.SeaStartColor_MouseEnter);
            // 
            // seaEndColor
            // 
            this.seaEndColor.BackColor = global::Diamond_square.Properties.Settings.Default.SeaEndColor;
            this.seaEndColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seaEndColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "SeaEndColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seaEndColor.Location = new System.Drawing.Point(142, 74);
            this.seaEndColor.Name = "seaEndColor";
            this.seaEndColor.Size = new System.Drawing.Size(130, 65);
            this.seaEndColor.TabIndex = 15;
            this.seaEndColor.TabStop = false;
            this.seaEndColor.Click += new System.EventHandler(this.SeaEndColor_Click);
            this.seaEndColor.MouseEnter += new System.EventHandler(this.SeaEndColor_MouseEnter);
            // 
            // oceanStartColor
            // 
            this.oceanStartColor.BackColor = global::Diamond_square.Properties.Settings.Default.OceanStartColor;
            this.oceanStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oceanStartColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "OceanStartColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.oceanStartColor.Location = new System.Drawing.Point(3, 3);
            this.oceanStartColor.Name = "oceanStartColor";
            this.oceanStartColor.Size = new System.Drawing.Size(130, 65);
            this.oceanStartColor.TabIndex = 12;
            this.oceanStartColor.TabStop = false;
            this.oceanStartColor.Click += new System.EventHandler(this.OceanStartColor_Click);
            this.oceanStartColor.MouseEnter += new System.EventHandler(this.OceanStartColor_MouseEnter);
            // 
            // oceanEndColor
            // 
            this.oceanEndColor.BackColor = global::Diamond_square.Properties.Settings.Default.OceanEndColor;
            this.oceanEndColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oceanEndColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Diamond_square.Properties.Settings.Default, "OceanEndColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.oceanEndColor.Location = new System.Drawing.Point(142, 3);
            this.oceanEndColor.Name = "oceanEndColor";
            this.oceanEndColor.Size = new System.Drawing.Size(130, 65);
            this.oceanEndColor.TabIndex = 13;
            this.oceanEndColor.TabStop = false;
            this.oceanEndColor.Click += new System.EventHandler(this.OceanEndColor_Click);
            this.oceanEndColor.MouseEnter += new System.EventHandler(this.OceanEndColor_MouseEnter);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.labelPaletteSetting);
            this.Controls.Add(this.panelPaletteSetting);
            this.Controls.Add(this.panelExtremePointSetting);
            this.Controls.Add(this.labelExtremePointSetting);
            this.Controls.Add(this.defaultSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "SettingsForm";
            this.Text = "Дополнительные настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.panelExtremePointSetting.ResumeLayout(false);
            this.panelExtremePointSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSnowLineHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinOceanDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMountainHeight)).EndInit();
            this.panelPaletteSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snowStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowEndColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountainStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountainEndColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landEndColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaEndColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanEndColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaxDepth;
        private System.Windows.Forms.Label labelMinOceanDepth;
        private System.Windows.Forms.Label labelMinMountainHeight;
        private System.Windows.Forms.Label labelSnowLineHeight;
        private System.Windows.Forms.Label labelMaxHeight;
        private System.Windows.Forms.NumericUpDown numUpDownMaxDepth;
        private System.Windows.Forms.NumericUpDown numUpDownMinOceanDepth;
        private System.Windows.Forms.NumericUpDown numUpDownMinMountainHeight;
        private System.Windows.Forms.NumericUpDown numUpDownSnowLineHeight;
        private System.Windows.Forms.NumericUpDown numUpDownMaxHeight;
        private System.Windows.Forms.Label labelExtremePointSetting;
        private System.Windows.Forms.Button defaultSettings;
        private System.Windows.Forms.ColorDialog colorInstaller;
        private System.Windows.Forms.PictureBox oceanStartColor;
        private System.Windows.Forms.PictureBox oceanEndColor;
        private System.Windows.Forms.Label labelPaletteSetting;
        private System.Windows.Forms.Panel panelExtremePointSetting;
        private System.Windows.Forms.Panel panelPaletteSetting;
        private System.Windows.Forms.PictureBox seaEndColor;
        private System.Windows.Forms.PictureBox snowStartColor;
        private System.Windows.Forms.PictureBox snowEndColor;
        private System.Windows.Forms.PictureBox mountainStartColor;
        private System.Windows.Forms.PictureBox mountainEndColor;
        private System.Windows.Forms.PictureBox landStartColor;
        private System.Windows.Forms.PictureBox landEndColor;
        private System.Windows.Forms.PictureBox seaStartColor;
        private System.Windows.Forms.ToolTip prompt;
    }
}