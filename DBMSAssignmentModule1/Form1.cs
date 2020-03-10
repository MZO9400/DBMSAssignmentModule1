using System;
using System.Data;
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
                    this.dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex) {
                _ = MessageBox.Show(ex.Message);
            }
        }

        void m_fillCombo() {
            String cmdstr = "Use DBMS; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME NOT IN ('SYSDIAGRAMS')";
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

        private void RUN_Click(Object sender, EventArgs e) {
            if (this.richTextBox1.Text.Length <= 0) {
                _ = MessageBox.Show("QUERY IS EMPTY", "ERROR!");
                return;
            }
            if (this.textBox1.Text != "61qz+AW<b]<sSCC9") {
                _ = MessageBox.Show("INVALID PASSWORD", "ERROR!");
                return;
            }
            using (SqlConnection connection = new SqlConnection(DBMS.ConnectionString.getConnectionString())) {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Use DBMS; " + this.richTextBox1.Text, connection);
                DataTable dt = new DataTable();
                try {
                    _ = adapter.Fill(dt);
                    this.dataGridView2.DataSource = dt;
                }
                catch (Exception ex) {
                    _ = MessageBox.Show(ex.Message, "MALFORMED QUERY");
                }
            }
        }
    }
}
