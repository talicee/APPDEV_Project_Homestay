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
    public partial class Table_Booking : Form
    {
        public static string selectedBookingID;
        public static string selectedDate;
        public static int selectedHarga;
        public static string selectedNama;
        public Table_Booking()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtHouseInfo;
        DataTable dtsimpanHouse;
        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }

        private void Table_Booking_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT b.booking_id, b.rumah_id, b.staff_id, b.guest_id, b.booking_tgl, b.booking_total_biaya, b.booking_tgl_cin, b.booking_tgl_cout, g.guest_nama\r\nFROM booking_information b\r\nLEFT JOIN guest_information g ON g.guest_id = b.guest_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Booking.DataSource = dtHouseInfo;
            dgv_Booking.ClearSelection();
        }

        private void btn_BookingSearch_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = $"select * " +
                $"from booking_information " +
                $"where booking_id LIKE '%{tb_BookingID.Text}%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Booking.DataSource = dtHouseInfo;
            dgv_Booking.ClearSelection();
        }

        private void btn_BookingReset_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT * FROM booking_information";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Booking.DataSource = dtHouseInfo;
            tb_BookingID.Text = string.Empty;
            dgv_Booking.ClearSelection();
        }

        private void dgv_Booking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvHouseID = dgv_Booking.CurrentRow;
            Data.selectedBookingID = dgvHouseID.Cells[0].Value.ToString();
            Data.selectedDate = dgvHouseID.Cells[6].Value.ToString();
            Data.selectedHarga = Convert.ToInt32(dgvHouseID.Cells[5].Value);
            Data.selectedNama = dgvHouseID.Cells[8].Value.ToString();

            RegistFinancial RF = new RegistFinancial();
            RF.nama_staff(namastaff);
            RF.Show();
            this.Close();
        }

        private void btn_BookingBack_Click(object sender, EventArgs e)
        {
            RegistFinancial registfinancial = new RegistFinancial();
            registfinancial.nama_staff(namastaff);
            registfinancial.Show();
            this.Close();
        }
    }
}
