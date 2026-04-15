namespace main
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        private void odejit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Chystáte se ukonèit aplikaci. Opravdu chcete pokraèovat?","Upozornìní!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            about_form about = new about_form();
            about.Show();
            this.Hide();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            play_form play = new play_form();
            play.Show();
            this.Hide();
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            settings_form settings = new settings_form();
            settings.Show();
            this.Hide();
        }
    }
}
