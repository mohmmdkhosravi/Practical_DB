using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practical_DB
{
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();
        }
        public string connection =
            "Data Source=DESKTOP-DPI542O\\SQLSERVER2019;Initial Catalog=Biological_DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public DataSet storage = new DataSet();
        public SqlDataAdapter dataTransfer = new SqlDataAdapter();


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connection);
            

            string[] context = File.ReadAllLines(textBox1.Text);
            progressBar1.Maximum = context.Length;

            for (int i = 1; i < context.Length; i++)
            {
                string[] fields = context[i].Split('\t');
                //MessageBox.Show(fields.Length.ToString());
                dataTransfer.InsertCommand = new SqlCommand(
                    "Insert into Genes values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",
                    connect
                );
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p1", fields[0]);
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p2", fields[1]);
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p3", fields[3]);
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p4", fields[4]);
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p5", fields[6]);
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p6", fields[2]);
                dataTransfer.InsertCommand.Parameters.AddWithValue("@p7", fields[5]);
                connect.Open();
                dataTransfer.InsertCommand.ExecuteNonQuery();
                connect.Close();
                progressBar1.Value = i;
                Application.DoEvents();
            }
        }
    }
}
