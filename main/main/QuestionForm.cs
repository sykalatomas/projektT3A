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
    public partial class QuestionForm : Form
    {
        private string spravnaOdpoved;
        public bool jeSpravne { get; private set; }

        public QuestionForm(string textOtazky, string odpoved)
        {
            InitializeComponent();
            otazka.Text = textOtazky;
            spravnaOdpoved = odpoved;
            jeSpravne = false;
        }


        private void QuestionForm_Load(object sender, EventArgs e)
        {
            odpoved.Focus();
        }

        private void odeslat_Click(object sender, EventArgs e)
        {
            if (odpoved.Text.Trim().ToLower() == spravnaOdpoved.ToLower())
            {
                jeSpravne = true;
                MessageBox.Show("Správně!", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                jeSpravne = false;
                MessageBox.Show("Špatně! Správná odpověď je: " + spravnaOdpoved, "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
