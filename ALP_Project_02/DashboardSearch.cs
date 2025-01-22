using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Project_02
{
    public partial class DashboardSearch : Form
    {
        public DashboardSearch()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtHouseInfo;

        string namastaff;
        string datetimecin;
        string datetimecout;
        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }

        private void DashboardSearch_Load(object sender, EventArgs e)
        {
            cobox_HomeNumberOfRooms.Items.Add("2 ");
            cobox_HomeNumberOfRooms.Items.Add("3 ");
            cobox_HomeNumberOfRooms.Items.Add("4 ");
            cobox_HomeNumberOfRooms.Items.Add("5 ");

            datetime_cin.Value = DateTime.Today;
            datetime_cout.Value = DateTime.Today;

            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = $"(SELECT r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                $"FROM rumah r " +
                $"WHERE r.rumah_id NOT IN (SELECT DISTINCT b.rumah_id " +
                $"FROM booking_information b, financial_transaction f " +
                $"WHERE f.booking_id = b.booking_id " +
                $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                $"AND f.trans_tipe_bayar != 'Refund')) " +
                $"UNION " +
                $"(SELECT DISTINCT b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                $"FROM booking_information b, financial_transaction f, rumah r " +
                $"WHERE r.rumah_id = b.rumah_id " +
                $"AND f.booking_id = b.booking_id " +
                $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                $"AND f.trans_tipe_bayar = 'Refund') " +
                $"ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Search.DataSource = dtHouseInfo;
            dgv_Search.ClearSelection();
        }

        private void datetime_cin_ValueChanged(object sender, EventArgs e)
        {
            var tahun = datetime_cin.Value.Year;
            var month = datetime_cin.Value.Month;
            var day = datetime_cin.Value.Day;
            datetimecin = tahun.ToString() + "-" + month.ToString() + "-" + day.ToString();
        }

        private void datetime_cout_ValueChanged(object sender, EventArgs e)
        {
            var tahun = datetime_cout.Value.Year;
            var month = datetime_cout.Value.Month;
            var day = datetime_cout.Value.Day;
            datetimecout = tahun.ToString() + "-" + month.ToString() + "-" + day.ToString();
        }

        private void btn_SearchOk_Click(object sender, EventArgs e)
        {
            if (cobox_HomeNumberOfRooms.Text != "") 
            {
                //sqlConnect = new MySqlConnection("server=localhost; uid=root; password=110505*; database=indramar_20232_dbd_3_coba");
                dtHouseInfo = new DataTable(); //cast itu convert datetime jadi date
                sqlQuery = $"(SELECT r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"FROM rumah r " +
                    $"WHERE r.rumah_id NOT IN (SELECT DISTINCT b.rumah_id " +
                    $"FROM booking_information b, financial_transaction f " +
                    $"WHERE f.booking_id = b.booking_id " +
                    $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                    $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                    $"AND f.trans_tipe_bayar != 'Refund') " +
                    $"AND r.rumah_jml_kamar = {Convert.ToInt32(cobox_HomeNumberOfRooms.Text)}) " +
                    $"UNION " +
                    $"(SELECT DISTINCT b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"FROM booking_information b, financial_transaction f, rumah r " +
                    $"WHERE r.rumah_id = b.rumah_id " +
                    $" AND f.booking_id = b.booking_id " +
                    $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                    $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                    $"AND f.trans_tipe_bayar = 'Refund' " +
                    $"AND r.rumah_jml_kamar = {Convert.ToInt32(cobox_HomeNumberOfRooms.Text)}) " +
                    $"ORDER BY 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtHouseInfo);
                dgv_Search.DataSource = dtHouseInfo;
            }
            else if (cobox_HomeNumberOfRooms.Text == "")
            {
                //sqlConnect = new MySqlConnection("server=localhost; uid=root; password=110505*; database=indramar_20232_dbd_3_coba");
                dtHouseInfo = new DataTable();
                sqlQuery = $"(SELECT r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"FROM rumah r " +
                    $"WHERE r.rumah_id NOT IN (SELECT DISTINCT b.rumah_id " +
                    $"FROM booking_information b, financial_transaction f " +
                    $"WHERE f.booking_id = b.booking_id " +
                    $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                    $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                    $"AND f.trans_tipe_bayar != 'Refund')) " +
                    $"UNION " +
                    $"(SELECT DISTINCT b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"FROM booking_information b, financial_transaction f, rumah r " +
                    $"WHERE r.rumah_id = b.rumah_id " +
                    $"AND f.booking_id = b.booking_id " +
                    $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                    $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                    $"AND f.trans_tipe_bayar = 'Refund') " +
                    $"ORDER BY 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtHouseInfo);
                dgv_Search.DataSource = dtHouseInfo;
            }
            dgv_Search.ClearSelection();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            datetime_cin.Value = DateTime.Today;
            datetime_cout.Value = DateTime.Today;
            cobox_HomeNumberOfRooms.SelectedIndex = -1;

            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = $"(SELECT r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                $"FROM rumah r " +
                $"WHERE r.rumah_id NOT IN (SELECT DISTINCT b.rumah_id " +
                $"FROM booking_information b, financial_transaction f " +
                $"WHERE f.booking_id = b.booking_id " +
                $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                $"AND f.trans_tipe_bayar != 'Refund')) " +
                $"UNION " +
                $"(SELECT DISTINCT b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                $"FROM booking_information b, financial_transaction f, rumah r " +
                $"WHERE r.rumah_id = b.rumah_id " +
                $"AND f.booking_id = b.booking_id " +
                $"AND ('{datetimecin}' < CAST(b.booking_tgl_cout AS DATE) " +
                $"AND '{datetimecout}' > CAST(b.booking_tgl_cin AS DATE)) " +
                $"AND f.trans_tipe_bayar = 'Refund') " +
                $"ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Search.DataSource = dtHouseInfo;

            cobox_HomeNumberOfRooms.Text = string.Empty;
            dgv_Search.ClearSelection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.nama_staff(namastaff);
            mainForm.Show();
            this.Close();
        }
    }
}