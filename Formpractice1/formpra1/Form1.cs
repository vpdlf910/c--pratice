namespace formpra1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "��ư1�� ������.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = FlatStyle.Flat.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "���ǥ��";
        }
    }
}