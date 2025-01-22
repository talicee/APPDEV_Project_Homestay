using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALP_Project_02
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dttrans = new DataTable();
        DataTable dtsearch = new DataTable();
        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void Transaction_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(
            $"server=localhost;" +
            $"uid=root;" +
            $"pwd=.;" +
            $"database=indramar_20232_dbd_3");

            string sql = "select trans_id as `Trans ID` , booking_id as `Booking ID`, trans_tgl as `Tanggal Trans`, trans_jml_bayar as `Jumlah Bayar`, trans_tipe_bayar as `Tipe Bayar`, trans_status_bayar as `Status Bayar`, trans_metode_bayar as `Metode Bayar` from financial_transaction;\r\n";
            sqlCommand = new MySqlCommand(sql, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dttrans);
            dgv_transaction.DataSource = dttrans;
            dgv_transaction.ClearSelection();
        }

        private void btn_TransactionSearch_Click(object sender, EventArgs e)
        {
            dtsearch.Rows.Clear();
            string sql = $"select trans_id as `Trans ID` , booking_id as `Booking ID`, trans_tgl as `Tanggal Trans`, trans_jml_bayar as `Jumlah Bayar`, trans_tipe_bayar as `Tipe Bayar`, trans_status_bayar as `Status Bayar`, trans_metode_bayar as `Metode Bayar` from financial_transaction where booking_id LIKE '%{txbx_InformationBooking.Text}%';";
            sqlCommand = new MySqlCommand(sql, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtsearch);
            dgv_transaction.DataSource = dtsearch;
            dgv_transaction.ClearSelection();
        }

        private void btn_InformationBookingReset_Click(object sender, EventArgs e)
        {
            dttrans.Rows.Clear();
            string sql = "select trans_id as `Trans ID` , booking_id as `Booking ID`, trans_tgl as `Tanggal Trans`, trans_jml_bayar as `Jumlah Bayar`, trans_tipe_bayar as `Tipe Bayar`, trans_status_bayar as `Status Bayar`, trans_metode_bayar as `Metode Bayar` from financial_transaction;\r\n";
            sqlCommand = new MySqlCommand(sql, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dttrans);
            dgv_transaction.DataSource = dttrans;
            dgv_transaction.ClearSelection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.nama_staff(namastaff);
            MF.Show();
            this.Close();
        }
    }
}
