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

namespace Via_código
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conecta ao BD Northwind
            // para access 2016 use ACE.OLEDB.12.0
            string connectionString = "provider=Microsoft.JET.OLEDB.4.0;" + "data source = c:\\intel\\nwind.mdb";
//recebe registros da tabela clientes
string commandString = "select companyName, ContactName from customers";
            //cria o objeto de comando dataset e o dataset
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(commandString,
            connectionString);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "Customers");
            //receber a única tabela do Dataset
            DataTable dataTable = DataSet.Tables[0];
            //para cada linha na tabela, exibe a informacao
            foreach (DataRow dataRow in dataTable.Rows)
            {
                listBox1.Items.Add(dataRow["CompanyName"] + " (" +
                dataRow["Contactname"] + ")");
            }
        }
    }
}
