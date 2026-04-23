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
            start_btn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // about_me
            // 
            about_me.AutoSize = true;
            about_me.BackColor = Color.Transparent;
            about_me.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            about_me.ForeColor = Color.White;
            about_me.Location = new Point(8, 9);
            about_me.Margin = new Padding(2, 0, 2, 0);
            about_me.Name = "about_me";
            about_me.RightToLeft = RightToLeft.No;
            about_me.Size = new Size(545, 225);
            about_me.TabIndex = 0;
            about_me.Text = resources.GetString("about_me.Text");
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(8, 367);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(76, 37);
            button1.TabIndex = 1;
            button1.Text = "ZPĚT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // start_btn
            // 
            start_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            start_btn.ForeColor = Color.FromArgb(0, 0, 64);
            start_btn.Location = new Point(415, 362);
            start_btn.Margin = new Padding(2);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(136, 42);
            start_btn.TabIndex = 5;
            start_btn.Text = "GitHub";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 0, 64);
            button2.Location = new Point(573, 362);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(156, 42);
            button2.TabIndex = 5;
            button2.Text = "Další tvorba";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // about_form
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.minimalist_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(741, 415);
            Controls.Add(button2);
            Controls.Add(start_btn);
            Controls.Add(button1);
            Controls.Add(about_me);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "about_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O projektu..";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label about_me;
        private Button button1;
        private Button start_btn;
        private Button button2;
    }
}