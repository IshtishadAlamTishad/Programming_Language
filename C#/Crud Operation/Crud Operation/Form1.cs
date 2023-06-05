using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace Curd_Operation
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=T7\\SQLEXPRESS;Initial Catalog=info;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getStudentRecord();
        }
        string Gender;
        public int StudentID;
        private void getStudentRecord()
        {
            SqlCommand cmd = new SqlCommand("select * from StudentTB", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            cn.Close();
            StudentDataGridView.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cd = new SqlCommand("insert into StudentTB values (@name,@mother_name,@father_name,@birthDate,@gender,@mobile_Num,@Address,@Religion,@Nationality)", cn);
                    cd.CommandType = CommandType.Text;
                    cd.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cd.Parameters.AddWithValue("@mother_name", txtMotherName.Text);
                    cd.Parameters.AddWithValue("@father_name", txtFatherName.Text);
                    cd.Parameters.AddWithValue("@birthDate", BirthDatePicker.Text);
                    cd.Parameters.AddWithValue("@gender", Gender);
                    cd.Parameters.AddWithValue("@mobile_Num", txtMobileNumber.Text);
                    cd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cd.Parameters.AddWithValue("@Religion", txtReligion.Text);
                    cd.Parameters.AddWithValue("@Nationality", txtNationality.Text);
                    cn.Open();
                    cd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New Student inserted into database Successfully", "Insert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getStudentRecord();
                    ResetFunc();
                }
            }
            catch (Exception eb1)
            {
                MessageBox.Show(eb1.Message);
            }
        }

        private bool isValid()
        {
            if (txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StudentID = Convert.ToInt32(StudentDataGridView.SelectedRows[0].Cells[0].Value);
                txtStudentName.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                txtMotherName.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString(); ;
                txtFatherName.Text = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString(); ;
                BirthDatePicker.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString(); ;
                Gender = StudentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                txtMobileNumber.Text = StudentDataGridView.SelectedRows[0].Cells[6].Value.ToString(); ;
                txtAddress.Text = StudentDataGridView.SelectedRows[0].Cells[7].Value.ToString(); ;
                txtReligion.Text = StudentDataGridView.SelectedRows[0].Cells[8].Value.ToString(); ;
                txtNationality.Text = StudentDataGridView.SelectedRows[0].Cells[9].Value.ToString(); ;
            }
            catch (Exception eg)
            {
                MessageBox.Show(eg.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Other";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ResetFunc();
        }
        private void ResetFunc()
        {
            StudentID = 0;
            txtStudentName.Clear();
            txtMotherName.Clear();
            txtFatherName.Clear();
            BirthDatePicker.ResetText();
            Gender = "";
            txtAddress.Clear();
            txtMobileNumber.Clear();
            txtReligion.Clear();
            txtNationality.Clear();
            txtStudentName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentID > 0)
                {
                    SqlCommand cd = new SqlCommand("update StudentTB set Student_Name = @name,Mother_Name = @mother_name,Father_Name = @father_name,Birth_Date = @birthDate,Gender = @gender,Mobile_Number = @mobile_Num,Address = @Address,Religion = @Religion,Nationality = @Nationality where StudentID = @Id", cn);
                    cd.CommandType = CommandType.Text;
                    cd.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cd.Parameters.AddWithValue("@mother_name", txtMotherName.Text);
                    cd.Parameters.AddWithValue("@father_name", txtFatherName.Text);
                    cd.Parameters.AddWithValue("@birthDate", BirthDatePicker.Text);
                    cd.Parameters.AddWithValue("@gender", Gender);
                    cd.Parameters.AddWithValue("@mobile_Num", txtMobileNumber.Text);
                    cd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cd.Parameters.AddWithValue("@Religion", txtReligion.Text);
                    cd.Parameters.AddWithValue("@Nationality", txtNationality.Text);
                    cd.Parameters.AddWithValue("@Id", this.StudentID);
                    cn.Open();
                    cd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Student Information Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getStudentRecord();
                    ResetFunc();
                }
                else
                {
                    MessageBox.Show("Please select student to update information", "Select!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception eb)
            {
                MessageBox.Show(eb.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentID > 0)
                {
                    SqlCommand cd = new SqlCommand("delete from StudentTB where StudentID = @Id", cn);
                    cd.CommandType = CommandType.Text;
                    cd.Parameters.AddWithValue("@Id", this.StudentID);
                    cn.Open();
                    cd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Student Information deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getStudentRecord();
                    ResetFunc();
                }
                else
                {
                    MessageBox.Show("Please select student to delete information", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult it;
                it = MessageBox.Show("Confirm Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (it == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}