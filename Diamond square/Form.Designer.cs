namespace Diamond_square
{
    partial class Form
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
            this.p1bar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2bar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.p3bar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.p4bar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4bar)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(513, 513);
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
            this.rBar.Location = new System.Drawing.Point(536, 198);
            this.rBar.Maximum = 100;
            this.rBar.Name = "rBar";
            this.rBar.Size = new System.Drawing.Size(125, 45);
            this.rBar.TabIndex = 4;
            this.rBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rBar.Value = 100;
            this.rBar.Scroll += new System.EventHandler(this.Rbar_Scroll);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(547, 221);
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
            // p1bar
            // 
            this.p1bar.LargeChange = 100;
            this.p1bar.Location = new System.Drawing.Point(539, 273);
            this.p1bar.Maximum = 8848;
            this.p1bar.Minimum = -11034;
            this.p1bar.Name = "p1bar";
            this.p1bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p1bar.Size = new System.Drawing.Size(45, 147);
            this.p1bar.TabIndex = 8;
            this.p1bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p1bar.Scroll += new System.EventHandler(this.Scroller);
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
            // p2bar
            // 
            this.p2bar.LargeChange = 100;
            this.p2bar.Location = new System.Drawing.Point(585, 273);
            this.p2bar.Maximum = 8848;
            this.p2bar.Minimum = -11034;
            this.p2bar.Name = "p2bar";
            this.p2bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p2bar.Size = new System.Drawing.Size(45, 147);
            this.p2bar.TabIndex = 10;
            this.p2bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p2bar.Scroll += new System.EventHandler(this.Scroller);
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
            // p3bar
            // 
            this.p3bar.LargeChange = 100;
            this.p3bar.Location = new System.Drawing.Point(631, 273);
            this.p3bar.Maximum = 8848;
            this.p3bar.Minimum = -11034;
            this.p3bar.Name = "p3bar";
            this.p3bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p3bar.Size = new System.Drawing.Size(45, 147);
            this.p3bar.TabIndex = 12;
            this.p3bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p3bar.Scroll += new System.EventHandler(this.Scroller);
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
            // p4bar
            // 
            this.p4bar.LargeChange = 100;
            this.p4bar.Location = new System.Drawing.Point(677, 273);
            this.p4bar.Maximum = 8848;
            this.p4bar.Minimum = -11034;
            this.p4bar.Name = "p4bar";
            this.p4bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.p4bar.Size = new System.Drawing.Size(45, 147);
            this.p4bar.TabIndex = 14;
            this.p4bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.p4bar.Scroll += new System.EventHandler(this.Scroller);
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 537);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p4bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p3bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2bar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1bar);
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
            this.Name = "Form";
            this.Text = "Diamond square";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4bar)).EndInit();
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
        private System.Windows.Forms.TrackBar p1bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar p2bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar p3bar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar p4bar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

