namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;
            int çýkarma;
            int bölme;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;

            label3.Text = Convert.ToString(toplam);

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            çýkarma = sayi1 - sayi2;
            label7.Text = Convert.ToString(çýkarma);


            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            bölme = sayi1 / sayi2;
            label8.Text = Convert.ToString(bölme);






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}