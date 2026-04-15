namespace main
{
    partial class menu_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_form));
            start_btn = new Button();
            set_btn = new Button();
            about_btn = new Button();
            odejit_btn = new Button();
            SuspendLayout();
            // 
            // start_btn
            // 
            start_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            start_btn.ForeColor = Color.FromArgb(0, 0, 64);
            start_btn.Location = new Point(133, 116);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(441, 85);
            start_btn.TabIndex = 1;
            start_btn.Text = "ZAČÍT HRÁT";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // set_btn
            // 
            set_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            set_btn.ForeColor = Color.FromArgb(0, 0, 64);
            set_btn.Location = new Point(133, 217);
            set_btn.Name = "set_btn";
            set_btn.Size = new Size(441, 85);
            set_btn.TabIndex = 1;
            set_btn.Text = "NASTAVENÍ HRY";
            set_btn.UseVisualStyleBackColor = true;
            set_btn.Click += set_btn_Click;
            // 
            // about_btn
            // 
            about_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            about_btn.ForeColor = Color.FromArgb(0, 0, 64);
            about_btn.Location = new Point(133, 322);
            about_btn.Name = "about_btn";
            about_btn.Size = new Size(441, 85);
            about_btn.TabIndex = 1;
            about_btn.Text = "O PROJEKTU";
            about_btn.UseVisualStyleBackColor = true;
            about_btn.Click += about_btn_Click;
            // 
            // odejit_btn
            // 
            odejit_btn.BackColor = Color.Firebrick;
            odejit_btn.FlatStyle = FlatStyle.Flat;
            odejit_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            odejit_btn.ForeColor = SystemColors.Control;
            odejit_btn.Location = new Point(12, 589);
            odejit_btn.Name = "odejit_btn";
            odejit_btn.Size = new Size(95, 42);
            odejit_btn.TabIndex = 0;
            odejit_btn.Text = "ODEJÍT";
            odejit_btn.UseVisualStyleBackColor = false;
            odejit_btn.Click += odejit_btn_Click;
            // 
            // menu_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Poster__Facebook1200x675;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1132, 643);
            Controls.Add(about_btn);
            Controls.Add(set_btn);
            Controls.Add(start_btn);
            Controls.Add(odejit_btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "menu_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vítejte ve vědomostní hře - AZ kvíz!";
            ResumeLayout(false);
        }

        #endregion
        private Button start_btn;
        private Button set_btn;
        private Button about_btn;
        private Button odejit_btn;
    }
}
