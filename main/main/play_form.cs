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
        // Definice stran (indexy tlačítek na okrajích)
        List<int> levaStrana = new List<int> { 0, 1, 3, 6, 10, 15, 21 };
        List<int> pravaStrana = new List<int> { 0, 2, 5, 9, 14, 20, 27 };
        List<int> spodniStrana = new List<int> { 21, 22, 23, 24, 25, 26, 27 };

        // Mapa sousedů - které políčko se dotýká kterých
        // POZOR: Tohle sedí jen pokud máš Tagy očíslované 0-27 přesně z vrcholu dolů!
        Dictionary<int, List<int>> sousede = new Dictionary<int, List<int>>()
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 2, 3, 4 } },
            { 2, new List<int> { 0, 1, 4, 5 } },
            { 3, new List<int> { 1, 4, 6, 7 } },
            { 4, new List<int> { 1, 2, 3, 5, 7, 8 } },
            { 5, new List<int> { 2, 4, 8, 9 } },
            { 6, new List<int> { 3, 7, 10, 11 } },
            { 7, new List<int> { 3, 4, 6, 8, 11, 12 } },
            { 8, new List<int> { 4, 5, 7, 9, 12, 13 } },
            { 9, new List<int> { 5, 8, 13, 14 } },
            { 10, new List<int> { 6, 11, 15, 16 } },
            { 11, new List<int> { 6, 7, 10, 12, 16, 17 } },
            { 12, new List<int> { 7, 8, 11, 13, 17, 18 } },
            { 13, new List<int> { 8, 9, 12, 14, 18, 19 } },
            { 14, new List<int> { 9, 13, 19, 20 } },
            { 15, new List<int> { 10, 16, 21, 22 } },
            { 16, new List<int> { 10, 11, 15, 17, 22, 23 } },
            { 17, new List<int> { 11, 12, 16, 18, 23, 24 } },
            { 18, new List<int> { 12, 13, 17, 19, 24, 25 } },
            { 19, new List<int> { 13, 14, 18, 20, 25, 26 } },
            { 20, new List<int> { 14, 19, 26, 27 } },
            { 21, new List<int> { 15, 22 } },
            { 22, new List<int> { 15, 16, 21, 23 } },
            { 23, new List<int> { 16, 17, 22, 24 } },
            { 24, new List<int> { 17, 18, 23, 25 } },
            { 25, new List<int> { 18, 19, 24, 26 } },
            { 26, new List<int> { 19, 20, 25, 27 } },
            { 27, new List<int> { 20, 26 } }
        };
        List<int> poleHrac1 = new List<int>();
        List<int> poleHrac2 = new List<int>();
        List<int> cernaPole = new List<int>();
        int aktualniIndexNahradni = 0;
        private bool ZkontrolujVyhru(List<int> poleHrace)
        {
            HashSet<int> navstiveno = new HashSet<int>();

            foreach (int startovniPole in poleHrace)
            {
                // Pokud jsme toto pole už zkontrolovali v jiném ostrově, přeskočíme ho
                if (navstiveno.Contains(startovniPole)) continue;

                Queue<int> fronta = new Queue<int>();
                List<int> ostrov = new List<int>();

                fronta.Enqueue(startovniPole);
                navstiveno.Add(startovniPole);

                // Hledání všech propojených sousedů (tvoření ostrova)
                while (fronta.Count > 0)
                {
                    int aktualni = fronta.Dequeue();
                    ostrov.Add(aktualni);

                    foreach (int soused in sousede[aktualni])
                    {
                        if (poleHrace.Contains(soused) && !navstiveno.Contains(soused))
                        {
                            navstiveno.Add(soused);
                            fronta.Enqueue(soused);
                        }
                    }
                }

                // Kontrola, jestli ostrov zasahuje na všechny 3 strany
                bool dotekLeva = ostrov.Any(p => levaStrana.Contains(p));
                bool dotekPrava = ostrov.Any(p => pravaStrana.Contains(p));
                bool dotekSpodni = ostrov.Any(p => spodniStrana.Contains(p));

                if (dotekLeva && dotekPrava && dotekSpodni)
                {
                    return true; // VÝHRA!
                }
            }

            return false;
        }
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
                                if (HraData.hracNaRade == 1)
                                {
                                    poleHrac1.Add(indexOtazky);
                                }
                                else
                                {
                                    poleHrac2.Add(indexOtazky);
                                }
                                pole_vybrano.ForeColor = Color.Black;
                                pole_vybrano.Enabled = false;
                            }
                            aktualniIndexNahradni++;
                            // --- KONTROLA VÝHRY ---
                            if (ZkontrolujVyhru(poleHrac1))
                            {
                                MessageBox.Show($"Vyhrál hráč {HraData.JmenoHrac1}!", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close(); // Nebo přechod do menu
                                return;
                            }
                            else if (ZkontrolujVyhru(poleHrac2))
                            {
                                MessageBox.Show($"Vyhrál hráč {HraData.JmenoHrac2}!", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close(); // Nebo přechod do menu
                                return;
                            }

                            // --- KONTROLA REMÍZY ---
                            // Remíza nastane, pokud všechna tlačítka mají nějakého majitele, ale nikdo nevyhrál.
                            // Předpokládám 28 polí (0 až 27)
                            if (poleHrac1.Count + poleHrac2.Count == 28) // Pokud černé pole už nejde vybrat, přičti i: + cernaPole.Count
                            {
                                MessageBox.Show("Hra skončila remízou! Žádné další pole už nelze obsadit.", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                                return;
                            }
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
                            if (HraData.hracNaRade == 1)
                            {
                                poleHrac1.Add(indexOtazky);
                            }
                            else
                            {
                                poleHrac2.Add(indexOtazky);
                            }
                            pole_vybrano.ForeColor = Color.Black;
                            pole_vybrano.Enabled = false;
                        }
                        else
                        {
                            pole_vybrano.ForeColor = Color.White;
                            pole_vybrano.BackgroundImage = Properties.Resources.sestiuhelnik_cerny;
                            cernaPole.Add(indexOtazky);

                        }
                        // --- KONTROLA VÝHRY ---
                        if (ZkontrolujVyhru(poleHrac1))
                        {
                            MessageBox.Show($"Vyhrál hráč {HraData.JmenoHrac1}!", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Nebo přechod do menu
                            return;
                        }
                        else if (ZkontrolujVyhru(poleHrac2))
                        {
                            MessageBox.Show($"Vyhrál hráč {HraData.JmenoHrac2}!", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Nebo přechod do menu
                            return;
                        }

                        // --- KONTROLA REMÍZY ---
                        // Remíza nastane, pokud všechna tlačítka mají nějakého majitele, ale nikdo nevyhrál.
                        // Předpokládám 28 polí (0 až 27)
                        if (poleHrac1.Count + poleHrac2.Count == 28) // Pokud černé pole už nejde vybrat, přičti i: + cernaPole.Count
                        {
                            MessageBox.Show("Hra skončila remízou! Žádné další pole už nelze obsadit.", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            return;
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
