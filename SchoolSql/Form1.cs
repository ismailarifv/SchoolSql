using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolSql
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-6I3C0B5\SQLEXPRESS;initial catalog= schoolDb;Integrated Security=True;");
        int SelectStudentId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentData();
            ClassesData();
        }
        public void StudentData()
        {
            db.Open();

            string sorgu = "select s.Id,c.Name as ClassName,s.Name,s.Surname,s.Age,s.Status from Students as s inner join Classes as c on(s.ClassesId=c.Id)";

            SqlCommand sqlCommand = new SqlCommand(sorgu,db);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;


            db.Close();
        }

        public void ClassesData()
        {
            db.Open();

            string sorgu2 = "select * from Classes where Status=1";

            SqlCommand sqlCommand2 = new SqlCommand(sorgu2,db);
            SqlDataAdapter sqlDataAdapter2= new SqlDataAdapter(sqlCommand2);

            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);

            classes_cmbx.DisplayMember = "Name";
            classes_cmbx.ValueMember = "Id";
            classes_cmbx.DataSource = dt2;

            updateClasses_cmbx.DisplayMember = "Name";
            updateClasses_cmbx.ValueMember = "Id";
            updateClasses_cmbx.DataSource = dt2;


            db.Close();
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            string Name = name_txt.Text;
            string Surname = surname_txt.Text;
            int Age = Convert.ToInt32(age_nupd.Value);
            int Status = Convert.ToBoolean(status_chkbx.Checked)==true ? 1 : 0;
            int ClassesId = Convert.ToInt32(classes_cmbx.SelectedValue);

            db.Open();
            string sorgu3 = $"Insert into Students(ClassesId, Name,Surname,Age,Status) Values({ClassesId},'{Name}','{Surname}',{Age},{Status}) ";

            SqlCommand sqlCommand3 = new SqlCommand(sorgu3, db);
            sqlCommand3.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Eklendi");

            db.Close();
            StudentData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateName_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateSurname_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateAge_nudp.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            updateStatus_chbx.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
            updateClasses_cmbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SelectStudentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            delete_lbl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString()+" "+ dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            string Name = updateName_txt.Text;
            string Surname = updateSurname_txt.Text;
            int Age = Convert.ToInt32(updateAge_nudp.Value);
            int Status = Convert.ToBoolean(updateStatus_chbx.Checked) == true ? 1 : 0;
            int ClassesId = Convert.ToInt32(updateClasses_cmbx.SelectedValue);

            db.Open();
            string sorgu = $"Update Students set ClassesId={ClassesId},Name='{Name}',Surname='{Surname}',Age={Age},Status={Status} where Id={SelectStudentId}";

            SqlCommand sqlCommand = new SqlCommand(sorgu, db);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Güncellendi");

            db.Close();
            SelectStudentId = 0;
            updateName_txt.Clear();
            updateSurname_txt.Clear();
            updateAge_nudp.Value = 0;
            updateStatus_chbx.Checked = false;
            StudentData();
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            //db.Open();
            //string sorgu = $"Delete from Students where Id={SelectStudentId}";
            //SqlCommand sqlCommand = new SqlCommand(sorgu,db);
            //sqlCommand.ExecuteNonQuery();
            //MessageBox.Show("Öğrenci silindi");



            //db.Close();


            db.Open();
            SqlCommand sqlCommand = new SqlCommand("DeleteUser", db);//Stroed Procedure Kullanımı
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("StudentId", SqlDbType.Int).Value = SelectStudentId;
            
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Öğrenci silindi");
            db.Close();
            StudentData();
            SelectStudentId = 0;
            updateName_txt.Clear();
            updateSurname_txt.Clear();
            updateAge_nudp.Value = 0;
            updateStatus_chbx.Checked = false;
            delete_lbl.Text = "0";
        }
    }
}
