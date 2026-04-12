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

        List<int> cernaPole = new List<int>();
        int aktualniIndexNahradni = 0;
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

        public class nahradniOtazka
        {
            public string nahradniText { get; set; }
            public string nahradniOdpoved { get; set; }

            public nahradniOtazka(string nahrText, string nahrOdpoved)
            {
                nahradniText = nahrText;
                nahradniOdpoved = nahrOdpoved;
            }
        }

        List<Otazka> seznamOtazek = new List<Otazka>();
        List<nahradniOtazka> seznamNahradnichOtazek = new List<nahradniOtazka>();

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

        private void NaplnNahradnichOtazek()
        {
            string cestaKSouboru = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nahradni_otazky.txt");
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
                        seznamNahradnichOtazek.Add(new nahradniOtazka(textOtazky, odpoved));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání náhradních otázek: " + ex.Message);
            }

            Random rnd = new Random();
            int n = seznamNahradnichOtazek.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                nahradniOtazka value = seznamNahradnichOtazek[k];
                seznamNahradnichOtazek[k] = seznamNahradnichOtazek[n];
                seznamNahradnichOtazek[n] = value;
            }
        }


        public play_form()
        {
            InitializeComponent();
            NaplnOtazek();
            NaplnNahradnichOtazek();
        }

        private void play_form_Load(object sender, EventArgs e)
        {
            hrac1.Text = HraData.JmenoHrac1;
            hrac2.Text = HraData.JmenoHrac2;
            play_form.ActiveForm.Text = "Hra - " + HraData.JmenoHrac1 + " vs " + HraData.JmenoHrac2;
            

            
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                if (c is Button tlacitko)
                {
                    tlacitko.Click += pole_1_Click;
                }
            }
            if (HraData.hracNaRade == 1)
            {
                hrac1_tah.Visible = true;
                hrac2_tah.Visible = false;
                hrac1.Font = new Font(hrac1.Font, FontStyle.Bold);
                hrac2.Font = new Font(hrac2.Font, FontStyle.Regular);
                hrac1_tah.Text = "Hráč " + HraData.JmenoHrac1 + " je na tahu.";
            }
            else
            {
                hrac2_tah.Visible = true;
                hrac1_tah.Visible = false;
                hrac2.Font = new Font(hrac2.Font, FontStyle.Bold);
                hrac1.Font = new Font(hrac1.Font, FontStyle.Regular);
                hrac2_tah.Text = "Hráč " + HraData.JmenoHrac2 + " je na tahu.";
            }
        }

        private void odejit_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Opravdu si přejete ukončit rozehranou hru bez uložení?", "Pozor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                menu_form menu = new menu_form();
                menu.Show();
            }

        }
        
        private void pole_1_Click(object sender, EventArgs e)
        {
            Button pole_vybrano = (Button)sender;
            int indexOtazky = Convert.ToInt32(pole_vybrano.Tag);
            bool jeNahradniOtazka = (cernaPole.Contains(indexOtazky));
            if (jeNahradniOtazka)
            {
                if (aktualniIndexNahradni < seznamNahradnichOtazek.Count)
                {
                    nahradniOtazka nahr = seznamNahradnichOtazek[aktualniIndexNahradni];

                    using (QuestionFormYesNo okno = new QuestionFormYesNo(nahr.nahradniText, nahr.nahradniOdpoved))
                    {
                        if (okno.ShowDialog() == DialogResult.OK)
                        {
                            if (okno.jeSpravne)
                            {
                                pole_vybrano.BackgroundImage = (HraData.hracNaRade == 1) ?
                                    Properties.Resources.sestiuhelnik_aqua : Properties.Resources.sestiuhelnik_zlata;
                                pole_vybrano.ForeColor = Color.Black;
                                pole_vybrano.Enabled = false;
                            }
                            aktualniIndexNahradni++;
                            HraData.hracNaRade = (HraData.hracNaRade == 1) ? 2 : 1;
                        }
                    }
                }
            }
            else
            {
                Otazka vybranaOtazka = seznamOtazek[indexOtazky];
                using (QuestionForm okno = new QuestionForm(vybranaOtazka.Text, vybranaOtazka.Odpoved))
                {
                    if (okno.ShowDialog() == DialogResult.OK)
                    {
                        if (okno.jeSpravne)
                        {
                            pole_vybrano.BackgroundImage = (HraData.hracNaRade == 1) ?
                                Properties.Resources.sestiuhelnik_aqua : Properties.Resources.sestiuhelnik_zlata;
                            pole_vybrano.ForeColor = Color.Black;
                            pole_vybrano.Enabled = false;
                        }
                        else
                        {
                            pole_vybrano.ForeColor = Color.White;
                            pole_vybrano.BackgroundImage = Properties.Resources.sestiuhelnik_cerny;
                            cernaPole.Add(indexOtazky);

                        }
                        HraData.hracNaRade = (HraData.hracNaRade == 1) ? 2 : 1;
                    }
                }
            }
                
            if (HraData.hracNaRade == 1)
            {
                hrac1_tah.Visible = true;
                hrac2_tah.Visible = false;
                hrac1.Font = new Font(hrac1.Font, FontStyle.Bold);
                hrac2.Font = new Font(hrac2.Font, FontStyle.Regular);
                hrac1_tah.Text = "Hráč " + HraData.JmenoHrac1 + " je na tahu.";
            }
            else
            {
                hrac2_tah.Visible = true;
                hrac1_tah.Visible = false;
                hrac2.Font = new Font(hrac2.Font, FontStyle.Bold);
                hrac1.Font = new Font(hrac1.Font, FontStyle.Regular);
                hrac2_tah.Text = "Hráč " + HraData.JmenoHrac2 + " je na tahu.";
            }
        }

        
    }
}
