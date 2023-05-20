namespace 메세지박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "텍스트 파일(*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();

            foreach( var item in openFileDialog1.FileNames)
            {
                textBox1.Text = textBox1.Text + item;
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}