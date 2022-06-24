namespace _0703
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // задаем обработчик события
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://metanit.com");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
            "Кузнецов",
            "Иванов",
            "Петров",
            "Кустов"
        };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
    