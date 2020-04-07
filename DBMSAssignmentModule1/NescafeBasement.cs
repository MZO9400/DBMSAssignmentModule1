using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMSAssignmentModule1 {
	public partial class NescafeBasement : Form {
		public NescafeBasement() {
            this.InitializeComponent();
            this.m_fillCombo();
            this.richTextBox1.Text = @"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME NOT IN ('SYSDIAGRAMS')";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                using (SqlConnection connection = new SqlConnection(Proprietary.getConnectionString())) {
                    connection.Open();
                    string cmdstr = "SELECT * FROM " + this.comboBox1.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmdstr, connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_fillCombo() {
            const string cmdstr = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME NOT IN ('SYSDIAGRAMS')";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, Proprietary.getConnectionString());
            try {
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row != null) this.comboBox1.Items.Add(row["TABLE_NAME"]);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e) {
        }
        private bool m_checkPassword() {
            return this.textBox1.Text != Proprietary.getPassword();
        }

        private void RUN_Click(object sender, EventArgs e) {
            if (this.richTextBox1.Text.Length <= 0) {
                MessageBox.Show(@"QUERY IS EMPTY", @"ERROR!");
                return;
            }
            if (this.m_checkPassword()) {
                MessageBox.Show(@"INVALID PASSWORD", @"ERROR!");
                return;
            }
            using (SqlConnection connection = new SqlConnection(Proprietary.getConnectionString())) {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(this.richTextBox1.Text, connection);
                DataTable dt = new DataTable();
                try {
                    adapter.Fill(dt);
                    this.dataGridView2.DataSource = dt;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, @"MALFORMED QUERY");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection(Proprietary.getConnectionString())) {
                try {
                    connection.Open();
                    string cmdstr = "SELECT * FROM [dbo].[" + this.comboBox1.Text + "]";
                    SqlDataAdapter sda = new SqlDataAdapter(cmdstr, connection);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
                    sda.InsertCommand = cmd.GetInsertCommand();
                    sda.DeleteCommand = cmd.GetDeleteCommand();
                    sda.UpdateCommand = cmd.GetUpdateCommand();
                    sda.Update((DataTable) this.dataGridView1.DataSource);
                }
                catch (Exception err) {
                    MessageBox.Show(err.ToString(), @"ERROR");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
                try {
                    using (SqlConnection connection = new SqlConnection(Proprietary.getConnectionString())) {
                        connection.Open();
                        string businessQuestion = Proprietary.getQuestions()[(int.Parse(this.comboBox2.Text) - 1)];
                        SqlDataAdapter sda = new SqlDataAdapter(businessQuestion, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        this.dataGridView3.DataSource = dt;
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
        }

    }
}
