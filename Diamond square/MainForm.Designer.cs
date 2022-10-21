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
            this.picture = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.rBar = new System.Windows.Forms.TrackBar();
            this.labelR = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.p1Bar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2Bar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.p3Bar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.p4Bar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.pictureResolution = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(513, 513);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(625, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(625, 47);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.Location = new System.Drawing.Point(625, 82);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Очистка";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(625, 502);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // rBar
            // 
            this.rBar.Location = new System.Drawing.Point(539, 198);
            this.rBar.Maximum = 100;
            this.rBar.Name = "rBar";
            this.rBar.Size = new System.Drawing.Size(121, 45);
            this.rBar.TabIndex = 4;
            this.rBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rBar.Value = 100;
            this.rBar.Scroll += new System.EventHandler(this.Rbar_Scroll);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(537, 217);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(38, 13);
            this.labelR.TabIndex = 6;
            this.labelR.Text = "R = 1";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(536, 182);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Шероховатость";
            // 
            // p1Bar
            // 
            this.p1Bar.LargeChange = 100;
            this.p1Bar.Location = new System.Drawing.Point(539, 273);
            this.p1Bar.Name = "p1Bar";
            this.p1Bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p1Bar.Size = new System.Drawing.Size(45, 147);
            this.p1Bar.TabIndex = 10;
            this.p1Bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p1Bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(529, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(575, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // p2Bar
            // 
            this.p2Bar.LargeChange = 100;
            this.p2Bar.Location = new System.Drawing.Point(585, 273);
            this.p2Bar.Name = "p2Bar";
            this.p2Bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p2Bar.Size = new System.Drawing.Size(45, 147);
            this.p2Bar.TabIndex = 10;
            this.p2Bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p2Bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(621, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            // 
            // p3Bar
            // 
            this.p3Bar.LargeChange = 100;
            this.p3Bar.Location = new System.Drawing.Point(631, 273);
            this.p3Bar.Name = "p3Bar";
            this.p3Bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p3Bar.Size = new System.Drawing.Size(45, 147);
            this.p3Bar.TabIndex = 10;
            this.p3Bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p3Bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(667, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "0";
            // 
            // p4Bar
            // 
            this.p4Bar.LargeChange = 100;
            this.p4Bar.Location = new System.Drawing.Point(677, 273);
            this.p4Bar.Name = "p4Bar";
            this.p4Bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p4Bar.Size = new System.Drawing.Size(45, 147);
            this.p4Bar.TabIndex = 10;
            this.p4Bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p4Bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(525, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(525, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(0, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(543, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(590, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(636, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(682, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "4";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(539, 458);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(161, 23);
            this.settings.TabIndex = 25;
            this.settings.Text = "Дополнительные настройки";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // pictureResolution
            // 
            this.pictureResolution.FormattingEnabled = true;
            this.pictureResolution.Items.AddRange(new object[] {
            "513 x 513",
            "1025 x 1025",
            "2049 x 2049",
            "4097 x 4097"});
            this.pictureResolution.Location = new System.Drawing.Point(539, 144);
            this.pictureResolution.Name = "pictureResolution";
            this.pictureResolution.Size = new System.Drawing.Size(121, 21);
            this.pictureResolution.TabIndex = 26;
            this.pictureResolution.SelectedIndexChanged += new System.EventHandler(this.PictureResolution_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(537, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Разрешение";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(531, 47);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(88, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 28;
            this.progressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 537);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureResolution);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p4Bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p3Bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2Bar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1Bar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.rBar);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.start);
            this.Controls.Add(this.picture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 576);
            this.Name = "MainForm";
            this.Text = "Diamond square";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4Bar)).EndInit();
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
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TrackBar p1Bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar p2Bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar p3Bar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar p4Bar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.ComboBox pictureResolution;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}