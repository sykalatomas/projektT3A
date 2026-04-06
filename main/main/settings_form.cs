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
        public settings_form()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
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
                HraData.JmenoHrac1 = hrac1_textbox.Text;
                HraData.JmenoHrac2 = hrac2_textbox.Text;
                if (hrac1_radio.Checked)
                {
                    HraData.PrvniTahHrace = 1;
                }
                MessageBox.Show("Změny byly uloženy!", "Upozornění!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void settings_form_Load(object sender, EventArgs e)
        {
            hrac1_textbox.Text = HraData.JmenoHrac1;
            hrac2_textbox.Text = HraData.JmenoHrac2;
        }
    }
}
