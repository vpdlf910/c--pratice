namespace 텍스트박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = $"ID : {textBox1.Text} \r\n Password:{textBox2.Text}";

            if (textBox1.Text.ToUpper() == "RNRMSAH4904" && textBox2.Text.ToLower() == "rnrn8488!q") {
                MessageBox.Show("로그인 성공");
            }
        }
    }
}