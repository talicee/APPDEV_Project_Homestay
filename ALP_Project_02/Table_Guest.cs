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
    public partial class Table_Guest : Form
    {
        //public static string selectedGuestID;

        public Table_Guest()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtHouseInfo;

        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void Table_Guest_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.;; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT * FROM guest_information";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Guest.DataSource = dtHouseInfo;
            dgv_Guest.ClearSelection();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = $"select * " +
                $"from guest_information " +
                $"where guest_nama like '%{tb_GuestName.Text}%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Guest.DataSource = dtHouseInfo;
            dgv_Guest.ClearSelection();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT * FROM guest_information";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Guest.DataSource = dtHouseInfo;
            dgv_Guest.ClearSelection();
        }

        private void dgv_Guest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvrRegistGuest = dgv_Guest.CurrentRow;
            Data.selectedGuestID = dgvrRegistGuest.Cells[0].Value.ToString();
            //MessageBox.Show(selectedGuestID);

            Registration_Homestay IH = new Registration_Homestay();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_RegistrationGuestBack_Click(object sender, EventArgs e)
        {
            Registration_Homestay registration_Homestay = new Registration_Homestay();
            registration_Homestay.nama_staff(namastaff);
            registration_Homestay.Show();
            this.Close();
        }
    }
}
