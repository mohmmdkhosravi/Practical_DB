using System.Data;
using Practical_DB;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Practical_DB
{
    public partial class Form1 : Form
    {
        public string connection =
            "Data Source=DESKTOP-DPI542O\\SQLSERVER2019;Initial Catalog=Biological_DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public DataSet storage = new DataSet();
        public SqlDataAdapter dataTransfer = new SqlDataAdapter();

        public void Refreshh()
        {
            storage.Clear();
            SqlConnection connect = new SqlConnection(connection);
            dataTransfer.SelectCommand = new SqlCommand(
                "select * from Genes",
                connect
            );
            dataTransfer.Fill(storage);
            dataGridView1.DataSource = storage.Tables[0];
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Genes_btn(object sender, EventArgs e)
        {
            Genes genesForm = new Genes();
            genesForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refreshh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refreshh();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Batch b =new Batch();
            b.ShowDialog();

        }
    }
}
