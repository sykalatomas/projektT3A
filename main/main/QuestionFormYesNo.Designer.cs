namespace main
{
    partial class QuestionFormYesNo
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
            ano = new Button();
            ne = new Button();
            SuspendLayout();
            // 
            // otazka
            // 
            otazka.BackColor = Color.Transparent;
            otazka.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            otazka.ForeColor = Color.White;
            otazka.Location = new Point(21, 24);
            otazka.Name = "otazka";
            otazka.Size = new Size(651, 168);
            otazka.TabIndex = 1;
            otazka.Text = "label1";
            otazka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ano
            // 
            ano.BackColor = Color.Lime;
            ano.FlatStyle = FlatStyle.Flat;
            ano.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ano.ForeColor = Color.Black;
            ano.Location = new Point(21, 305);
            ano.Name = "ano";
            ano.Size = new Size(314, 38);
            ano.TabIndex = 3;
            ano.Text = "ANO";
            ano.UseVisualStyleBackColor = false;
            ano.Click += ano_Click;
            // 
            // ne
            // 
            ne.BackColor = Color.OrangeRed;
            ne.FlatStyle = FlatStyle.Flat;
            ne.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ne.ForeColor = Color.Black;
            ne.Location = new Point(371, 305);
            ne.Name = "ne";
            ne.Size = new Size(313, 38);
            ne.TabIndex = 4;
            ne.Text = "NE";
            ne.UseVisualStyleBackColor = false;
            ne.Click += ne_Click;
            // 
            // QuestionFormYesNo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(710, 384);
            Controls.Add(ne);
            Controls.Add(ano);
            Controls.Add(otazka);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionFormYesNo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QuestionFormYesNo";
            ResumeLayout(false);
        }

        #endregion

        private Label otazka;
        private Button ano;
        private Button ne;
    }
}