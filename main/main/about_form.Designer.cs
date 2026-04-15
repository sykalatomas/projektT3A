namespace main
{
    partial class about_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_form));
            about_me = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            start_btn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // about_me
            // 
            about_me.AutoSize = true;
            about_me.BackColor = Color.Transparent;
            about_me.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            about_me.ForeColor = Color.White;
            about_me.Location = new Point(12, 9);
            about_me.Name = "about_me";
            about_me.RightToLeft = RightToLeft.No;
            about_me.Size = new Size(721, 200);
            about_me.TabIndex = 0;
            about_me.Text = resources.GetString("about_me.Text");
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 396);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 1;
            button1.Text = "ZPĚT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.about_me1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(484, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 192);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // start_btn
            // 
            start_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            start_btn.ForeColor = Color.FromArgb(0, 0, 64);
            start_btn.Location = new Point(21, 220);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(125, 39);
            start_btn.TabIndex = 5;
            start_btn.Text = "GitHub";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 0, 64);
            button2.Location = new Point(186, 220);
            button2.Name = "button2";
            button2.Size = new Size(154, 39);
            button2.TabIndex = 5;
            button2.Text = "Další tvorba";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // about_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.minimalist_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(start_btn);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(about_me);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "about_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O projektu..";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label about_me;
        private Button button1;
        private PictureBox pictureBox1;
        private Button start_btn;
        private Button button2;
    }
}