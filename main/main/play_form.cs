using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class play_form : Form
    {
        public play_form()
        {
            InitializeComponent();
            

        }

        // veřejná vlastnost (lze také použít pouze privátní pole)
        public bool IsDarkMode { get; private set; }

        public play_form(bool isDarkMode) : this()
        {
            InitializeComponent();
            IsDarkMode = isDarkMode;
        }

        // Přetížený konstruktor umožní předat vybraný stav z radiobutton


        private void play_form_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (IsDarkMode)
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                this.ForeColor = Color.White;
                ApplyThemeToControls(this.Controls, Color.FromArgb(45, 45, 48), Color.White);
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
                ApplyThemeToControls(this.Controls, SystemColors.Control, SystemColors.ControlText);
            }
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, Color back, Color fore)
        {
            foreach (Control c in controls)
            {
                // některé kontrole (např. Button) mohou používat vlastní FlatStyle barvy — upravte podle potřeby
                c.BackColor = back;
                c.ForeColor = fore;

                // rekurzivně pro child controls
                if (c.HasChildren)
                    ApplyThemeToControls(c.Controls, back, fore);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu_form menu = new menu_form();
            menu.Show();
        }
    }
}
