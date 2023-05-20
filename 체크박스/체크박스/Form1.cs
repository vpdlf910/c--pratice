namespace 체크박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateLabel()
        {
            string strchk1 = "";
            string strchk2 = "";
            string strchk3 = "";

            if (checkBox1.Checked) strchk1 = checkBox1.Text;
            else strchk1 = "";
            if (checkBox2.Checked) strchk2 = checkBox2.Text;
            else strchk2 = "";
            if (checkBox3.Checked) strchk3 = checkBox3.Text;
            else strchk3 = "";

            label1.Text = strchk1 + strchk2 + strchk3;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) label2.Text = checkBox4.Text;
            else label2.Text = "";
        }
    }
}