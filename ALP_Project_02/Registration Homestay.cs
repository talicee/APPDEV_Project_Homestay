using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ALP_Project_02
{
    public partial class Registration_Homestay : Form
    {
        string selectedGuestID;
        string selectedHouseID;

        public Registration_Homestay()
        {
            InitializeComponent();
            //selectedGuestID = Table_Guest.selectedGuestID;
            //selectedHouseID = Table_Homestay.selectedHouseID;
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        string sqlQuery2;
        DataTable dtHomeRegist;
        DataTable dtFinanceDP;
        DataTable dtHargaSewa;
        string transIDNew;
        string datetimeBook;
        string datetimecin;
        string datetimecout;
        string staffID;
        int hari;
        int indeks = 0;
        int totalDP = 0;
        bool hi = false;
        string namastaff;
        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void Registration_Homestay_Load(object sender, EventArgs e)
        {
            tb_RegistHomeGuestID.Text = Data.selectedGuestID;
            tb_RegistHomeID.Text = Data.selectedHouseID;

            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtHomeRegist = new DataTable();
            sqlQuery = "SELECT * FROM booking_information";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHomeRegist);
            dgv_RegistHomestay.DataSource = dtHomeRegist;

            dtHargaSewa = new DataTable();
            sqlQuery2 = "SELECT rumah_id, rumah_harga_sewa FROM rumah";
            sqlCommand = new MySqlCommand(sqlQuery2, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHargaSewa);

            bool found = false;
            for (int j = 0; j < dtHomeRegist.Rows.Count; j++)
            {
                if (Data.bookid == dtHomeRegist.Rows[j][0].ToString())
                {
                    found = true; break;
                }
            }
            if(found == true)
            {
                if (Data.datecout != null && Data.datebook != null && Data.datecin != null && Data.guestid != null)
                {
                    btn_dgvGuestID.Enabled = false;
                    btn_RegistrationHomestaySave.Enabled = false;
                    datetime_BookDate.Enabled = false;
                    datetime_cin.Enabled = false;
                    datetime_cout.Enabled = false;

                    cbx_RegistHomeMetodeByr.Text = Data.metodebyr;
                    tb_RegistHomeBookID.Text = Data.bookid;
                    tb_RegistHomeGuestID.Text = Data.guestid;
                    datetime_BookDate.Text = Data.datebook;
                    datetime_cin.Text = Data.datecin;
                    datetime_cout.Text = Data.datecout;
                    //tb_RegistHomeGuestID.Text = Data.selectedGuestID;
                    //tb_RegistHomeID.Text = Data.selectedHouseID;
                }
            }
            else
            {
                btn_edit.Enabled = false;
            }
            dgv_RegistHomestay.ClearSelection();

        }

        private void datetime_cin_ValueChanged(object sender, EventArgs e)
        {
            if(datetime_cin.Value >= datetime_BookDate.Value)
            {
                int count = 0;

                //ini buat tanggal cin di book_info
                datetimecin = datetime_cin.Value.ToString("yyyy-MM-dd HH:mm");

                bool found = false;
                for (int j = 0; j < dtHomeRegist.Rows.Count; j++)
                {
                    if (tb_RegistHomeBookID.Text == dtHomeRegist.Rows[j][0].ToString())
                    {
                        found = true; break;
                    }
                }

                if (found == false)
                {
                    //ini buat id book, krn id book dibuat berdasar tgl cin
                    string year = datetime_cin.Value.ToString("yy");
                    string month = datetime_cin.Value.ToString("MM");
                    string day = datetime_cin.Value.ToString("dd");

                    string bookID = "B" + year + month + day;
                    for (int i = 0; i < dtHomeRegist.Rows.Count; i++)
                    {
                        string IDdgv = dtHomeRegist.Rows[i][0].ToString().Substring(0, 7);
                        if (IDdgv == bookID)
                        {
                            count++;
                        }
                    }
                    count++;
                    if (count < 10)
                    {
                        tb_RegistHomeBookID.Text = bookID + "0" + count;
                    }
                    else if (count < 100)
                    {
                        tb_RegistHomeBookID.Text = bookID + count;
                    }
                }
            }
            else
            {
                datetime_cin.Value = datetime_BookDate.Value;
            }
        }
        
        private void datetime_cout_ValueChanged(object sender, EventArgs e)
        {
            if(datetime_cout.Value > datetime_cin.Value)
            {             
                //ini buat tanggal cout di book_info
                datetimecout = datetime_cout.Value.ToString("yyyy-MM-dd HH:mm");

                //ini buat selisih hari
                DateTime cout = Convert.ToDateTime(datetimecout);
                DateTime cin = Convert.ToDateTime(datetimecin);
                TimeSpan nod = cout - cin;
                hari = Convert.ToInt32(nod.TotalDays);

                int indeks = 0;
                for (int i = 0; i < dtHargaSewa.Rows.Count; i++)
                {
                    if (tb_RegistHomeID.Text == dtHargaSewa.Rows[i][0].ToString())
                    {
                        indeks = i;
                        break;
                    }
                }

                int total = hari * Convert.ToInt32(dtHargaSewa.Rows[indeks][1].ToString());
                totalDP = total / 2;
                tb_RegistHomeTotalFee.Text = "Rp. " + Convert.ToInt32(total).ToString("C2").Remove(0, 2);
                tb_RegistHomeTotalFee2.Text = total.ToString();
            }
            else
            {
                DateTime besok = datetime_cin.Value.AddDays(1);
                datetime_cout.Value = besok;
            }
        }
        
        private void datetime_BookDate_ValueChanged(object sender, EventArgs e)
        {
            tglnow.Text = DateTime.Now.ToString().Substring(0, 10);
            tglbook.Text = datetime_BookDate.Value.ToString().Substring(0, 10);
            if (datetime_BookDate.Value >= DateTime.Now || tglnow.Text == tglbook.Text)
            {
                //ini buat tanggal trans di financial_trans
                datetimeBook = datetime_BookDate.Value.ToString("yyyy-MM-dd hh:mm:ss");

                int count = 1;
                string transid;
                dtFinanceDP = new DataTable();
                sqlQuery = "select * from financial_transaction";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtFinanceDP);

                //ini buat id trans di financial_trans
                string yearbookdate = datetime_BookDate.Value.ToString("yy");
                string monthbookdate = datetime_BookDate.Value.ToString("MM");
                string daybookdate = datetime_BookDate.Value.ToString("dd");

                transid = "TDP" + yearbookdate + monthbookdate + daybookdate;

                bool found = false;
                for (int j = 0; j < dtFinanceDP.Rows.Count; j++)
                {
                    if (tb_RegistHomeBookID.Text == dtFinanceDP.Rows[j][1].ToString())
                    {
                        indeks = j;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    for (int i = 0; i < dtFinanceDP.Rows.Count; i++)
                    {
                        string IDTrans = dtFinanceDP.Rows[i][0].ToString().Substring(0, 9);
                        //MessageBox.Show(IDTrans);
                        if (IDTrans == transid)
                        {
                            count++;
                        }
                    }

                    //count++;
                    if (count < 10)
                    {
                        transIDNew = transid + "0" + count;
                        //MessageBox.Show("trans ID " + transIDNew);
                    }
                    else if (count < 100)
                    {
                        transIDNew = transid + count;
                        //MessageBox.Show("trans ID " + transIDNew);
                    }
                }
                else
                {
                    transIDNew = dtFinanceDP.Rows[indeks][0].ToString();
                    //MessageBox.Show(dtFinanceDP.Rows[indeks][0].ToString());
                }

            }
            else
            {
                datetime_BookDate.Value = DateTime.Now;
            }
            //MessageBox.Show(transIDNew);
        }

        private void btn_RegisterationHomestaySave_Click(object sender, EventArgs e)
        {
            if (tb_RegistHomeBookID.Text.Length > 0 && tb_RegistHomeID.Text.Length > 0 && tb_RegistHomeGuestID.Text.Length > 0 && staffID.Length > 0
                && datetimeBook != null && tb_RegistHomeTotalFee2.Text.Length > 0 && datetimecin.Length > 0 && datetimecout.Length > 0)
            {
                if (datetime_cout.Value == datetime_cin.Value)
                {
                    MessageBox.Show("Failed! Date check in can't be the same as date check out");
                }
                else
                {
                    sqlCommand = sqlConnect.CreateCommand();
                    string sqlQuerybookinfo = "INSERT INTO booking_information VALUES (@bookID, @homeID, @staffID, @guestID, @bookTgl, @bookTotal, @bookTglCin, @bookTglCout, @status_del)";

                    sqlCommand.CommandText = sqlQuerybookinfo;
                    sqlConnect.Open();
                    sqlCommand.Parameters.AddWithValue("@bookID", tb_RegistHomeBookID.Text);
                    sqlCommand.Parameters.AddWithValue("@homeID", tb_RegistHomeID.Text);
                    sqlCommand.Parameters.AddWithValue("@guestID", tb_RegistHomeGuestID.Text);
                    sqlCommand.Parameters.AddWithValue("@staffID", tb_RegistHomeStaffID.Text);
                    sqlCommand.Parameters.AddWithValue("@bookTgl", datetimeBook);
                    sqlCommand.Parameters.AddWithValue("@bookTotal", tb_RegistHomeTotalFee2.Text);
                    sqlCommand.Parameters.AddWithValue("@bookTglCin", datetimecin);
                    sqlCommand.Parameters.AddWithValue("@bookTglCout", datetimecout);
                    sqlCommand.Parameters.AddWithValue("@status_del", "0");
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    dtHomeRegist = new DataTable();
                    string sqlQuery = "SELECT * FROM booking_information";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtHomeRegist);
                    dgv_RegistHomestay.DataSource = dtHomeRegist;


                    sqlCommand = sqlConnect.CreateCommand();
                    string sqlQueryfinancetrans = "INSERT INTO financial_transaction VALUES (@transID, @bookID, @transTgl, @transJmlByr, @transTipeByr, @transStatusByr, @transMetodByr, @statusDel)";
                    sqlCommand.CommandText = sqlQueryfinancetrans;
                    sqlConnect.Open();
                    sqlCommand.Parameters.AddWithValue("@transID", transIDNew);
                    sqlCommand.Parameters.AddWithValue("@bookID", tb_RegistHomeBookID.Text);
                    sqlCommand.Parameters.AddWithValue("@transTgl", datetimeBook);
                    sqlCommand.Parameters.AddWithValue("@transJmlByr", totalDP.ToString());
                    sqlCommand.Parameters.AddWithValue("@transTipeByr", "DP");
                    sqlCommand.Parameters.AddWithValue("@transStatusByr", "B");
                    sqlCommand.Parameters.AddWithValue("@transMetodByr", cbx_RegistHomeMetodeByr.Text);
                    sqlCommand.Parameters.AddWithValue("@statusDel", "0");
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Successfully Add New Booking");
                }
                tb_RegistHomeBookID.Text = "";
                tb_RegistHomeGuestID.Text = "";
                tb_RegistHomeID.Text = "";
                tb_RegistHomeStaffID.Text = "";
                tb_RegistHomeTotalFee.Text = "";
                cbx_RegistHomeMetodeByr.Text = "";
                datetime_cin.Text = DateTime.Now.ToString();
                datetime_cout.Text = DateTime.Now.ToString();
                datetime_BookDate.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all the column");
            }
            dgv_RegistHomestay.ClearSelection();
        }

        private void btn_dgvGuestID_Click(object sender, EventArgs e)
        {
            Table_Guest TG = new Table_Guest();
            TG.nama_staff(namastaff);
            TG.Show();
            this.Close();
        }

        private void btn_dgvHomeID_Click(object sender, EventArgs e)
        {
            Table_Homestay TH = new Table_Homestay();
            TH.nama_staff(namastaff);
            TH.Show();
            this.Close();
        }

        private void tb_RegistHomeID_TextChanged(object sender, EventArgs e)
        {
            //ini utk random staff
            btn_edit.Enabled = true;
            Random rnd = new Random();
            int random = rnd.Next(1, 20);
            if (random < 10)
            {
                staffID = "S0" + random.ToString();
                tb_RegistHomeStaffID.Text = staffID;
            }
            else
            {
                staffID = "S" + random.ToString();
                tb_RegistHomeStaffID.Text = staffID;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Data.selectedGuestID = "";
            Data.selectedHouseID = "";

            Data.metodebyr = "";
            Data.bookid = "";
            Data.guestid = "";
            Data.datebook = "";
            Data.datecin = "";
            Data.datecout = "";

            tb_RegistHomeBookID.Text = string.Empty;
            tb_RegistHomeID.Text = string.Empty;
            tb_RegistHomeGuestID.Text = string.Empty;
            tb_RegistHomeStaffID.Text= string.Empty;
            datetime_cin.Text = string.Empty;
            datetime_cout.Text = string.Empty;
            datetime_BookDate.Text = string.Empty; 
            tb_RegistHomeTotalFee.Text = string.Empty;
            tb_RegistHomeTotalFee2.Text = string.Empty;
            cbx_RegistHomeMetodeByr.Text = string.Empty;

            MainForm MF = new MainForm();
            MF.nama_staff(namastaff);
            MF.Show();
            this.Close();
        }
        int totalfee = 0;
        private void dgv_RegistHomestay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            indeks = 0;
            btn_dgvGuestID.Enabled = false;
            tb_RegistHomeGuestID.Enabled = false;
            datetime_BookDate.Enabled = false;
            datetime_cin.Enabled = false;
            datetime_cout.Enabled = false;
            btn_RegistrationHomestaySave.Enabled = false;
            btn_edit.Enabled = true;

            DataGridViewRow dgvrRegistHome = dgv_RegistHomestay.CurrentRow;
            tb_RegistHomeBookID.Text = dgvrRegistHome.Cells[0].Value.ToString();
            tb_RegistHomeID.Text = dgvrRegistHome.Cells[1].Value.ToString();
            tb_RegistHomeStaffID.Text = dgvrRegistHome.Cells[2].Value.ToString();
            tb_RegistHomeGuestID.Text = dgvrRegistHome.Cells[3].Value.ToString();
            datetime_BookDate.Text = dgvrRegistHome.Cells[4].Value.ToString();
            datetime_cin.Text = dgvrRegistHome.Cells[6].Value.ToString();
            datetime_cout.Text = dgvrRegistHome.Cells[7].Value.ToString();
            tb_RegistHomeTotalFee2.Text = dgvrRegistHome.Cells[5].Value.ToString();
            tb_RegistHomeTotalFee.Text = "Rp " + Convert.ToInt32(dgvrRegistHome.Cells[5].Value.ToString()).ToString("C2").Remove(0, 2);
            totalfee = Convert.ToInt32(dgvrRegistHome.Cells[5].Value.ToString());

            for (int i = 0; i < dtFinanceDP.Rows.Count; i++)
            {
                if (dtFinanceDP.Rows[i][1].ToString() == tb_RegistHomeBookID.Text)
                {
                    indeks = i;
                    break;
                }
            }
            cbx_RegistHomeMetodeByr.Text = dtFinanceDP.Rows[indeks][6].ToString();

            Data.metodebyr = dtFinanceDP.Rows[indeks][6].ToString();
            Data.bookid = dgvrRegistHome.Cells[0].Value.ToString();
            Data.guestid = dgvrRegistHome.Cells[3].Value.ToString();
            Data.datebook = dgvrRegistHome.Cells[4].Value.ToString();
            Data.datecin = dgvrRegistHome.Cells[6].Value.ToString();
            Data.datecout = dgvrRegistHome.Cells[7].Value.ToString();

            hi = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            hi = false;
            //update booking_information
            dtHomeRegist = new DataTable();
            sqlQuery = $"update booking_information " +
                $"set booking_id = '{tb_RegistHomeBookID.Text}', " +
                $"rumah_id = '{tb_RegistHomeID.Text}', " +
                $"guest_id = '{tb_RegistHomeGuestID.Text}', " +
                $"staff_id = '{tb_RegistHomeStaffID.Text}', " +
                $"booking_tgl = '{datetimeBook}', " +
                $"booking_total_biaya = '{tb_RegistHomeTotalFee2.Text}', " +
                $"booking_tgl_cin = '{datetimecin}', " +
                $"booking_tgl_cout = '{datetimecout}' " +
                $"where booking_id = '{tb_RegistHomeBookID.Text}'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            dtHomeRegist = new DataTable();
            sqlQuery = "SELECT * FROM booking_information";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHomeRegist);
            dgv_RegistHomestay.DataSource = dtHomeRegist;

            //update financial_transaction khusus DP sajhhh
            dtHomeRegist = new DataTable();
            sqlQuery = $"update financial_transaction " +
                $"set trans_id = '{transIDNew}', " +
                $"booking_id = '{tb_RegistHomeBookID.Text}', " +
                $"trans_tgl = '{datetimeBook}', " +
                $"trans_jml_bayar = '{totalDP.ToString()}', " +
                $"trans_tipe_bayar = 'DP', " +
                $"trans_status_bayar = 'B', " +
                $"trans_metode_bayar = '{cbx_RegistHomeMetodeByr.Text}' " +
                $"where booking_id = '{tb_RegistHomeBookID.Text}' and trans_tipe_bayar = 'DP';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //MessageBox.Show(transIDNew);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            MessageBox.Show("Successfully Update Booking");

            btn_RegistrationHomestaySave.Enabled = true;
            btn_dgvGuestID.Enabled = true;
            datetime_cin.Enabled = true;
            datetime_cout.Enabled = true;
            datetime_BookDate.Enabled = true;
            tb_RegistHomeGuestID.Text = "";
            tb_RegistHomeID.Text = "";
            tb_RegistHomeStaffID.Text = "";
            tb_RegistHomeTotalFee.Text = "";
            cbx_RegistHomeMetodeByr.Text = "";
            datetime_cin.Text = DateTime.Now.ToString();
            datetime_cout.Text = DateTime.Now.ToString();
            datetime_BookDate.Text = DateTime.Now.ToString();
            tb_RegistHomeBookID.Text = "";

            if (tb_RegistHomeGuestID.Text == "")
            {
                btn_edit.Enabled = false; 
            }
            dgv_RegistHomestay.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
