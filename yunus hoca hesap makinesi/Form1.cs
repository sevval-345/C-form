using System.Numerics;

namespace yunus_hoca_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar;
            int uzunkenar;
            int alan;
            int alan2;


            kisakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);

            alan = kisakenar * kisakenar;

            if (kisakenar == uzunkenar)
            {

                label5.Text = Convert.ToString(alan);

            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kisakenar;
            int uzunkenar;
            int alan2;


            kisakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);


            alan2 = kisakenar * uzunkenar;
            if (kisakenar != uzunkenar)
            {
                label6.Text = Convert.ToString(alan2);
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = " ";
            label5.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}