namespace main
{
    partial class settings_form
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
            button1 = new Button();
            hrac1 = new Label();
            hrac2 = new Label();
            hrac1_textbox = new TextBox();
            hrac2_textbox = new TextBox();
            motiv = new Label();
            dark_radiobtn = new RadioButton();
            light_radiobtn = new RadioButton();
            ulozit_btn = new Button();
            SuspendLayout();
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
            button1.TabIndex = 2;
            button1.Text = "ZPĚT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // hrac1
            // 
            hrac1.AutoSize = true;
            hrac1.Font = new Font("Segoe UI", 15F);
            hrac1.Location = new Point(51, 47);
            hrac1.Name = "hrac1";
            hrac1.Size = new Size(198, 28);
            hrac1.TabIndex = 3;
            hrac1.Text = "Jméno prvního hráče:";
            // 
            // hrac2
            // 
            hrac2.AutoSize = true;
            hrac2.Font = new Font("Segoe UI", 15F);
            hrac2.Location = new Point(51, 132);
            hrac2.Name = "hrac2";
            hrac2.Size = new Size(204, 28);
            hrac2.TabIndex = 4;
            hrac2.Text = "Jméno druhého hráče:";
            // 
            // hrac1_textbox
            // 
            hrac1_textbox.Location = new Point(51, 78);
            hrac1_textbox.Name = "hrac1_textbox";
            hrac1_textbox.Size = new Size(198, 23);
            hrac1_textbox.TabIndex = 5;
            hrac1_textbox.Text = "Hráč 1";
            // 
            // hrac2_textbox
            // 
            hrac2_textbox.Location = new Point(51, 163);
            hrac2_textbox.Name = "hrac2_textbox";
            hrac2_textbox.Size = new Size(198, 23);
            hrac2_textbox.TabIndex = 6;
            hrac2_textbox.Text = "Hráč 2";
            // 
            // motiv
            // 
            motiv.AutoSize = true;
            motiv.Font = new Font("Segoe UI", 15F);
            motiv.Location = new Point(384, 47);
            motiv.Name = "motiv";
            motiv.Size = new Size(242, 28);
            motiv.TabIndex = 4;
            motiv.Text = "Nastavení režimu aplikace:";
            // 
            // dark_radiobtn
            // 
            dark_radiobtn.AutoSize = true;
            dark_radiobtn.Location = new Point(384, 82);
            dark_radiobtn.Name = "dark_radiobtn";
            dark_radiobtn.Size = new Size(92, 19);
            dark_radiobtn.TabIndex = 7;
            dark_radiobtn.Text = "Tmavý režim";
            dark_radiobtn.UseVisualStyleBackColor = true;
            // 
            // light_radiobtn
            // 
            light_radiobtn.AutoSize = true;
            light_radiobtn.Checked = true;
            light_radiobtn.Location = new Point(502, 82);
            light_radiobtn.Name = "light_radiobtn";
            light_radiobtn.Size = new Size(88, 19);
            light_radiobtn.TabIndex = 7;
            light_radiobtn.TabStop = true;
            light_radiobtn.Text = "Světlý režim";
            light_radiobtn.UseVisualStyleBackColor = true;
            // 
            // ulozit_btn
            // 
            ulozit_btn.BackColor = Color.ForestGreen;
            ulozit_btn.FlatStyle = FlatStyle.Flat;
            ulozit_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ulozit_btn.ForeColor = SystemColors.Control;
            ulozit_btn.Location = new Point(679, 396);
            ulozit_btn.Name = "ulozit_btn";
            ulozit_btn.Size = new Size(109, 42);
            ulozit_btn.TabIndex = 8;
            ulozit_btn.Text = "ULOŽIT";
            ulozit_btn.UseVisualStyleBackColor = false;
            ulozit_btn.Click += ulozit_btn_Click;
            // 
            // settings_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ulozit_btn);
            Controls.Add(light_radiobtn);
            Controls.Add(dark_radiobtn);
            Controls.Add(hrac2_textbox);
            Controls.Add(hrac1_textbox);
            Controls.Add(motiv);
            Controls.Add(hrac2);
            Controls.Add(hrac1);
            Controls.Add(button1);
            Name = "settings_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastavení hry";
            Load += settings_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label hrac1;
        private Label hrac2;
        private TextBox hrac1_textbox;
        private TextBox hrac2_textbox;
        private Label motiv;
        private RadioButton dark_radiobtn;
        private RadioButton light_radiobtn;
        private Button ulozit_btn;
    }
}