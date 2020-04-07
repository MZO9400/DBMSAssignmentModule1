namespace DBMSAssignmentModule1 {
	partial class NescafeBasement {
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dBMSDataSet = new DBMSAssignmentModule1.DBMSDataSet();
			this.dBMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
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
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize) (this.dBMSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.dBMSDataSetBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// dBMSDataSet
			// 
			this.dBMSDataSet.DataSetName = "DBMSDataSet";
			this.dBMSDataSet.Namespace = "http://tempuri.org/DBMSDataSet.xsd";
			this.dBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dBMSDataSetBindingSource
			// 
			this.dBMSDataSetBindingSource.DataSource = this.dBMSDataSet;
			this.dBMSDataSetBindingSource.Position = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor =
				((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
				                                         System.Windows.Forms.AnchorStyles.Bottom) |
				                                        System.Windows.Forms.AnchorStyles.Left) |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabControl1.HotTrack = true;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1317, 490);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1309, 462);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TABLES";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(247, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "UPDATE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor =
				((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
				                                         System.Windows.Forms.AnchorStyles.Bottom) |
				                                        System.Windows.Forms.AnchorStyles.Left) |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode =
				System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.dataGridView1.Location = new System.Drawing.Point(14, 43);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidthSizeMode =
				System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView1.Size = new System.Drawing.Size(1283, 409);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick +=
				new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Table:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(99, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(140, 23);
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
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1309, 462);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "MANUAL QUERIES";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor =
				((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1129, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "PASSWORD:";
			// 
			// textBox1
			// 
			this.textBox1.Anchor =
				((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(1133, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(164, 23);
			this.textBox1.TabIndex = 3;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.Anchor =
				((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
				                                         System.Windows.Forms.AnchorStyles.Bottom) |
				                                        System.Windows.Forms.AnchorStyles.Left) |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView2.ColumnHeadersHeightSizeMode =
				System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView2.Location = new System.Drawing.Point(10, 149);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidthSizeMode =
				System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView2.Size = new System.Drawing.Size(1287, 303);
			this.dataGridView2.TabIndex = 2;
			// 
			// RUN
			// 
			this.RUN.Anchor =
				((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.RUN.Location = new System.Drawing.Point(1133, 57);
			this.RUN.Name = "RUN";
			this.RUN.Size = new System.Drawing.Size(164, 84);
			this.RUN.TabIndex = 1;
			this.RUN.Text = "RUN QUERY";
			this.RUN.UseVisualStyleBackColor = true;
			this.RUN.Click += new System.EventHandler(this.RUN_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor =
				((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
				                                        System.Windows.Forms.AnchorStyles.Left) |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(10, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1115, 136);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.dataGridView3);
			this.tabPage3.Controls.Add(this.comboBox2);
			this.tabPage3.Location = new System.Drawing.Point(4, 24);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1309, 462);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "BUSINESS QUESTIONS";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Business Question:";
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToOrderColumns = true;
			this.dataGridView3.Anchor =
				((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
				                                         System.Windows.Forms.AnchorStyles.Bottom) |
				                                        System.Windows.Forms.AnchorStyles.Left) |
				                                       System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView3.ColumnHeadersHeightSizeMode =
				System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.dataGridView3.Location = new System.Drawing.Point(9, 38);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowHeadersWidthSizeMode =
				System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView3.Size = new System.Drawing.Size(1288, 413);
			this.dataGridView3.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
			this.comboBox2.Location = new System.Drawing.Point(129, 7);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(54, 23);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// NescafeBasement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1316, 519);
			this.Controls.Add(this.tabControl1);
			this.MinimumSize = new System.Drawing.Size(744, 548);
			this.Name = "NescafeBasement";
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize) (this.dBMSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.dBMSDataSetBindingSource)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.BindingSource dBMSDataSetBindingSource;
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView3;
		private DBMSAssignmentModule1.DBMSDataSet dBMSDataSet;
	}
}

