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

        private void play_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu_form menu = new menu_form();
            menu.Show();
        }
    }
}
