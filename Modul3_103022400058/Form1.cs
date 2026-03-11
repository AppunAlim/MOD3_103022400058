namespace Modul3_103022400058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_akhir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_awal_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBox_awal.Text, out double nilai))
            {
                MessageBox.Show("Masukan Angka");
                return;
            }
            if (cmbBox_awal.SelectedItem == null || cbmBox_akhir.SelectedItem == null);
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
            }

            string awal = cmbBox_awal.SelectedItem.ToString();
            string akhir = cbmBox_akhir.SelectedItem.ToString();
            double suhu = 0;
            double hasil = 0;

            switch (awal){
                case "Celcius" :
                    suhu = nilai;
                    break;
                case "Fahrenheit":
                    suhu = (nilai - 32) * 5 / 9;
                    break;
                case "Kelvin":
                    suhu = nilai - 273.15;
                    break;
                case "Reamur":
                    suhu = nilai*  5 / 4;
                    break;
            }

            switch (akhir)
            {
                case "Celcius":
                    hasil = suhu;
                    break;
                case "Fahrenheit":
                    hasil = (suhu - 32) * 5 / 9;
                    break;
                case "Kelvin":
                    hasil = suhu - 273.15;
                    break;
                case "Reamur":
                    hasil = suhu * 5 / 4;
                    break;
            }


            txtBox_akhir.Text = hasil.ToString();
        }

        private void cbmBox_akhir_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
