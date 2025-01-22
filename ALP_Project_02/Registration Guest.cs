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
using System.Xml.Linq;

namespace ALP_Project_02
{
    public partial class Registration_Guest : Form
    {
        public Registration_Guest()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtGuestRegist;
        string idguestnew;
        string birthdayGuest;
        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void Registration_Guest_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtGuestRegist = new DataTable();
            sqlQuery = "SELECT * FROM guest_information";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtGuestRegist);
            dgv_RegistrationGuest.DataSource = dtGuestRegist;
            dgv_RegistrationGuest.ClearSelection();
        }

        private void btn_RegisterationGuestSave_Click(object sender, EventArgs e)
        {
            if (tb_IDG.Text.Length > 0 && tb_RegistGuestNIK.Text.Length > 0 && tb_RegistGuestName.Text.Length > 0 && birthdayGuest != null && cbx_RegistGuestGender.Text.Length > 0
                && tb_RegistGuestPhone.Text.Length > 0 && tb_RegistGuestEmail.Text.Length > 0 && tb_RegistGuestAddress.Text.Length > 0 && tb_RegistGuestNationality.Text.Length > 0)
            {
                if (tb_RegistGuestNIK.Text.Length == 16 && tb_RegistGuestPhone.Text.Length == 12)
                {
                    sqlCommand = sqlConnect.CreateCommand();
                    sqlQuery = "INSERT INTO guest_information VALUES (@idG, @NIKG, @nameG, @birthdayG, @genderG, @phoneG, @emailG, @addressG, @nationalityG, @status_del)";
                    sqlCommand.CommandText = sqlQuery;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@idG", tb_IDG.Text);
                    sqlCommand.Parameters.AddWithValue("@NIKG", tb_RegistGuestNIK.Text);
                    sqlCommand.Parameters.AddWithValue("@nameG", tb_RegistGuestName.Text);
                    sqlCommand.Parameters.AddWithValue("@birthdayG", birthdayGuest);
                    sqlCommand.Parameters.AddWithValue("@genderG", cbx_RegistGuestGender.Text);
                    sqlCommand.Parameters.AddWithValue("@phoneG", tb_RegistGuestPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@emailG", tb_RegistGuestEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@addressG", tb_RegistGuestAddress.Text);
                    sqlCommand.Parameters.AddWithValue("@nationalityG", tb_RegistGuestNationality.Text);
                    sqlCommand.Parameters.AddWithValue("@status_del", "0");
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    dtGuestRegist = new DataTable();
                    sqlQuery = "SELECT * FROM guest_information";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtGuestRegist);
                    dgv_RegistrationGuest.DataSource = dtGuestRegist;

                    MessageBox.Show("Successfully Add New Guest");
                    tb_IDG.Text = "";
                    tb_RegistGuestNIK.Text = "";
                    tb_RegistGuestName.Text = "";
                    datetime_BirthGuest.Value = DateTime.Now;
                    cbx_RegistGuestGender.Text = "";
                    tb_RegistGuestPhone.Text = "";
                    tb_RegistGuestEmail.Text = "";
                    tb_RegistGuestAddress.Text = "";
                    tb_RegistGuestNationality.Text = "";
                    cbx_RegistGuestGender.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Incorrect NIK or Phone Number");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the column");
            }
            dgv_RegistrationGuest.ClearSelection();
        }

        private void tb_RegistGuestName_TextChanged(object sender, EventArgs e)
        {

            if (tb_RegistGuestName.Text.Length > 0)
            {
                int count = 0;

                for (int i = 0; i < dtGuestRegist.Rows.Count; i++)
                {
                    if (tb_RegistGuestName.Text.ToUpper().Substring(0, 1) == dtGuestRegist.Rows[i][0].ToString().ToUpper().Substring(1, 1))
                    {
                        count++;
                    }
                }
                count++;
                if (count < 10)
                {
                    idguestnew = $"G{tb_RegistGuestName.Text.ToUpper().Substring(0, 1)}000{count}";
                    tb_IDG.Text = idguestnew;
                }
                else if (count < 100)
                {
                    idguestnew = $"G{tb_RegistGuestName.Text.ToUpper().Substring(0, 1)}00{count}";
                    tb_IDG.Text = idguestnew;
                }
            }
        }

        private void dgv_RegistrationGuest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datetime_BirthGuest_ValueChanged(object sender, EventArgs e)
        {
            birthdayGuest = datetime_BirthGuest.Value.ToString("yyyy-MM-dd");
        }

        private void btn_RegistrationGuestBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.nama_staff(namastaff);
            mainForm.Show();
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_IDG.Text.Length > 0 && tb_RegistGuestNIK.Text.Length > 0 && tb_RegistGuestName.Text.Length > 0 && birthdayGuest != null && cbx_RegistGuestGender.Text.Length > 0
               && tb_RegistGuestPhone.Text.Length > 0 && tb_RegistGuestEmail.Text.Length > 0 && tb_RegistGuestAddress.Text.Length > 0 && tb_RegistGuestNationality.Text.Length > 0)
            {
                if (tb_RegistGuestNIK.Text.Length == 16 && tb_RegistGuestPhone.Text.Length == 12)
                {
                    try
                    {
                        sqlCommand = sqlConnect.CreateCommand();
                        sqlQuery = $"UPDATE guest_information SET " +
                                $"guest_nik = '{tb_RegistGuestNIK.Text}', " +
                                $"guest_nama = '{tb_RegistGuestName.Text}', " +
                                $"guest_tgl_lhr = '{birthdayGuest}', " +
                                $"guest_gender = '{cbx_RegistGuestGender.Text}', " +
                                $"guest_notelp = '{tb_RegistGuestPhone.Text}', " +
                                $"guest_email = '{tb_RegistGuestEmail.Text}', " +
                                $"guest_alamat = '{tb_RegistGuestAddress.Text}', " +
                                $"guest_kewarganegaraan = '{tb_RegistGuestNationality.Text}' " +
                                $"WHERE guest_id = '{tb_IDG.Text}';";
                        sqlCommand.CommandText = sqlQuery;
                        sqlCommand.Parameters.Clear();
                        sqlConnect.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();

                        if (rowsAffected > 0)
                        {

                            dtGuestRegist.Clear();
                            sqlQuery = "SELECT * FROM guest_information";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                            sqlDataAdapter.Fill(dtGuestRegist);
                            dgv_RegistrationGuest.DataSource = dtGuestRegist;
                            btn_edit.Enabled = false;
                            btn_RegisterationGuestSave.Enabled = true;
                            tb_RegistGuestName.Enabled = true;
                            tb_RegistGuestNIK.Enabled = true;
                            datetime_BirthGuest.Enabled = true;
                            cbx_RegistGuestGender.SelectedIndex = -1;
                            cbx_RegistGuestGender.Enabled = true;
                            tb_RegistGuestPhone.Enabled = true;
                            tb_RegistGuestEmail.Enabled = true;
                            tb_RegistGuestAddress.Enabled = true;
                            tb_RegistGuestNationality.Enabled = true;
                            MessageBox.Show("Guest information updated successfully");
                        }
                        tb_IDG.Text = "";
                        tb_RegistGuestNIK.Text = "";
                        tb_RegistGuestName.Text = "";
                        datetime_BirthGuest.Value = DateTime.Now;
                        cbx_RegistGuestGender.Text = "";
                        tb_RegistGuestPhone.Text = "";
                        tb_RegistGuestEmail.Text = "";
                        tb_RegistGuestAddress.Text = "";
                        tb_RegistGuestNationality.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            dgv_RegistrationGuest.ClearSelection();
        }

        private void dgv_RegistrationGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_edit.Enabled = true;
            btn_RegisterationGuestSave.Enabled = false;
            tb_RegistGuestName.Enabled = false;
            tb_RegistGuestNIK.Enabled = false;
            datetime_BirthGuest.Enabled = false;
            cbx_RegistGuestGender.Enabled = false;
            tb_RegistGuestPhone.Enabled = true;
            tb_RegistGuestEmail.Enabled = true;
            tb_RegistGuestAddress.Enabled = true;
            tb_RegistGuestNationality.Enabled = true;

            if (e.RowIndex >= 0) //PINDAH INFO KE TB
            {
                DataGridViewRow dgvrRegistGuest = dgv_RegistrationGuest.Rows[e.RowIndex];
                string selectedGuestID = dgvrRegistGuest.Cells[0].Value.ToString();
                tb_RegistGuestName.TextChanged -= tb_RegistGuestName_TextChanged;
                tb_IDG.Text = dgvrRegistGuest.Cells[0].Value.ToString();
                tb_RegistGuestNIK.Text = dgvrRegistGuest.Cells[1].Value.ToString();
                tb_RegistGuestName.Text = dgvrRegistGuest.Cells[2].Value.ToString();
                datetime_BirthGuest.Value = DateTime.Parse(dgvrRegistGuest.Cells[3].Value.ToString());
                cbx_RegistGuestGender.Text = dgvrRegistGuest.Cells[4].Value.ToString();
                tb_RegistGuestPhone.Text = dgvrRegistGuest.Cells[5].Value.ToString();
                tb_RegistGuestEmail.Text = dgvrRegistGuest.Cells[6].Value.ToString();
                tb_RegistGuestAddress.Text = dgvrRegistGuest.Cells[7].Value.ToString();
                tb_RegistGuestNationality.Text = dgvrRegistGuest.Cells[8].Value.ToString();
                tb_RegistGuestName.TextChanged += tb_RegistGuestName_TextChanged;
            }
        }

        private void tb_RegistGuestNIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
            if (tb_RegistGuestNIK.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_RegistGuestPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; 

            if (tb_RegistGuestPhone.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_RegistGuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
