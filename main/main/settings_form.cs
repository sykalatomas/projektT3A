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
    public partial class settings_form : Form
    {
        private bool zmenyNebylyUlozeny = false;
        public settings_form()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hrac1_textbox.Text == "" || hrac2_textbox.Text == "")
            {
                MessageBox.Show("Nezadali jste jméno jednoho z hráčů!", "Upozornění!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (hrac1_textbox.Text == hrac2_textbox.Text)
            {
                MessageBox.Show("Zadejte různá jména pro oba hráče!", "Upozornění!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (zmenyNebylyUlozeny == true)
            {
                DialogResult result;
                result = MessageBox.Show("Neuložili jste provedené změny! Přejete si pokračovat?", "Pozor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            menu_form menu = new menu_form();
            menu.Show();
            this.Close();
        }

        private void ulozit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Přejete si uložit nastávající změny?", "Upozornění!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                zmenyNebylyUlozeny = false;
                HraData.JmenoHrac1 = hrac1_textbox.Text;
                HraData.JmenoHrac2 = hrac2_textbox.Text;
                if (hrac1_radio.Checked)
                {
                    HraData.hracNaRade = 1;
                }
                else if (hrac2_radio.Checked)
                {
                    HraData.hracNaRade = 2;
                }
                MessageBox.Show("Změny byly úspěšně uloženy!", "Upozornění!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void settings_form_Load(object sender, EventArgs e)
        {
            hrac1_textbox.Text = HraData.JmenoHrac1;
            hrac2_textbox.Text = HraData.JmenoHrac2;
        }

        private void hrac1_textbox_TextChanged(object sender, EventArgs e)
        {
            zmenyNebylyUlozeny = true;
        }
    }
}
