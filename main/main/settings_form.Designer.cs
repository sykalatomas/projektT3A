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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings_form));
            button1 = new Button();
            hrac1 = new Label();
            hrac2 = new Label();
            hrac1_textbox = new TextBox();
            hrac2_textbox = new TextBox();
            motiv = new Label();
            ulozit_btn = new Button();
            hrac1_radio = new RadioButton();
            hrac2_radio = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
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
            hrac1.BackColor = Color.Transparent;
            hrac1.Font = new Font("Segoe UI", 15F);
            hrac1.ForeColor = Color.White;
            hrac1.Location = new Point(51, 47);
            hrac1.Name = "hrac1";
            hrac1.Size = new Size(198, 28);
            hrac1.TabIndex = 3;
            hrac1.Text = "Jméno prvního hráče:";
            // 
            // hrac2
            // 
            hrac2.AutoSize = true;
            hrac2.BackColor = Color.Transparent;
            hrac2.Font = new Font("Segoe UI", 15F);
            hrac2.ForeColor = Color.White;
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
            hrac1_textbox.TextChanged += hrac1_textbox_TextChanged;
            // 
            // hrac2_textbox
            // 
            hrac2_textbox.Location = new Point(51, 163);
            hrac2_textbox.Name = "hrac2_textbox";
            hrac2_textbox.Size = new Size(198, 23);
            hrac2_textbox.TabIndex = 6;
            hrac2_textbox.Text = "Hráč 2";
            hrac2_textbox.TextChanged += hrac1_textbox_TextChanged;
            // 
            // motiv
            // 
            motiv.AutoSize = true;
            motiv.BackColor = Color.Transparent;
            motiv.Font = new Font("Segoe UI", 15F);
            motiv.ForeColor = Color.White;
            motiv.Location = new Point(416, 47);
            motiv.Name = "motiv";
            motiv.Size = new Size(248, 28);
            motiv.TabIndex = 4;
            motiv.Text = "Nastavení výchozího hráče:";
            motiv.TextAlign = ContentAlignment.TopCenter;
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
            // hrac1_radio
            // 
            hrac1_radio.AutoSize = true;
            hrac1_radio.Location = new Point(22, 22);
            hrac1_radio.Name = "hrac1_radio";
            hrac1_radio.Size = new Size(59, 19);
            hrac1_radio.TabIndex = 9;
            hrac1_radio.Text = "Hráč 1";
            hrac1_radio.UseVisualStyleBackColor = true;
            // 
            // hrac2_radio
            // 
            hrac2_radio.AutoSize = true;
            hrac2_radio.Location = new Point(22, 47);
            hrac2_radio.Name = "hrac2_radio";
            hrac2_radio.Size = new Size(59, 19);
            hrac2_radio.TabIndex = 10;
            hrac2_radio.Text = "Hráč 2";
            hrac2_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(hrac1_radio);
            groupBox1.Controls.Add(hrac2_radio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(416, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 89);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Který hráč bude začínat?";
            // 
            // settings_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minimalist_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(motiv);
            Controls.Add(ulozit_btn);
            Controls.Add(hrac2_textbox);
            Controls.Add(hrac1_textbox);
            Controls.Add(hrac2);
            Controls.Add(hrac1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "settings_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastavení hry";
            Load += settings_form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button ulozit_btn;
        private RadioButton hrac1_radio;
        private RadioButton hrac2_radio;
        private GroupBox groupBox1;
    }
}