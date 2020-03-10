namespace DBMSAssignmentModule1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dBMSDataSet = new DBMSAssignmentModule1.DBMSDataSet();
			this.dBMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.RUN = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dBMSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBMSDataSetBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dBMSDataSet
			// 
			this.dBMSDataSet.DataSetName = "DBMSDataSet";
			this.dBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dBMSDataSetBindingSource
			// 
			this.dBMSDataSetBindingSource.DataSource = this.dBMSDataSet;
			this.dBMSDataSetBindingSource.Position = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1129, 425);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1121, 399);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TABLES";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1100, 356);
			this.dataGridView1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Table:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(85, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.RUN);
			this.tabPage2.Controls.Add(this.richTextBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1121, 399);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "MANUAL QUERIES";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(968, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "PASSWORD:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(971, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 20);
			this.textBox1.TabIndex = 3;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(9, 129);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(1103, 264);
			this.dataGridView2.TabIndex = 2;
			// 
			// RUN
			// 
			this.RUN.Location = new System.Drawing.Point(971, 49);
			this.RUN.Name = "RUN";
			this.RUN.Size = new System.Drawing.Size(141, 73);
			this.RUN.TabIndex = 1;
			this.RUN.Text = "RUN QUERY";
			this.RUN.UseVisualStyleBackColor = true;
			this.RUN.Click += new System.EventHandler(this.RUN_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(9, 4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(956, 118);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.maskedTextBox1);
			this.tabPage3.Controls.Add(this.button1);
			this.tabPage3.Controls.Add(this.textBox4);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.textBox3);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.textBox2);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1121, 399);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(756, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(272, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "INSERT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(584, 15);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(153, 20);
			this.textBox4.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(518, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "LANDLINE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(407, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "HOUSE";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(288, 15);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(106, 20);
			this.textBox3.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(226, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "STREET";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(83, 15);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "CITY";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(458, 15);
			this.maskedTextBox1.Mask = "0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(31, 20);
			this.maskedTextBox1.TabIndex = 9;
			this.maskedTextBox1.ValidatingType = typeof(int);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.dBMSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBMSDataSetBindingSource)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource dBMSDataSetBindingSource;
		private DBMSDataSet dBMSDataSet;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button RUN;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}

