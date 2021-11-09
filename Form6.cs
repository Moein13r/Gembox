using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsApp_TamrinA_
{
    public partial class Form6 : Form
    {
        MySqlConnection sqlconn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter dta = new MySqlDataAdapter();
        DataSet Ds = new DataSet();
        MySqlDataReader sqlRd;
        string server = "localhost";
        string username = "root";
        string Password = "";
        string database = "test";
        private PictureBox title = new PictureBox();
        private Button close = new Button();
        public Form6()
        {
            InitializeComponent();
        }
        private void uploadData()
        {
            sqlconn.ConnectionString = "server=" + server + ";" + "port=" + "3307" + ";" + "username=" + username + ";" + "password=" + Password+ ";"+"database=" + database;
            sqlconn.Open();
            sqlCmd.Connection=sqlconn;
            sqlCmd.CommandText = "SELECT * FROM school";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlconn.Close();
            dataGridView1.DataSource = sqlDt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                firsname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                surname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                adress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                postcode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Email.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Bitmap f = new Bitmap("C:\\Users\\pc\\source\\repos\\WindowsApp TamrinA_\\WindowsApp TamrinA_\\Bitmap1.bmp");
            Point p=new Point();
            p.Y = 0;
            p.X = 0;
            this.title.Width = this.Width;
            this.title.Height = 20;
            this.BackColor = Color.Black;
            this.close.Image = f;
            this.close.Width = 35;
            this.Controls.Add(this.close);
            this.Controls.Add(this.title);
            this.close.BringToFront();
            this.close.Location = new Point(800,0);
            this.close.Click += new System.EventHandler(this.closebtn);
            uploadData();
        }
        private void closebtn(object sender,EventArgs e)
        {
            Application.Exit();
        }
        private void form_sizechange(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult ad=new DialogResult();
                ad=MessageBox.Show("Exit?","connector",MessageBoxButtons.YesNo,MessageBoxIcon.Question);  
                if (ad == DialogResult.Yes)
                Application.Exit();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                throw;
            }

        }

        private void Btnprint_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.ConnectionString = "server=" + server + ";" + "port=" + "3307" + ";" + "username=" + username + ";" + "password=" + Password + ";" + "database=" + database;

            try
            {
                sqlconn.Open();
                sqlQuery = "insert into school values('"+id.Text+"','"+firsname.Text+"','"+surname.Text+"','"+adress.Text+"','"+postcode.Text+"','"+Email.Text+"')";
                sqlCmd = new MySqlCommand(sqlQuery, sqlconn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlconn.Close();               
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlconn.Close();
            }
            panel4.Refresh();
            uploadData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void update_Click(object sender, EventArgs e)
        {
            
            sqlconn.ConnectionString = "server=" + server + ";" + "port=" + "3307" + ";" + "username=" + username + ";" + "password=" + Password + ";" + "database=" + database;
            sqlconn.Open();
            try
            {
                MySqlCommand sqlcmd = new MySqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "update test.school set id = @id, firstName = @firstName, surName = @surName, Adress = @Adress, postCode = @postCode, Email = @Email where id = @id";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@id", id.Text);
                sqlcmd.Parameters.AddWithValue("@firstName", firsname.Text);
                sqlcmd.Parameters.AddWithValue("@surName", surname.Text);
                sqlcmd.Parameters.AddWithValue("@Adress", adress.Text);
                sqlcmd.Parameters.AddWithValue("@postCode", postcode.Text);       
                sqlcmd.Parameters.AddWithValue("@Email", emailbox.Text);

                sqlcmd.ExecuteNonQuery();             
                sqlconn.Close();
                uploadData();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlconn.Close();
            }
            panel4.Refresh();
            
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                firsname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                surname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                adress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                postcode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                emailbox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlconn.ConnectionString = "server=" + server + ";" + "port=" + "3307" + ";" + "username=" + username + ";" + "password=" + Password + ";" + "database=" + database;
            sqlconn.Open();
            sqlCmd.Connection = sqlconn;
            sqlCmd.CommandText = "delete from test.school where id=@i";
            sqlCmd.Parameters.AddWithValue("@i",id.Text);
            sqlCmd.ExecuteNonQuery();
            sqlconn.Close();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            uploadData();
        }

        private void key_press(object sender, KeyPressEventArgs e)
        {
        }
    }
}
