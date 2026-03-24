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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 206);
            label1.Name = "label1";
            label1.Size = new Size(616, 15);
            label1.TabIndex = 0;
            label1.Text = "Jsem studentem 3. ročníku maturitního oboru IT na FrenGP. Je mi 18 let a pocházím z nedalekého města Kopřivnice.";
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
            // about_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "about_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O autorovi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}