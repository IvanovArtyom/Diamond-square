
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
            this.NumUpDownMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NumUpDownSnowLineHeight = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownMinMountainHeight = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownMinOceanDepth = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownMaxDepth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSnowLineHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMinMountainHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMinOceanDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMaxDepth)).BeginInit();
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
            // NumUpDownMaxHeight
            // 
            this.NumUpDownMaxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MaxHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumUpDownMaxHeight.Location = new System.Drawing.Point(310, 210);
            this.NumUpDownMaxHeight.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NumUpDownMaxHeight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumUpDownMaxHeight.Name = "NumUpDownMaxHeight";
            this.NumUpDownMaxHeight.Size = new System.Drawing.Size(60, 20);
            this.NumUpDownMaxHeight.TabIndex = 9;
            this.NumUpDownMaxHeight.Value = global::Diamond_square.Properties.Settings.Default.MaxHeight;
            this.NumUpDownMaxHeight.ValueChanged += new System.EventHandler(this.NumUpDownMaxHeight_ValueChanged);
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
            // NumUpDownSnowLineHeight
            // 
            this.NumUpDownSnowLineHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "SnowLineHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumUpDownSnowLineHeight.Location = new System.Drawing.Point(310, 170);
            this.NumUpDownSnowLineHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDownSnowLineHeight.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumUpDownSnowLineHeight.Name = "NumUpDownSnowLineHeight";
            this.NumUpDownSnowLineHeight.Size = new System.Drawing.Size(60, 20);
            this.NumUpDownSnowLineHeight.TabIndex = 8;
            this.NumUpDownSnowLineHeight.Value = global::Diamond_square.Properties.Settings.Default.SnowLineHeight;
            this.NumUpDownSnowLineHeight.ValueChanged += new System.EventHandler(this.NumUpDownSnowLineHeight_ValueChanged);
            // 
            // NumUpDownMinMountainHeight
            // 
            this.NumUpDownMinMountainHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MinMountainHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumUpDownMinMountainHeight.Location = new System.Drawing.Point(310, 130);
            this.NumUpDownMinMountainHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumUpDownMinMountainHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownMinMountainHeight.Name = "NumUpDownMinMountainHeight";
            this.NumUpDownMinMountainHeight.Size = new System.Drawing.Size(60, 20);
            this.NumUpDownMinMountainHeight.TabIndex = 7;
            this.NumUpDownMinMountainHeight.Value = global::Diamond_square.Properties.Settings.Default.MinMountainHeight;
            this.NumUpDownMinMountainHeight.ValueChanged += new System.EventHandler(this.NumUpDownMinMountainHeight_ValueChanged);
            // 
            // NumUpDownMinOceanDepth
            // 
            this.NumUpDownMinOceanDepth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MinOceanDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumUpDownMinOceanDepth.Location = new System.Drawing.Point(310, 90);
            this.NumUpDownMinOceanDepth.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumUpDownMinOceanDepth.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.NumUpDownMinOceanDepth.Name = "NumUpDownMinOceanDepth";
            this.NumUpDownMinOceanDepth.Size = new System.Drawing.Size(60, 20);
            this.NumUpDownMinOceanDepth.TabIndex = 6;
            this.NumUpDownMinOceanDepth.Value = global::Diamond_square.Properties.Settings.Default.MinOceanDepth;
            this.NumUpDownMinOceanDepth.ValueChanged += new System.EventHandler(this.NumUpDownMinOceanDepth_ValueChanged);
            // 
            // NumUpDownMaxDepth
            // 
            this.NumUpDownMaxDepth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Diamond_square.Properties.Settings.Default, "MaxDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumUpDownMaxDepth.Location = new System.Drawing.Point(310, 50);
            this.NumUpDownMaxDepth.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumUpDownMaxDepth.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.NumUpDownMaxDepth.Name = "NumUpDownMaxDepth";
            this.NumUpDownMaxDepth.Size = new System.Drawing.Size(60, 20);
            this.NumUpDownMaxDepth.TabIndex = 5;
            this.NumUpDownMaxDepth.Value = global::Diamond_square.Properties.Settings.Default.MaxDepth;
            this.NumUpDownMaxDepth.ValueChanged += new System.EventHandler(this.NumUpDownMaxDepth_ValueChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 246);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumUpDownMaxHeight);
            this.Controls.Add(this.NumUpDownSnowLineHeight);
            this.Controls.Add(this.NumUpDownMinMountainHeight);
            this.Controls.Add(this.NumUpDownMinOceanDepth);
            this.Controls.Add(this.NumUpDownMaxDepth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 285);
            this.Name = "SettingsForm";
            this.Text = "Дополнительные настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSnowLineHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMinMountainHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMinOceanDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMaxDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumUpDownMaxDepth;
        private System.Windows.Forms.NumericUpDown NumUpDownMinOceanDepth;
        private System.Windows.Forms.NumericUpDown NumUpDownMinMountainHeight;
        private System.Windows.Forms.NumericUpDown NumUpDownSnowLineHeight;
        private System.Windows.Forms.NumericUpDown NumUpDownMaxHeight;
        private System.Windows.Forms.Label label6;
    }
}