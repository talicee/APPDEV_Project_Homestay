using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Project_02
{
    public partial class Table_Homestay : Form
    {
        //public static string selectedHouseID;

        public Table_Homestay()
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
        private void Table_Homestay_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.;; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT * FROM rumah";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Homestay.DataSource = dtHouseInfo;
            dgv_Homestay.ClearSelection();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.;; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = $"select * " +
                $"from rumah " +
                $"where rumah_nama like '%{tb_RumahName.Text}%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Homestay.DataSource = dtHouseInfo;
            dgv_Homestay.ClearSelection();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=.; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT * FROM rumah";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_Homestay.DataSource = dtHouseInfo;

            tb_RumahName.Text = string.Empty;
            dgv_Homestay.ClearSelection();
        }

        private void dgv_Homestay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvHouseID = dgv_Homestay.CurrentRow;
            Data.selectedHouseID = dgvHouseID.Cells[0].Value.ToString();
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
