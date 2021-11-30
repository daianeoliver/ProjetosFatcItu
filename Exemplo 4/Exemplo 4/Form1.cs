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

namespace Exemplo_4
{
    public partial class Form1 : Form
    { 
        BindingSource bs = new BindingSource();
    
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = c:/ intel / fateccinema.accdb");

            try
            {
                //abre a conexão
                myConn.Open();
                //define o comando sql para selecionar os dados das tabela Clientes
                OleDbCommand sql = new OleDbCommand("SELECT * from Filme", myConn);
                //cria um adapter para preencher um dataset
                OleDbDataAdapter da = new OleDbDataAdapter(sql);
                //define um objeto DataSet
                DataSet ds = new DataSet();
                da.Fill(ds);
                //atribui o dataset ao DataSource do BindingSource
                bs.DataSource = ds;
                //atribui o BindingSource ao BindingNavigator
                bs.DataMember = ds.Tables[0].TableName;
                //Atribui o BindingSource ao DataGridView
                dataGridView1.DataSource = bs;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao obter os dados.");
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}
