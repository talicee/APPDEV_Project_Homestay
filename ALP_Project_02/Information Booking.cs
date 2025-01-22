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
    public partial class Information_Booking : Form
    {
        
        public Information_Booking()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtBookInfo;
        string namastaff;
        int index = 0;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void Information_Booking_Load(object sender, EventArgs e)
        {
            btn_preview.Enabled = false;
            dgv_InformationBook.ClearSelection();
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtBookInfo = new DataTable();
            sqlQuery = "SELECT bi.booking_id, bi.rumah_id, bi.staff_id, bi.guest_id, bi.booking_tgl, bi.booking_total_biaya, bi.booking_tgl_cin, bi.booking_tgl_cout , gi.guest_nama " +
                "from booking_information bi " +
                "left join guest_information gi on bi.guest_id = gi.guest_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtBookInfo);
            dgv_InformationBook.DataSource = dtBookInfo;
            dgv_InformationBook.ClearSelection();
        }

        private void btn_InformationBookingSearch_Click(object sender, EventArgs e)
        {
            dtBookInfo = new DataTable();
            sqlQuery = "SELECT bi.booking_id, bi.rumah_id, bi.staff_id, bi.guest_id, bi.booking_tgl, bi.booking_total_biaya, bi.booking_tgl_cin, bi.booking_tgl_cout , gi.guest_nama " +
                "from booking_information bi " +
                "left join guest_information gi on bi.guest_id = gi.guest_id " +
                $"where gi.guest_nama LIKE '%{tb_InformationBooking.Text}%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtBookInfo);
            dgv_InformationBook.DataSource = dtBookInfo;
            dgv_InformationBook.ClearSelection();
        }

        private void btn_InformationBookingReset_Click(object sender, EventArgs e)
        {
            dtBookInfo = new DataTable();
            sqlQuery = "SELECT bi.booking_id, bi.rumah_id, bi.staff_id, bi.guest_id, bi.booking_tgl, bi.booking_total_biaya, bi.booking_tgl_cin, bi.booking_tgl_cout , gi.guest_nama " +
                "from booking_information bi " +
                "left join guest_information gi on bi.guest_id = gi.guest_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtBookInfo);
            dgv_InformationBook.DataSource = dtBookInfo;
            tb_InformationBooking.Text = "";
            dgv_InformationBook.ClearSelection();
            btn_preview.Enabled = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.nama_staff(namastaff);
            MF.Show();
            this.Close();
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            BookingPreview BP = new BookingPreview();
            BP.nama_staff(namastaff);
            BP.data(dtBookInfo, index);
            BP.Show();
            this.Close();
        }

        private void dgv_InformationBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_preview.Enabled = true;
            index = dgv_InformationBook.CurrentRow.Index;
        }
    }
}