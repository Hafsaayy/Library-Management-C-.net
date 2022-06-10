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

namespace books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookcode;
            string booktitle;
            string bookauther;
            string bookpublisher;
            
            bookcode = int.Parse(textBox1.Text);
            booktitle = textBox2.Text;
            bookauther = textBox3.Text;
            bookpublisher = textBox4.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=HAFSA-LAPTOP\\SQLEXPRESS01;DataBase=books;Integrated Security=SSPI";
            con.Open();

            Console.WriteLine("Connected");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into book2(bookcode,booktitle,bookauther,bookpublisher) values('"+bookcode+"','"+booktitle+"','"+bookauther+"','"+bookpublisher+"');";
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Inserted");

            }
            else if (i == 0)
            {
                MessageBox.Show("Not Inserted");
            }
        }

      /*  private void button2_Click(object sender, EventArgs e)
        {
            string cs = "data source=DESKTOP-GDGP66J\\SQLEXPRESS;DataBase=books;Integrated Security=true";
            SqlConnection con1 = new SqlConnection();
            string query = "select *from book2";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1; 
            cmd1.CommandText = query;
            con1.Open();
            SqlDataReader rdr = cmd1.ExecuteReader();
            if(rdr.HasRows)
            {
                while(rdr.Read())
                {
                    listBox1.Items.Add(rdr[""])
                }
            }
        }*/
    }
}
