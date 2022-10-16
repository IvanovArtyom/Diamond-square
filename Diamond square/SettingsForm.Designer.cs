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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultSettings = new System.Windows.Forms.Button();
            this.colorInstaller = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUpDownMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownSnowLineHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinOceanDepth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinMountainHeight = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSnowLineHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinOceanDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMountainHeight)).BeginInit();
            this.panel2.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальная глубина (м):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минимальная глубина океанов (м):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Минимальная высота гор (м):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Высота снеговой линии (м):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Максимальная высота (м):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(65, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Настройка экстремальных точек";
            // 
            // defaultSettings
            // 
            this.defaultSettings.Location = new System.Drawing.Point(12, 370);
            this.defaultSettings.Name = "defaultSettings";
            this.defaultSettings.Size = new System.Drawing.Size(147, 29);
            this.defaultSettings.TabIndex = 11;
            this.defaultSettings.Text = "Настройки по умолчанию";
            this.defaultSettings.UseVisualStyleBackColor = true;
            this.defaultSettings.Click += new System.EventHandler(this.DefaultSettings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(491, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Настройка палитры";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numUpDownMaxHeight);
            this.panel1.Controls.Add(this.numUpDownMaxDepth);
            this.panel1.Controls.Add(this.numUpDownSnowLineHeight);
            this.panel1.Controls.Add(this.numUpDownMinOceanDepth);
            this.panel1.Controls.Add(this.numUpDownMinMountainHeight);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 317);
            this.panel1.TabIndex = 15;
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
            this.numUpDownMaxHeight.TabIndex = 9;
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
            this.numUpDownMaxDepth.TabIndex = 5;
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
            this.numUpDownSnowLineHeight.TabIndex = 8;
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
            this.numUpDownMinOceanDepth.TabIndex = 6;
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
            this.numUpDownMinMountainHeight.TabIndex = 7;
            this.numUpDownMinMountainHeight.Value = global::Diamond_square.Properties.Settings.Default.MinMountainHeight;
            this.numUpDownMinMountainHeight.ValueChanged += new System.EventHandler(this.NumUpDownMinMountainHeight_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.snowStartColor);
            this.panel2.Controls.Add(this.snowEndColor);
            this.panel2.Controls.Add(this.mountainStartColor);
            this.panel2.Controls.Add(this.mountainEndColor);
            this.panel2.Controls.Add(this.landStartColor);
            this.panel2.Controls.Add(this.landEndColor);
            this.panel2.Controls.Add(this.seaStartColor);
            this.panel2.Controls.Add(this.seaEndColor);
            this.panel2.Controls.Add(this.oceanStartColor);
            this.panel2.Controls.Add(this.oceanEndColor);
            this.panel2.Location = new System.Drawing.Point(443, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 359);
            this.panel2.TabIndex = 16;
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.defaultSettings);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "SettingsForm";
            this.Text = "Дополнительные настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSnowLineHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinOceanDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMountainHeight)).EndInit();
            this.panel2.ResumeLayout(false);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUpDownMaxDepth;
        private System.Windows.Forms.NumericUpDown numUpDownMinOceanDepth;
        private System.Windows.Forms.NumericUpDown numUpDownMinMountainHeight;
        private System.Windows.Forms.NumericUpDown numUpDownSnowLineHeight;
        private System.Windows.Forms.NumericUpDown numUpDownMaxHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button defaultSettings;
        private System.Windows.Forms.ColorDialog colorInstaller;
        private System.Windows.Forms.PictureBox oceanStartColor;
        private System.Windows.Forms.PictureBox oceanEndColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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