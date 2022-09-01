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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LabelNumSq = new System.Windows.Forms.Label();
            this.Rbar = new System.Windows.Forms.TrackBar();
            this.LabelR = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.P1bar = new System.Windows.Forms.TrackBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.P2bar = new System.Windows.Forms.TrackBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.P3bar = new System.Windows.Forms.TrackBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.P4bar = new System.Windows.Forms.TrackBar();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(513, 513);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(625, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(625, 47);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(625, 82);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Очистка";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(625, 502);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabelNumSq
            // 
            this.LabelNumSq.AutoSize = true;
            this.LabelNumSq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumSq.Location = new System.Drawing.Point(536, 130);
            this.LabelNumSq.Name = "LabelNumSq";
            this.LabelNumSq.Size = new System.Drawing.Size(128, 13);
            this.LabelNumSq.TabIndex = 5;
            this.LabelNumSq.Text = "Кол-во квадратов: 1";
            // 
            // Rbar
            // 
            this.Rbar.Location = new System.Drawing.Point(536, 198);
            this.Rbar.Maximum = 100;
            this.Rbar.Name = "Rbar";
            this.Rbar.Size = new System.Drawing.Size(125, 45);
            this.Rbar.TabIndex = 4;
            this.Rbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Rbar.Value = 100;
            this.Rbar.Scroll += new System.EventHandler(this.Rbar_Scroll);
            // 
            // LabelR
            // 
            this.LabelR.AutoSize = true;
            this.LabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelR.Location = new System.Drawing.Point(547, 221);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(38, 13);
            this.LabelR.TabIndex = 6;
            this.LabelR.Text = "R = 1";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(536, 182);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(98, 13);
            this.Label.TabIndex = 7;
            this.Label.Text = "Шероховатость";
            // 
            // P1bar
            // 
            this.P1bar.LargeChange = 10;
            this.P1bar.Location = new System.Drawing.Point(538, 273);
            this.P1bar.Maximum = 600;
            this.P1bar.Minimum = -200;
            this.P1bar.Name = "P1bar";
            this.P1bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.P1bar.Size = new System.Drawing.Size(45, 147);
            this.P1bar.TabIndex = 8;
            this.P1bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.P1bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(533, 418);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(14, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(572, 418);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(14, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "0";
            // 
            // P2bar
            // 
            this.P2bar.LargeChange = 10;
            this.P2bar.Location = new System.Drawing.Point(577, 273);
            this.P2bar.Maximum = 600;
            this.P2bar.Minimum = -200;
            this.P2bar.Name = "P2bar";
            this.P2bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.P2bar.Size = new System.Drawing.Size(45, 147);
            this.P2bar.TabIndex = 10;
            this.P2bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.P2bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(611, 418);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(14, 13);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "0";
            // 
            // P3bar
            // 
            this.P3bar.LargeChange = 10;
            this.P3bar.Location = new System.Drawing.Point(616, 273);
            this.P3bar.Maximum = 600;
            this.P3bar.Minimum = -200;
            this.P3bar.Name = "P3bar";
            this.P3bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.P3bar.Size = new System.Drawing.Size(45, 147);
            this.P3bar.TabIndex = 12;
            this.P3bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.P3bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(650, 418);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(14, 13);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "0";
            // 
            // P4bar
            // 
            this.P4bar.LargeChange = 10;
            this.P4bar.Location = new System.Drawing.Point(655, 273);
            this.P4bar.Maximum = 600;
            this.P4bar.Minimum = -200;
            this.P4bar.Name = "P4bar";
            this.P4bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.P4bar.Size = new System.Drawing.Size(45, 147);
            this.P4bar.TabIndex = 14;
            this.P4bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.P4bar.Scroll += new System.EventHandler(this.Scroller);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label6.Location = new System.Drawing.Point(525, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(11, 12);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "2";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label7.Location = new System.Drawing.Point(525, 525);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(11, 12);
            this.Label7.TabIndex = 18;
            this.Label7.Text = "3";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label8.Location = new System.Drawing.Point(0, 525);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(11, 12);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "4";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.Location = new System.Drawing.Point(0, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(11, 12);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "1";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label9.Location = new System.Drawing.Point(543, 264);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(11, 12);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "1";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label10.Location = new System.Drawing.Point(582, 264);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(11, 12);
            this.Label10.TabIndex = 22;
            this.Label10.Text = "2";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label11.Location = new System.Drawing.Point(621, 264);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(11, 12);
            this.Label11.TabIndex = 23;
            this.Label11.Text = "3";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label12.Location = new System.Drawing.Point(660, 264);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(11, 12);
            this.Label12.TabIndex = 24;
            this.Label12.Text = "4";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 537);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.P4bar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.P3bar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.P2bar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.P1bar);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LabelR);
            this.Controls.Add(this.Rbar);
            this.Controls.Add(this.LabelNumSq);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Picture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 576);
            this.Name = "Form";
            this.Text = "Diamond square";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label LabelNumSq;
        private System.Windows.Forms.TrackBar Rbar;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TrackBar P1bar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TrackBar P2bar;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TrackBar P3bar;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TrackBar P4bar;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
    }
}

