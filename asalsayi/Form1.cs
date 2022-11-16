namespace asalsayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                ulong sayac = 0;
                for (ulong sayi = 2; sayi <= 100000; sayi++)
                {
                    ulong kontrol = 0;

                    for (ulong i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            kontrol = 1;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                    listBox1.Items.Add(sayi);
                    sayac++;
                }
                    
                    
                        
                   
                   
                }

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
