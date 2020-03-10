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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.RUN = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dBMSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBMSDataSetBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(9, 4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(956, 118);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
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
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(9, 129);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(1103, 264);
			this.dataGridView2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(971, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 20);
			this.textBox1.TabIndex = 3;
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
	}
}

