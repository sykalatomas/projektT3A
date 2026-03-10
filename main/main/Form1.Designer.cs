namespace main
{
    partial class Form1
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
            odejit_btn = new Button();
            start_btn = new Button();
            set_btn = new Button();
            about_btn = new Button();
            SuspendLayout();
            // 
            // odejit_btn
            // 
            odejit_btn.BackColor = Color.Firebrick;
            odejit_btn.FlatStyle = FlatStyle.Flat;
            odejit_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            odejit_btn.ForeColor = SystemColors.Control;
            odejit_btn.Location = new Point(12, 590);
            odejit_btn.Name = "odejit_btn";
            odejit_btn.Size = new Size(95, 42);
            odejit_btn.TabIndex = 0;
            odejit_btn.Text = "ODEJÍT";
            odejit_btn.UseVisualStyleBackColor = false;
            odejit_btn.Click += odejit_btn_Click;
            // 
            // start_btn
            // 
            start_btn.Location = new Point(133, 116);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(441, 85);
            start_btn.TabIndex = 1;
            start_btn.Text = "ZAČÍT HRÁT";
            start_btn.UseVisualStyleBackColor = true;
            // 
            // set_btn
            // 
            set_btn.Location = new Point(133, 217);
            set_btn.Name = "set_btn";
            set_btn.Size = new Size(441, 85);
            set_btn.TabIndex = 1;
            set_btn.Text = "NASTAVENÍ HRY";
            set_btn.UseVisualStyleBackColor = true;
            // 
            // about_btn
            // 
            about_btn.Location = new Point(133, 322);
            about_btn.Name = "about_btn";
            about_btn.Size = new Size(441, 85);
            about_btn.TabIndex = 1;
            about_btn.Text = "O AUTOROVI";
            about_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Poster__Facebook1200x675;
            ClientSize = new Size(1200, 644);
            Controls.Add(about_btn);
            Controls.Add(set_btn);
            Controls.Add(start_btn);
            Controls.Add(odejit_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button odejit_btn;
        private Button start_btn;
        private Button set_btn;
        private Button about_btn;
    }
}
