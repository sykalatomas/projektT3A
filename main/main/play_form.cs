using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace main
{
    public partial class play_form : Form
    {
        public class Otazka
        {
            public string Text { get; set; }
            public string Odpoved { get; set; }

            public Otazka(string text, string odpoved)
            {
                Text = text;
                Odpoved = odpoved;
            }
        }

        List<Otazka> seznamOtazek = new List<Otazka>();

        private void NaplnOtazek()
        {


            string cestaKSouboru = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "otazky.txt");
            try
            {
                string[] radky = File.ReadAllLines(cestaKSouboru);
                foreach (string radek in radky)
                {
                    string[] casti = radek.Split(';');
                    if (casti.Length == 2)
                    {
                        string textOtazky = casti[0];
                        string odpoved = casti[1];
                        seznamOtazek.Add(new Otazka(textOtazky, odpoved));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání otázek: " + ex.Message);
            }

            Random rnd = new Random();
            int n = seznamOtazek.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Otazka value = seznamOtazek[k];
                seznamOtazek[k] = seznamOtazek[n];
                seznamOtazek[n] = value;
            }
        }


        public play_form()
        {
            InitializeComponent();
            NaplnOtazek();


        }

        private void play_form_Load(object sender, EventArgs e)
        {
            hrac1.Text = HraData.JmenoHrac1;
            hrac2.Text = HraData.JmenoHrac2;
            play_form.ActiveForm.Text = "Hra - " + HraData.JmenoHrac1 + " vs " + HraData.JmenoHrac2;
            if (HraData.hracNaRade == 1)
            {
                hrac1_tah.Visible = true;
                hrac1_tah.Text = "Hráč " + HraData.JmenoHrac1 + " je na tahu.";
            }
            else
            {
                hrac2_tah.Visible = true;
                hrac2_tah.Text = "Hráč " + HraData.JmenoHrac2 + " je na tahu.";
            }
            /*
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                // Pokud je ten prvek tlačítko, přiřadíme mu akci
                if (c is Button tlacitko)
                {
                    // Všechna tlačítka teď při kliknutí spustí stejnou metodu
                    tlacitko.Click += pole_1_click;
                }
            }*/
        }

        private void odejit_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Opravdu si přejete ukončit rozehranou hru bez uložení?", "Pozor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                menu_form menu = new menu_form();
                menu.Show();
            }

        }
        
        private void pole_1_Click(object sender, EventArgs e)
        {
            Button pole_1_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_1_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            // Vytvoříme instanci našeho nového okna a předáme mu data
            using (QuestionForm okno = new QuestionForm(vybranaOtazka.Text, vybranaOtazka.Odpoved))
            {
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    if (okno.jeSpravne)
                    {
                        if (HraData.hracNaRade == 1)
                        {
                            pole_1.BackgroundImage = Properties.Resources.sestiuhelnik_aqua;
                        }
                        else
                        {
                            pole_1.BackgroundImage = Properties.Resources.sestiuhelnik_zlata;
                        }
                    }
                    else
                    {
                        pole_1_vybrano.ForeColor = Color.White;
                        pole_1_vybrano.BackgroundImage = Properties.Resources.sestiuhelnik_cerny;
                    }

                    // Přepneme hráče na řadě (pokud je to hra pro dva)
                    HraData.hracNaRade = (HraData.hracNaRade == 1) ? 2 : 1;
                }
            }
        }

        private void pole_2_Click(object sender, EventArgs e)
        {
            Button pole_2_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_2_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_3_Click(object sender, EventArgs e)
        {
            Button pole_3_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_3_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_4_Click(object sender, EventArgs e)
        {
            Button pole_4_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_4_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_5_Click(object sender, EventArgs e)
        {
            Button pole_5_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_5_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_6_Click(object sender, EventArgs e)
        {
            Button pole_6_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_6_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_7_Click(object sender, EventArgs e)
        {
            Button pole_7_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_7_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_8_Click(object sender, EventArgs e)
        {
            Button pole_8_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_8_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_9_Click(object sender, EventArgs e)
        {
            Button pole_9_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_9_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_10_Click(object sender, EventArgs e)
        {
            Button pole_10_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_10_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_11_Click(object sender, EventArgs e)
        {
            Button pole_11_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_11_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_12_Click(object sender, EventArgs e)
        {
            Button pole_12_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_12_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_13_Click(object sender, EventArgs e)
        {
            Button pole_13_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_13_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_14_Click(object sender, EventArgs e)
        {
            Button pole_14_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_14_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_15_Click(object sender, EventArgs e)
        {
            Button pole_15_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_15_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_16_Click(object sender, EventArgs e)
        {
            Button pole_16_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_16_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_17_Click(object sender, EventArgs e)
        {
            Button pole_17_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_17_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_18_Click(object sender, EventArgs e)
        {
            Button pole_18_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_18_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_19_Click(object sender, EventArgs e)
        {
            Button pole_19_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_19_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_20_Click(object sender, EventArgs e)
        {
            Button pole_20_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_20_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_21_Click(object sender, EventArgs e)
        {
            Button pole_21_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_21_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_22_Click(object sender, EventArgs e)
        {
            Button pole_22_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_22_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_23_Click(object sender, EventArgs e)
        {
            Button pole_23_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_23_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_24_Click(object sender, EventArgs e)
        {
            Button pole_24_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_24_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_25_Click(object sender, EventArgs e)
        {
            Button pole_25_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_25_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_26_Click(object sender, EventArgs e)
        {
            Button pole_26_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_26_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_27_Click(object sender, EventArgs e)
        {
            Button pole_27_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_27_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pole_28_Click(object sender, EventArgs e)
        {
            Button pole_28_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_28_vybrano.Tag);
            Otazka vybranaOtazka = seznamOtazek[indexOtazky];
            MessageBox.Show(vybranaOtazka.Text, "Otázka", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        
    }
}
