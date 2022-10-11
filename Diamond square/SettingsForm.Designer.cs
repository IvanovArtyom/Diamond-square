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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numUpDownMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownSnowLineHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinMountainHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinOceanDepth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.defaultSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSnowLineHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMountainHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinOceanDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальная глубина (м):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минимальная глубина океанов (м):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Минимальная высота гор (м):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Высота снеговой линии (м):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Максимальная высота (м):";
            // 
            // numUpDownMaxHeight
            // 
            this.numUpDownMaxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MaxHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMaxHeight.Location = new System.Drawing.Point(310, 210);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Настройка экстремальных точек";
            // 
            // numUpDownSnowLineHeight
            // 
            this.numUpDownSnowLineHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "SnowLineHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownSnowLineHeight.Location = new System.Drawing.Point(310, 170);
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
            // numUpDownMinMountainHeight
            // 
            this.numUpDownMinMountainHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MinMountainHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMinMountainHeight.Location = new System.Drawing.Point(310, 130);
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
            // numUpDownMinOceanDepth
            // 
            this.numUpDownMinOceanDepth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MinOceanDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMinOceanDepth.Location = new System.Drawing.Point(310, 90);
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
            // numUpDownMaxDepth
            // 
            this.numUpDownMaxDepth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MaxDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUpDownMaxDepth.Location = new System.Drawing.Point(310, 50);
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
            // defaultSettings
            // 
            this.defaultSettings.Location = new System.Drawing.Point(15, 250);
            this.defaultSettings.Name = "defaultSettings";
            this.defaultSettings.Size = new System.Drawing.Size(91, 23);
            this.defaultSettings.TabIndex = 11;
            this.defaultSettings.Text = "По умолчанию";
            this.defaultSettings.UseVisualStyleBackColor = true;
            this.defaultSettings.Click += new System.EventHandler(this.DefaultSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 291);
            this.Controls.Add(this.defaultSettings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numUpDownMaxHeight);
            this.Controls.Add(this.numUpDownSnowLineHeight);
            this.Controls.Add(this.numUpDownMinMountainHeight);
            this.Controls.Add(this.numUpDownMinOceanDepth);
            this.Controls.Add(this.numUpDownMaxDepth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 330);
            this.Name = "SettingsForm";
            this.Text = "Дополнительные настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSnowLineHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMountainHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinOceanDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxDepth)).EndInit();
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
    }
}