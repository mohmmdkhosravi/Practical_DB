using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Practical_DB
{
    public partial class Genes : Form
    {
        private string connection =
            "Data Source=DESKTOP-DPI542O\\SQLSERVER2019;Initial Catalog=Biological_DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private DataSet storage = new DataSet();
        private SqlDataAdapter dataTransfer = new SqlDataAdapter();

        public Genes()
        {
            InitializeComponent();
        }

        private void Genes_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connect = new SqlConnection(connection);
            dataTransfer.InsertCommand = new SqlCommand(
                "Insert into Genes values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",
                connect
            );

            dataTransfer.InsertCommand.Parameters.AddWithValue("@p1", textBox1.Text);
            dataTransfer.InsertCommand.Parameters.AddWithValue("@p2", textBox2.Text);
            dataTransfer.InsertCommand.Parameters.AddWithValue("@p3", textBox3.Text);
            dataTransfer.InsertCommand.Parameters.AddWithValue("@p4", textBox4.Text);
            dataTransfer.InsertCommand.Parameters.AddWithValue("@p5", textBox5.Text);
            dataTransfer.InsertCommand.Parameters.AddWithValue("@p6", textBox6.Text);
            dataTransfer.InsertCommand.Parameters.AddWithValue("@p7", textBox7.Text);
            connect.Open();
            dataTransfer.InsertCommand.ExecuteNonQuery();
            connect.Close();
        }
    }
}
