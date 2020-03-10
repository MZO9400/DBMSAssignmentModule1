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

namespace DBMSAssignmentModule1 {
	public partial class Form1 : Form {
		public Form1() {
            this.InitializeComponent();
            this.m_fillCombo();
		}

		private void dataGridView1_CellContentClick(Object sender, DataGridViewCellEventArgs e) {

		}

        private void comboBox1_SelectedIndexChanged(Object sender, EventArgs e) {
            try {
                using (SqlConnection connection = new SqlConnection(DBMS.ConnectionString.getConnectionString())) {
                    connection.Open();
                    String cmdstr = "Use DBMS; SELECT * FROM " + this.comboBox1.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmdstr, connection);
                    DataTable dt = new DataTable();
                    _ = sda.Fill(dt);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    this.dataGridView1.DataSource = dt;
                    bs.ResetBindings(true);
                }

            }
            catch (Exception ex) {
                _ = MessageBox.Show(ex.Message);
            }
        }

        void m_fillCombo() {
            String cmdstr = "Use DBMS; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, DBMS.ConnectionString.getConnectionString());
            try {
                _ = sda.Fill(dt);
                foreach (DataRow row in dt.Rows) {

                    _ = this.comboBox1.Items.Add(row["TABLE_NAME"]);
                }
            }
            catch (Exception ex) {
                _ = MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(Object sender, EventArgs e) {
        }
    }
}
