namespace Diamond_square
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picture = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.rBar = new System.Windows.Forms.TrackBar();
            this.labelR = new System.Windows.Forms.Label();
            this.labelRoughness = new System.Windows.Forms.Label();
            this.trackBarP1 = new System.Windows.Forms.TrackBar();
            this.labelHeight1 = new System.Windows.Forms.Label();
            this.labelHeight2 = new System.Windows.Forms.Label();
            this.trackBarP2 = new System.Windows.Forms.TrackBar();
            this.labelHeight3 = new System.Windows.Forms.Label();
            this.trackBarP3 = new System.Windows.Forms.TrackBar();
            this.labelHeight4 = new System.Windows.Forms.Label();
            this.trackBarP4 = new System.Windows.Forms.TrackBar();
            this.labelCornerHeight2 = new System.Windows.Forms.Label();
            this.labelCornerHeight3 = new System.Windows.Forms.Label();
            this.labelCornerHeight4 = new System.Windows.Forms.Label();
            this.labelCornerHeight1 = new System.Windows.Forms.Label();
            this.labelCorner1 = new System.Windows.Forms.Label();
            this.labelCorner2 = new System.Windows.Forms.Label();
            this.labelCorner3 = new System.Windows.Forms.Label();
            this.labelCorner4 = new System.Windows.Forms.Label();
            this.additionalSettings = new System.Windows.Forms.Button();
            this.pictureResolution = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxRoughness = new System.Windows.Forms.GroupBox();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.groupBoxCornerHeights = new System.Windows.Forms.GroupBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP4)).BeginInit();
            this.groupBoxRoughness.SuspendLayout();
            this.groupBoxResolution.SuspendLayout();
            this.groupBoxCornerHeights.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Enabled = false;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(513, 513);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.Picture_Click);
            this.picture.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Picture_HelpRequested);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(657, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            this.start.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Start_HelpRequested);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(657, 47);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            this.save.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Save_HelpRequested);
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.Location = new System.Drawing.Point(657, 82);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Очистка";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            this.clear.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Clear_HelpRequested);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(657, 502);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Exit_HelpRequested);
            // 
            // rBar
            // 
            this.rBar.Location = new System.Drawing.Point(9, 30);
            this.rBar.Maximum = 100;
            this.rBar.Name = "rBar";
            this.rBar.Size = new System.Drawing.Size(121, 45);
            this.rBar.TabIndex = 5;
            this.rBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rBar.Value = 100;
            this.rBar.Scroll += new System.EventHandler(this.Rbar_Scroll);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(6, 47);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(38, 13);
            this.labelR.TabIndex = 6;
            this.labelR.Text = "R = 1";
            // 
            // labelRoughness
            // 
            this.labelRoughness.AutoSize = true;
            this.labelRoughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoughness.Location = new System.Drawing.Point(6, 16);
            this.labelRoughness.Name = "labelRoughness";
            this.labelRoughness.Size = new System.Drawing.Size(98, 13);
            this.labelRoughness.TabIndex = 7;
            this.labelRoughness.Text = "Шероховатость";
            // 
            // trackBarP1
            // 
            this.trackBarP1.LargeChange = 100;
            this.trackBarP1.Location = new System.Drawing.Point(9, 31);
            this.trackBarP1.Name = "trackBarP1";
            this.trackBarP1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP1.Size = new System.Drawing.Size(45, 147);
            this.trackBarP1.TabIndex = 6;
            this.trackBarP1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarP1.Scroll += new System.EventHandler(this.Scroller);
            // 
            // labelHeight1
            // 
            this.labelHeight1.AutoSize = true;
            this.labelHeight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight1.Location = new System.Drawing.Point(2, 176);
            this.labelHeight1.Name = "labelHeight1";
            this.labelHeight1.Size = new System.Drawing.Size(14, 13);
            this.labelHeight1.TabIndex = 9;
            this.labelHeight1.Text = "0";
            // 
            // labelHeight2
            // 
            this.labelHeight2.AutoSize = true;
            this.labelHeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight2.Location = new System.Drawing.Point(48, 176);
            this.labelHeight2.Name = "labelHeight2";
            this.labelHeight2.Size = new System.Drawing.Size(14, 13);
            this.labelHeight2.TabIndex = 11;
            this.labelHeight2.Text = "0";
            // 
            // trackBarP2
            // 
            this.trackBarP2.LargeChange = 100;
            this.trackBarP2.Location = new System.Drawing.Point(55, 31);
            this.trackBarP2.Name = "trackBarP2";
            this.trackBarP2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP2.Size = new System.Drawing.Size(45, 147);
            this.trackBarP2.TabIndex = 7;
            this.trackBarP2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarP2.Scroll += new System.EventHandler(this.Scroller);
            // 
            // labelHeight3
            // 
            this.labelHeight3.AutoSize = true;
            this.labelHeight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight3.Location = new System.Drawing.Point(94, 176);
            this.labelHeight3.Name = "labelHeight3";
            this.labelHeight3.Size = new System.Drawing.Size(14, 13);
            this.labelHeight3.TabIndex = 13;
            this.labelHeight3.Text = "0";
            // 
            // trackBarP3
            // 
            this.trackBarP3.LargeChange = 100;
            this.trackBarP3.Location = new System.Drawing.Point(101, 31);
            this.trackBarP3.Name = "trackBarP3";
            this.trackBarP3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP3.Size = new System.Drawing.Size(45, 147);
            this.trackBarP3.TabIndex = 8;
            this.trackBarP3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarP3.Scroll += new System.EventHandler(this.Scroller);
            // 
            // labelHeight4
            // 
            this.labelHeight4.AutoSize = true;
            this.labelHeight4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight4.Location = new System.Drawing.Point(140, 176);
            this.labelHeight4.Name = "labelHeight4";
            this.labelHeight4.Size = new System.Drawing.Size(14, 13);
            this.labelHeight4.TabIndex = 15;
            this.labelHeight4.Text = "0";
            // 
            // trackBarP4
            // 
            this.trackBarP4.LargeChange = 100;
            this.trackBarP4.Location = new System.Drawing.Point(147, 31);
            this.trackBarP4.Name = "trackBarP4";
            this.trackBarP4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP4.Size = new System.Drawing.Size(45, 147);
            this.trackBarP4.TabIndex = 9;
            this.trackBarP4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarP4.Scroll += new System.EventHandler(this.Scroller);
            // 
            // labelCornerHeight2
            // 
            this.labelCornerHeight2.AutoSize = true;
            this.labelCornerHeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCornerHeight2.Location = new System.Drawing.Point(525, 0);
            this.labelCornerHeight2.Name = "labelCornerHeight2";
            this.labelCornerHeight2.Size = new System.Drawing.Size(11, 12);
            this.labelCornerHeight2.TabIndex = 17;
            this.labelCornerHeight2.Text = "2";
            this.labelCornerHeight2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CornerHeights_HelpRequested);
            // 
            // labelCornerHeight3
            // 
            this.labelCornerHeight3.AutoSize = true;
            this.labelCornerHeight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCornerHeight3.Location = new System.Drawing.Point(525, 525);
            this.labelCornerHeight3.Name = "labelCornerHeight3";
            this.labelCornerHeight3.Size = new System.Drawing.Size(11, 12);
            this.labelCornerHeight3.TabIndex = 18;
            this.labelCornerHeight3.Text = "3";
            this.labelCornerHeight3.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CornerHeights_HelpRequested);
            // 
            // labelCornerHeight4
            // 
            this.labelCornerHeight4.AutoSize = true;
            this.labelCornerHeight4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCornerHeight4.Location = new System.Drawing.Point(0, 525);
            this.labelCornerHeight4.Name = "labelCornerHeight4";
            this.labelCornerHeight4.Size = new System.Drawing.Size(11, 12);
            this.labelCornerHeight4.TabIndex = 19;
            this.labelCornerHeight4.Text = "4";
            this.labelCornerHeight4.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CornerHeights_HelpRequested);
            // 
            // labelCornerHeight1
            // 
            this.labelCornerHeight1.AutoSize = true;
            this.labelCornerHeight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCornerHeight1.Location = new System.Drawing.Point(0, 0);
            this.labelCornerHeight1.Name = "labelCornerHeight1";
            this.labelCornerHeight1.Size = new System.Drawing.Size(11, 12);
            this.labelCornerHeight1.TabIndex = 20;
            this.labelCornerHeight1.Text = "1";
            this.labelCornerHeight1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CornerHeights_HelpRequested);
            // 
            // labelCorner1
            // 
            this.labelCorner1.AutoSize = true;
            this.labelCorner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorner1.Location = new System.Drawing.Point(6, 16);
            this.labelCorner1.Name = "labelCorner1";
            this.labelCorner1.Size = new System.Drawing.Size(38, 12);
            this.labelCorner1.TabIndex = 21;
            this.labelCorner1.Text = "Угол 1";
            // 
            // labelCorner2
            // 
            this.labelCorner2.AutoSize = true;
            this.labelCorner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorner2.Location = new System.Drawing.Point(49, 16);
            this.labelCorner2.Name = "labelCorner2";
            this.labelCorner2.Size = new System.Drawing.Size(38, 12);
            this.labelCorner2.TabIndex = 22;
            this.labelCorner2.Text = "Угол 2";
            // 
            // labelCorner3
            // 
            this.labelCorner3.AutoSize = true;
            this.labelCorner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorner3.Location = new System.Drawing.Point(95, 16);
            this.labelCorner3.Name = "labelCorner3";
            this.labelCorner3.Size = new System.Drawing.Size(38, 12);
            this.labelCorner3.TabIndex = 23;
            this.labelCorner3.Text = "Угол 3";
            // 
            // labelCorner4
            // 
            this.labelCorner4.AutoSize = true;
            this.labelCorner4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorner4.Location = new System.Drawing.Point(138, 16);
            this.labelCorner4.Name = "labelCorner4";
            this.labelCorner4.Size = new System.Drawing.Size(38, 12);
            this.labelCorner4.TabIndex = 24;
            this.labelCorner4.Text = "Угол 4";
            // 
            // additionalSettings
            // 
            this.additionalSettings.Location = new System.Drawing.Point(571, 467);
            this.additionalSettings.Name = "additionalSettings";
            this.additionalSettings.Size = new System.Drawing.Size(161, 23);
            this.additionalSettings.TabIndex = 10;
            this.additionalSettings.Text = "Дополнительные настройки";
            this.additionalSettings.UseVisualStyleBackColor = true;
            this.additionalSettings.Click += new System.EventHandler(this.AdditionalSettings_Click);
            this.additionalSettings.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AdditionalSettings_HelpRequested);
            // 
            // pictureResolution
            // 
            this.pictureResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pictureResolution.FormattingEnabled = true;
            this.pictureResolution.Items.AddRange(new object[] {
            "513 x 513",
            "1025 x 1025",
            "2049 x 2049",
            "4097 x 4097",
            "8193 x 8193"});
            this.pictureResolution.Location = new System.Drawing.Point(6, 25);
            this.pictureResolution.Name = "pictureResolution";
            this.pictureResolution.Size = new System.Drawing.Size(121, 21);
            this.pictureResolution.TabIndex = 4;
            this.pictureResolution.SelectedIndexChanged += new System.EventHandler(this.PictureResolution_SelectedIndexChanged);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(3, 9);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(80, 13);
            this.labelResolution.TabIndex = 27;
            this.labelResolution.Text = "Разрешение";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(537, 47);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(109, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // groupBoxRoughness
            // 
            this.groupBoxRoughness.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRoughness.Controls.Add(this.labelRoughness);
            this.groupBoxRoughness.Controls.Add(this.labelR);
            this.groupBoxRoughness.Controls.Add(this.rBar);
            this.groupBoxRoughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRoughness.Location = new System.Drawing.Point(537, 169);
            this.groupBoxRoughness.Name = "groupBoxRoughness";
            this.groupBoxRoughness.Size = new System.Drawing.Size(195, 80);
            this.groupBoxRoughness.TabIndex = 28;
            this.groupBoxRoughness.TabStop = false;
            this.groupBoxRoughness.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Roughness_HelpRequested);
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxResolution.Controls.Add(this.labelResolution);
            this.groupBoxResolution.Controls.Add(this.pictureResolution);
            this.groupBoxResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResolution.Location = new System.Drawing.Point(537, 111);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(195, 52);
            this.groupBoxResolution.TabIndex = 29;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Resolution_HelpRequested);
            // 
            // groupBoxCornerHeights
            // 
            this.groupBoxCornerHeights.Controls.Add(this.labelCorner2);
            this.groupBoxCornerHeights.Controls.Add(this.trackBarP1);
            this.groupBoxCornerHeights.Controls.Add(this.labelHeight1);
            this.groupBoxCornerHeights.Controls.Add(this.trackBarP2);
            this.groupBoxCornerHeights.Controls.Add(this.labelHeight2);
            this.groupBoxCornerHeights.Controls.Add(this.labelCorner4);
            this.groupBoxCornerHeights.Controls.Add(this.trackBarP3);
            this.groupBoxCornerHeights.Controls.Add(this.labelCorner3);
            this.groupBoxCornerHeights.Controls.Add(this.labelHeight3);
            this.groupBoxCornerHeights.Controls.Add(this.trackBarP4);
            this.groupBoxCornerHeights.Controls.Add(this.labelCorner1);
            this.groupBoxCornerHeights.Controls.Add(this.labelHeight4);
            this.groupBoxCornerHeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCornerHeights.Location = new System.Drawing.Point(537, 255);
            this.groupBoxCornerHeights.Name = "groupBoxCornerHeights";
            this.groupBoxCornerHeights.Size = new System.Drawing.Size(195, 200);
            this.groupBoxCornerHeights.TabIndex = 30;
            this.groupBoxCornerHeights.TabStop = false;
            this.groupBoxCornerHeights.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CornerHeights_HelpRequested);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 537);
            this.Controls.Add(this.groupBoxCornerHeights);
            this.Controls.Add(this.groupBoxResolution);
            this.Controls.Add(this.groupBoxRoughness);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.additionalSettings);
            this.Controls.Add(this.labelCornerHeight1);
            this.Controls.Add(this.labelCornerHeight4);
            this.Controls.Add(this.labelCornerHeight3);
            this.Controls.Add(this.labelCornerHeight2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.start);
            this.Controls.Add(this.picture);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 576);
            this.Name = "MainForm";
            this.Text = "Diamond square";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP4)).EndInit();
            this.groupBoxRoughness.ResumeLayout(false);
            this.groupBoxRoughness.PerformLayout();
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            this.groupBoxCornerHeights.ResumeLayout(false);
            this.groupBoxCornerHeights.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar rBar;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelRoughness;
        private System.Windows.Forms.TrackBar trackBarP1;
        private System.Windows.Forms.Label labelHeight1;
        private System.Windows.Forms.Label labelHeight2;
        private System.Windows.Forms.TrackBar trackBarP2;
        private System.Windows.Forms.Label labelHeight3;
        private System.Windows.Forms.TrackBar trackBarP3;
        private System.Windows.Forms.Label labelHeight4;
        private System.Windows.Forms.TrackBar trackBarP4;
        private System.Windows.Forms.Label labelCornerHeight2;
        private System.Windows.Forms.Label labelCornerHeight3;
        private System.Windows.Forms.Label labelCornerHeight4;
        private System.Windows.Forms.Label labelCornerHeight1;
        private System.Windows.Forms.Label labelCorner1;
        private System.Windows.Forms.Label labelCorner2;
        private System.Windows.Forms.Label labelCorner3;
        private System.Windows.Forms.Label labelCorner4;
        private System.Windows.Forms.Button additionalSettings;
        private System.Windows.Forms.ComboBox pictureResolution;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxRoughness;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.GroupBox groupBoxCornerHeights;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}