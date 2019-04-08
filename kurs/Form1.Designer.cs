namespace kurs
{
    partial class Form1
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenFile_dialog = new System.Windows.Forms.OpenFileDialog();
            this.BandWButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Neg_Button = new System.Windows.Forms.Button();
            this.Chanel_button = new System.Windows.Forms.Button();
            this.cahnels_bar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Sepia_button = new System.Windows.Forms.Button();
            this.Brightness_bar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RandNoiseBar = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cahnels_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandNoiseBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(356, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(708, 658);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(29, 50);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(86, 43);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open File";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(195, 50);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(86, 43);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // OpenFile_dialog
            // 
            this.OpenFile_dialog.FileName = "OpenFile_dialog";
            this.OpenFile_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk_1);
            // 
            // BandWButton
            // 
            this.BandWButton.Location = new System.Drawing.Point(29, 197);
            this.BandWButton.Name = "BandWButton";
            this.BandWButton.Size = new System.Drawing.Size(86, 43);
            this.BandWButton.TabIndex = 3;
            this.BandWButton.Text = "Grayscale";
            this.BandWButton.UseVisualStyleBackColor = true;
            this.BandWButton.Click += new System.EventHandler(this.GreyscaleButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "BandW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Neg_Button
            // 
            this.Neg_Button.Location = new System.Drawing.Point(29, 246);
            this.Neg_Button.Name = "Neg_Button";
            this.Neg_Button.Size = new System.Drawing.Size(86, 43);
            this.Neg_Button.TabIndex = 5;
            this.Neg_Button.Text = "Negativ";
            this.Neg_Button.UseVisualStyleBackColor = true;
            this.Neg_Button.Click += new System.EventHandler(this.Negat_button_Click_1);
            // 
            // Chanel_button
            // 
            this.Chanel_button.Location = new System.Drawing.Point(29, 295);
            this.Chanel_button.Name = "Chanel_button";
            this.Chanel_button.Size = new System.Drawing.Size(86, 43);
            this.Chanel_button.TabIndex = 6;
            this.Chanel_button.Text = "Chanel";
            this.Chanel_button.UseVisualStyleBackColor = true;
            this.Chanel_button.Click += new System.EventHandler(this.Chanel_button_Click);
            // 
            // cahnels_bar
            // 
            this.cahnels_bar.Location = new System.Drawing.Point(195, 282);
            this.cahnels_bar.Maximum = 2;
            this.cahnels_bar.Name = "cahnels_bar";
            this.cahnels_bar.Size = new System.Drawing.Size(104, 56);
            this.cahnels_bar.TabIndex = 8;
            this.cahnels_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "R      G      B";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sepia_button
            // 
            this.Sepia_button.Location = new System.Drawing.Point(29, 344);
            this.Sepia_button.Name = "Sepia_button";
            this.Sepia_button.Size = new System.Drawing.Size(86, 43);
            this.Sepia_button.TabIndex = 10;
            this.Sepia_button.Text = "Sepia";
            this.Sepia_button.UseVisualStyleBackColor = true;
            this.Sepia_button.Click += new System.EventHandler(this.Sepia_button_Click);
            // 
            // Brightness_bar
            // 
            this.Brightness_bar.Location = new System.Drawing.Point(29, 419);
            this.Brightness_bar.Minimum = -10;
            this.Brightness_bar.Name = "Brightness_bar";
            this.Brightness_bar.Size = new System.Drawing.Size(270, 56);
            this.Brightness_bar.TabIndex = 11;
            this.Brightness_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Brightness_bar_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brightness";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Digital Noise";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RandNoiseBar
            // 
            this.RandNoiseBar.Location = new System.Drawing.Point(29, 481);
            this.RandNoiseBar.Maximum = 20;
            this.RandNoiseBar.Name = "RandNoiseBar";
            this.RandNoiseBar.Size = new System.Drawing.Size(270, 56);
            this.RandNoiseBar.TabIndex = 13;
            this.RandNoiseBar.Scroll += new System.EventHandler(this.trackBar1_Scroll_2);
            this.RandNoiseBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RandNoiseBar_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 543);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(270, 56);
            this.trackBar1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 687);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RandNoiseBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Brightness_bar);
            this.Controls.Add(this.Sepia_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cahnels_bar);
            this.Controls.Add(this.Chanel_button);
            this.Controls.Add(this.Neg_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BandWButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cahnels_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandNoiseBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog OpenFile_dialog;
        private System.Windows.Forms.Button BandWButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Neg_Button;
        private System.Windows.Forms.Button Chanel_button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar cahnels_bar;
        private System.Windows.Forms.Button Sepia_button;
        public System.Windows.Forms.TrackBar Brightness_bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TrackBar RandNoiseBar;
        public System.Windows.Forms.TrackBar trackBar1;
    }
}

