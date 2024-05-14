namespace VeriYapilari2_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] kabarcikAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] hoareArt = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] lomutoAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] secmeliSortAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] arayaEklemeAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] birlestirmeAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] yiginAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] kovaAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };
        int[] kabukAry = { 54, 34, 12, 78, 98, 67, 5, 78, 32, 94, 11, 2, 44, 66, 24 };


        private void btnKabarcik_Click(object sender, EventArgs e)
        {
            KabarcikAlgoritmasi bubbleSort = new KabarcikAlgoritmasi();
            bubbleSort.BubbleSort(kabarcikAry);
            string yazdir = string.Join(",", kabarcikAry);
            lblKabarcik.Text = "Kabarcik Algoritmasi : " + yazdir;

        }

        private void btnHizliSiralama_Click(object sender, EventArgs e)
        {
            Hizlisiralama hoare = new Hizlisiralama();
            hoare.QuickSortHoare(hoareArt, 0, hoareArt.Length - 1);
            string yazdirHoare = string.Join(",", hoareArt);
            lblHoare.Text = "Hizli Siralama Hoare : " + yazdirHoare;

            Hizlisiralama lomuto = new Hizlisiralama();
            hoare.QuickSortHoare(lomutoAry, 0, lomutoAry.Length - 1);
            string yazdirLomuto = string.Join(",", lomutoAry);
            lblLomuto.Text = "Hizli Siralama Lomuto : " + yazdirLomuto;

        }

        private void btnSecmeliSiralama_Click(object sender, EventArgs e)
        {
            SecmeliSiralama secmeliSiralama = new SecmeliSiralama();
            secmeliSiralama.SelectionSort(secmeliSortAry);

            string yazdir = string.Join(",", secmeliSortAry);
            lblSecmeliSiralama.Text = "Secmeli Siralama : " + yazdir;


        }

        private void btnArayaEkleme_Click(object sender, EventArgs e)
        {
            ArayaEkleme arayaEkleme = new ArayaEkleme();
            arayaEkleme.InsertionSort(arayaEklemeAry);

            string yazdir = string.Join(",", arayaEklemeAry);
            lblArayaEkle.Text = "ArayaEkleme : " + yazdir;

        }

        private void btnBirlestirme_Click(object sender, EventArgs e)
        {
            Birlestirme birlestirme = new Birlestirme();
            birlestirme.MergeSort(birlestirmeAry, 0, birlestirmeAry.Length - 1);

            string yazdir = string.Join(",", birlestirmeAry);
            lblBirlestirme.Text = "Birlestirme : " + yazdir;


        }

        private void btnYigin_Click(object sender, EventArgs e)
        {
            Yigin yigin = new Yigin();
            yigin.HeapSort(yiginAry);

            string yazdir = string.Join(",", yiginAry);
            lblYigin.Text = "Yigin : " + yazdir;

        }

        private void btnKova_Click(object sender, EventArgs e)
        {
            Kova kova = new Kova();
            kova.BucketSort(kovaAry);

            string yazdir = string.Join(",", kovaAry);
            lblKova.Text = "Kova : " + yazdir;
            ;
        }

        private void btnKabuk_Click(object sender, EventArgs e)
        {
            Kabuk kabuk = new Kabuk();
            kabuk.ShellSort(kabukAry);

            string yazdir = string.Join(",", kabukAry);
            lblKabuk.Text = "Kabuk : " + yazdir;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lblKabarcik.Text = "";
            lblHoare.Text = "";
            lblLomuto.Text = "";
            lblSecmeliSiralama.Text = "";
            lblArayaEkle.Text = "";
            lblBirlestirme.Text = "";
            lblYigin.Text = "";
            lblKova.Text = "";
            lblKabuk.Text = "";
        }

    }
}
