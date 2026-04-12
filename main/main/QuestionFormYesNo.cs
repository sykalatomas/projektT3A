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
    public partial class QuestionFormYesNo : Form
    {
        private string spravnaOdpoved;
        public bool jeSpravne { get; private set; }

        public QuestionFormYesNo(string textNahradniOtazky, string odpoved)
        {
            InitializeComponent();
            otazka.Text = textNahradniOtazky;
            spravnaOdpoved = odpoved;
            jeSpravne = false;
        }

        private void ano_Click(object sender, EventArgs e)
        {
            if (spravnaOdpoved.ToLower() == "ano")
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

        private void ne_Click(object sender, EventArgs e)
        {
            if (spravnaOdpoved.ToLower() == "ne")
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
