using System;
using System.Windows;
using System.Windows.Controls;


namespace allahyonetimpaneliv3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int sicaklik = 5000;
        int hurisayisi = 5000;
        public MainWindow()
        {

            InitializeComponent();

        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void button_Deprem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBox_deprem.Text + " Bölgesine Deprem Yollandı");
        }

        private void button_Tsunami_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBox_tsunami.Text + " Bölgesine Tsunami Yollandı");

        }

        private void button_ateist_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBox_ateist.Text + " Adlı Kul Başarıyla Ateist Yapıldı");

        }

        private void button_vahiy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBox_vahiy.Text + " Adlı Vahiy Başarıyla Gönderildi");

        }

        private void button_beni_kopyala_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Başarıyla Kopyalandınız!");

        }

        private void button_gezegen_yarat_Click(object sender, RoutedEventArgs e)
        {

            double sayi = random.NextDouble();
            string gezegen = sayi.ToString().Trim(new char[] { '0', '.' });
            MessageBox.Show(gezegen + " no'lu gezegen yaratildi.");
        }

        private void button_yildiz_yarat_Click(object sender, RoutedEventArgs e)
        {

            double sayi = random.NextDouble();
            string yildiz = sayi.ToString().Trim(new char[] { '0', '.' });
            MessageBox.Show(yildiz + " no'lu yıldız yaratildi.");
        }

        private void button_goktasi_yarat_Click(object sender, RoutedEventArgs e)
        {

            double sayi = random.NextDouble();
            string goktasi = sayi.ToString().Trim(new char[] { '0', '.' });
            MessageBox.Show(goktasi + " no'lu gök taşı yaratildi.");
        }

        private void button_insan_yarat_Click(object sender, RoutedEventArgs e)
        {

            long sayi = random.NextInt64(3000000000, 5000000000);
            string insan = sayi.ToString();
            MessageBox.Show(insan + " no'lu insan yaratildi.");
        }

        private void button_melek_yarat_Click(object sender, RoutedEventArgs e)
        {

            int sayi = random.Next(5000, 10000);
            string melek = sayi.ToString();
            MessageBox.Show(melek + " no'lu melek yaratildi.");
        }

        private void button_cin_yarat_Click(object sender, RoutedEventArgs e)
        {

            long sayi = random.NextInt64(500000000, 1000000000);
            string cin = sayi.ToString();
            MessageBox.Show(cin + " no'lu cin yaratildi.");
        }

        private void button_kıyamet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sûr'a üflendi, kıyamet başarıyla başlatıldı tebrikler!");
        }

        private void button_iptal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("İşlem iptal edildi!");

        }

        private void button_uygula_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("İşlemler başarıyla uygulandı!");

        }

        private void button_tamam_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tabii efendim!");

        }

        private void button_cehennem_odun_at_Click(object sender, RoutedEventArgs e)
        {
            sicaklik = sicaklik += random.Next(250, 1000);

            int kelvin = sicaklik + 273;
            MessageBox.Show("Cehenneme odun atıldı! Sıcaklık: " + sicaklik + " C° derece " + kelvin + " kelvin");
        }

        private void button_cehennem_atesi_kis_Click(object sender, RoutedEventArgs e)
        {
            sicaklik = sicaklik -= random.Next(250, 1000);

            int kelvin = sicaklik + 273;
            MessageBox.Show("Cehennemin altı kısıldı! Sıcaklık: " + sicaklik + " C° derece " + kelvin + " kelvin");
        }

        private void button_cennet_huri_arttir_Click(object sender, RoutedEventArgs e)
        {
            int hurisayisiplus = hurisayisi += random.Next(1000, 5000);
            MessageBox.Show("Cennetteki huru sayısı arttirildi artık " + hurisayisi + " kadar huri var.");
        }

        private void button_huri_bakire_yap_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(hurisayisi + " hurinin hepsi başarıyla bakire yapıldı!");
        }
    }
}
