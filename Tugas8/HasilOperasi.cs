namespace Tugas8
{
    public partial class HasilOperasi : Form
    {
        public HasilOperasi()
        {
            InitializeComponent();
        }
        private void Tulis(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', '*', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            OutputHasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }
        private void Menghitung(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator hitung = new Calculator();
            hitung.penghubung += Tulis;
            hitung.ShowDialog();
        }
    }
}