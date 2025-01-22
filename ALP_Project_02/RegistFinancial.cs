using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Project_02
{
    public partial class RegistFinancial : Form
    {
        string selectedBookingID;
        string selectedDate;
        int selectedHarga;
        string selectedNama;

        public RegistFinancial()
        {
            InitializeComponent();
            selectedBookingID = Table_Booking.selectedBookingID;
            selectedDate = Table_Booking.selectedDate;
            selectedHarga = Table_Booking.selectedHarga;
            selectedNama = Table_Booking.selectedNama;
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dttipe = new DataTable();
        DataTable dtstatus = new DataTable();
        DataTable dtmetode = new DataTable();
        DataTable dtfinance = new DataTable();

        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void RegistFinancial_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(
                $"server=localhost;" +
                $"uid=root;" +
                $"pwd=.;" +
                $"database=indramar_20232_dbd_3");

            dttipe.Columns.Add("Abv");
            dttipe.Columns.Add("Full");
            dttipe.Rows.Add("LU", "Lunas");
            dttipe.Rows.Add("RE", "Refund");
            cb_tipe.DataSource = dttipe;
            cb_tipe.ValueMember = "Abv";
            cb_tipe.DisplayMember = "Full";
            cb_tipe.Text = "";

            dtstatus.Columns.Add("Abv");
            dtstatus.Columns.Add("Full");
            dtstatus.Rows.Add("B", "Berhasil");
            dtstatus.Rows.Add("G", "Gagal");
            cb_status.DataSource = dtstatus;
            cb_status.ValueMember = "Abv";
            cb_status.DisplayMember = "Full";
            cb_status.Text = "";

            dtmetode.Columns.Add("Abv");
            dtmetode.Columns.Add("Full");
            dtmetode.Rows.Add("Tf", "Transfer");
            dtmetode.Rows.Add("QRIS", "QRIS");
            dtmetode.Rows.Add("Kredit", "Kredit");
            dtmetode.Rows.Add("Debit", "Debit");
            dtmetode.Rows.Add("Cash", "Cash");
            cb_metode.DataSource = dtmetode;
            cb_metode.ValueMember = "Abv";
            cb_metode.DisplayMember = "Full";
            cb_metode.Text = "";

            tb_booking.Text = Data.selectedBookingID;
            tb_transid.Text = "";

            string sql2 = "SELECT * FROM financial_transaction;";
            sqlCommand = new MySqlCommand(sql2, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            dtfinance.Clear();
            sqlDataAdapter.Fill(dtfinance);
            dgv_finance.DataSource = dtfinance;
            dgv_finance.ClearSelection();

        }

        string trans_id = "";
        int harga = 0;

        //insert ke database
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_booking.Text == "" || tb_jumlah.Text == "" || cb_metode.Text == "" || cb_status.Text == "" || cb_tipe.Text == "")
            {
                MessageBox.Show("Error", "Please fill all fields!");
            }
            else
            {
                trans_id = newTransId();
                string date = datepicker.Value.ToString("yy-MM-dd HH:mm");

                string sql = $"INSERT INTO financial_transaction " +
                    $"(trans_id, booking_id, trans_tgl, trans_jml_bayar," +
                    $" trans_tipe_bayar, trans_status_bayar, trans_metode_bayar, status_del)" +
                    $" VALUES ('{trans_id}', '{tb_booking.Text}', '{date}', " +
                    $"{harga}, '{cb_tipe.Text}', " +
                    $"'{cb_status.SelectedValue}', '{cb_metode.SelectedValue}', 0);";
                sqlCommand = new MySqlCommand(sql, sqlConnect);
                sqlConnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show($"Saved new trans ID: {trans_id}!", "Success !");
                    tb_booking.Text = "";
                    tb_jumlah.Text = "";
                    tb_transid.Text = "";
                    lb_namaguest.Text = "";
                    //lb_IDG.Text = "";

                    Data.selectedHarga = 0;
                    Data.selectedBookingID = "";
                    Data.selectedNama = "";
                    Data.selectedDate = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error", "Failed to save data: " + ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }

                //fill datagridview
                string sql2 = "SELECT * FROM financial_transaction;";
                sqlCommand = new MySqlCommand(sql2, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                dtfinance.Clear();
                sqlDataAdapter.Fill(dtfinance);
                dgv_finance.DataSource = dtfinance;

                tb_booking.Text = "";
                tb_jumlah.Text = "";
                tb_transid.Text = "";
                cb_metode.Text = "";
                cb_status.Text = "";
                cb_tipe.Text = "";
            }
            dgv_finance.ClearSelection();
        }

        //auto transaksi id, id dari tanggal booking
        private string newTransId()
        {
            string date = datepicker.Value.ToString("yyMMdd");
            string prefix = "T" + cb_tipe.SelectedValue + date;
            string sql = $"SELECT trans_id FROM financial_transaction WHERE trans_id LIKE '{prefix}%' ORDER BY trans_id DESC LIMIT 1;";
            sqlCommand = new MySqlCommand(sql, sqlConnect);

            sqlConnect.Open();
            object result = sqlCommand.ExecuteScalar();
            sqlConnect.Close();

            //ambil count diakhir, cek kalo udah ada, ditambah count,
            //spy transid (primary key) tidak ada yg sama (hrsnyapls)
            int newCount = 1;
            if (result != null)
            {
                string lastTransId = result.ToString();
                string lastCountStr = lastTransId.Substring(prefix.Length);
                if (int.TryParse(lastCountStr, out int lastCount))
                {
                    newCount = lastCount + 1;
                }
            }
            return prefix + newCount.ToString("D2");
        }

        //tipe ganti -> trans id ganti dan harga ganti (auto harga)
        private void cb_tipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            trans_id = "";
            trans_id = newTransId();
            tb_transid.Text = trans_id;
            if (cb_tipe.Text == "Lunas")
            {
                harga = Data.selectedHarga / 2;
            }
            else
            {
                harga = Data.selectedHarga / 4;
            }
            tb_jumlah.Text = "Rp " + Convert.ToInt32(harga).ToString();
        }

        //booking id ganti ->  date ganti -> trans id ganti
        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
            trans_id = "";
            trans_id = newTransId();
            tb_transid.Text = trans_id;
        }

        //ambil booking id
        //ambil tanggal booking dari booking id
        private void tb_booking_TextChanged(object sender, EventArgs e)
        {
            datepicker.Text = Data.selectedDate;
            lb_namaguest.Text = Data.selectedNama;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tb_booking.Text = "";
            tb_jumlah.Text = "";
            tb_transid.Text = "";
            lb_namaguest.Text = "";
            lb_IDG.Text = "";

            Data.selectedHarga = 0;
            Data.selectedBookingID = "";
            Data.selectedNama = "";
            Data.selectedDate = "";

            MainForm MF = new MainForm();
            MF.nama_staff(namastaff);
            MF.Show();
            this.Close();
        }

        private void btn_dgvBookingID_Click(object sender, EventArgs e)
        {
            Table_Booking TB = new Table_Booking();
            TB.nama_staff(namastaff);
            TB.Show();
            this.Close();
        }
    }
}
