namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            button1.Text = "hesapla";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            List<char> harfler = new List<char>();
            List<int> sayilar = new List<int>();
            string alfabe = "abcçdefgðhýijklmnoöprsþtuüvyz";
            string cumle;
            listBox1.Items.Clear();
            for(int i = 0; i < 29; i++)
            {
                harfler.Add(alfabe[i]);
                sayilar.Add(0);
            }
           
            cumle = richTextBox1.Text;
            cumle = cumle.ToLower();
            for(int i = 0; i < cumle.Length; i++)
            {
                for(int j = 0; j < 29; j++)
                {
                    if(cumle[i] == harfler[j])
                    {
                        sayilar[j]++;
                    }
                }
            }
            for (int i = 0; i < 29; i++)
            {
                label1.Text += harfler[i] + ":" + Convert.ToString(sayilar[i]) + " ";
                label2.Text += Convert.ToString(sayilar[i]);
                if(sayilar[i] != 0)
                {
                    listBox1.Items.Add(harfler[i] + "  :  " + Convert.ToString(sayilar[i]) );
                }
            }
        }
    }
}