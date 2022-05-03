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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb1 where Name like '%" + textBox1.Text + "%' and Family like '%" + textBox2.Text + "%'and Code like '%" + textBox3.Text + "%'", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
           SqlCommand sqlcmd = new SqlCommand("insert into tb1(Name,Family,Code) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')",con);
            sqlcmd.ExecuteNonQuery();
            con.Close();
           MessageBox.Show("اطلاعات شما با موفقیت ثبت شد"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            con.Open();
            sqlcmd.CommandText = ("delete from tb1 where Userid=@userid");
            sqlcmd.Parameters.AddWithValue("@userid", textBox1.Tag);
            sqlcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("اطلاعات مورد نظر با موفقیت حذف شد");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            con.Open();
            sqlcmd.CommandText=("update tb1 set Name=@name,Family=@family,Code=@code where Userid=@userid");
            sqlcmd.Parameters.AddWithValue("@name",textBox1.Text);
            sqlcmd.Parameters.AddWithValue("@family", textBox2.Text);
            sqlcmd.Parameters.AddWithValue("@code", textBox3.Text);
            sqlcmd.Parameters.AddWithValue("@userid", textBox1.Tag);
            sqlcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("اطلاعات مورد نظر با موفقیت ویرایش شد");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from  tb1",con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Tag = dataGridView1.CurrentRow.Cells[0].Value;
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
