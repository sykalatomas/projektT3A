namespace main
{
    partial class QuestionForm
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
            otazka = new Label();
            odpoved = new TextBox();
            odeslat = new Button();
            SuspendLayout();
            // 
            // otazka
            // 
            otazka.BackColor = Color.Transparent;
            otazka.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            otazka.ForeColor = Color.White;
            otazka.Location = new Point(32, 47);
            otazka.Name = "otazka";
            otazka.Size = new Size(651, 168);
            otazka.TabIndex = 0;
            otazka.Text = "label1";
            otazka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // odpoved
            // 
            odpoved.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            odpoved.Location = new Point(22, 322);
            odpoved.Multiline = true;
            odpoved.Name = "odpoved";
            odpoved.Size = new Size(523, 38);
            odpoved.TabIndex = 1;
            // 
            // odeslat
            // 
            odeslat.BackColor = Color.Lime;
            odeslat.FlatStyle = FlatStyle.Flat;
            odeslat.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            odeslat.ForeColor = Color.Black;
            odeslat.Location = new Point(551, 322);
            odeslat.Name = "odeslat";
            odeslat.Size = new Size(132, 38);
            odeslat.TabIndex = 2;
            odeslat.Text = "ODPOVĚDĚT";
            odeslat.UseVisualStyleBackColor = false;
            odeslat.Click += odeslat_Click;
            // 
            // QuestionForm
            // 
            AcceptButton = odeslat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(710, 384);
            Controls.Add(odeslat);
            Controls.Add(odpoved);
            Controls.Add(otazka);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QuestionForm";
            Load += QuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label otazka;
        private TextBox odpoved;
        private Button odeslat;
    }
}