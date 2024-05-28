namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            List<int> sayilar = new List<int>();
            if (trackBar2.Value > trackBar3.Value)
            {
                MessageBox.Show("Min Değer Max Değerden Büyük Olamaz!");
                return;
            }

            int max = trackBar3.Value - trackBar2.Value + 1;
            if (trackBar1.Value > max)
            {
                MessageBox.Show("Üretilecek Sayı Adedi Min ve Max Değer Arasında Olmalıdır!");
                return;
            }
            for (int i = 0; i < trackBar1.Value; i++)
            {
                int sayi = rnd.Next(trackBar2.Value, trackBar3.Value);
                if (!sayilar.Contains(sayi))
                {
                    sayilar.Add(sayi);
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    i--;
                }
            }
        }

        private void trackBar1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            label1.Text = "Kaç Adet Üretilsin? : " + trackBar1.Value.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Kaç Adet Üretilsin? : " + trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Min Değer : " + trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Max Değer : " + trackBar3.Value.ToString();
        }
    }
}
