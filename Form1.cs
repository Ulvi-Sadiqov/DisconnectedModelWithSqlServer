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

namespace DisconnectModel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
		DataTable tbl = null;
		SqlDataAdapter adapter = null;
		private void button1_Click_1(object sender, EventArgs e)
		{
			 adapter
				= new SqlDataAdapter("SELECT * FROM People"
				, "Data Source=.;Initial Catalog=FirstDb;Integrated Security=SSPI;");
			 tbl = new DataTable();
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
			adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
			adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
			adapter.InsertCommand = commandBuilder.GetInsertCommand();

			adapter.Fill(tbl);
			dataGridView1.DataSource = tbl;
			adapter.Dispose();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			adapter.Update(tbl);
		}
	}
}
