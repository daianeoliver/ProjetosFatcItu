using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Visualizador_comandos_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = @"provider = Microsoft.JET.OLEDB.4.0; " + "Data Source = c:\\Intel\\nwind.mdb";
try
            {
                myConn.Open();
                OleDbCommand sql = new OleDbCommand(textBox1.Text, myConn);
                OleDbDataAdapter da = new OleDbDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Sintaxe SQL!");
            }
            myConn.Close();
        }
    }
 
}
