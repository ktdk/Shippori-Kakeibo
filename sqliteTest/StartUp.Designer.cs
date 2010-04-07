namespace sqliteTest {
	partial class StartUp {
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
			this.adminNameLabel = new System.Windows.Forms.Label();
			this.adminNameTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.passwordConfirmLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
			this.hintsTextBox = new System.Windows.Forms.TextBox();
			this.hintsLabel = new System.Windows.Forms.Label();
			this.updateButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.authMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addAuthButton = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.accessCkBox = new System.Windows.Forms.CheckBox();
			this.updateCkBox = new System.Windows.Forms.CheckBox();
			this.deleteCkBox = new System.Windows.Forms.CheckBox();
			this.authName = new System.Windows.Forms.Label();
			this.authTypeTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.authRemarkTextBox = new System.Windows.Forms.TextBox();
			this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isAccessableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isUpdatableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isDeletableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sQLiteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sQLiteDataSet = new sqliteTest.SQLiteDataSet();
			this.authMasterTableAdapter = new sqliteTest.SQLiteDataSetTableAdapters.AuthMasterTableAdapter();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.authMasterBindingSource)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sQLiteDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sQLiteDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// adminNameLabel
			// 
			this.adminNameLabel.AutoSize = true;
			this.adminNameLabel.Location = new System.Drawing.Point(3, 28);
			this.adminNameLabel.Margin = new System.Windows.Forms.Padding(3);
			this.adminNameLabel.Name = "adminNameLabel";
			this.adminNameLabel.Size = new System.Drawing.Size(53, 12);
			this.adminNameLabel.TabIndex = 0;
			this.adminNameLabel.Text = "管理者名";
			// 
			// adminNameTextBox
			// 
			this.adminNameTextBox.Location = new System.Drawing.Point(98, 28);
			this.adminNameTextBox.Name = "adminNameTextBox";
			this.adminNameTextBox.Size = new System.Drawing.Size(211, 19);
			this.adminNameTextBox.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Controls.Add(this.updateButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 180);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "管理者情報";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(3, 53);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(3);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(52, 12);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "パスワード";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(98, 53);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(211, 19);
			this.passwordTextBox.TabIndex = 4;
			// 
			// passwordConfirmLabel
			// 
			this.passwordConfirmLabel.AutoSize = true;
			this.passwordConfirmLabel.Location = new System.Drawing.Point(3, 78);
			this.passwordConfirmLabel.Margin = new System.Windows.Forms.Padding(3);
			this.passwordConfirmLabel.Name = "passwordConfirmLabel";
			this.passwordConfirmLabel.Size = new System.Drawing.Size(88, 12);
			this.passwordConfirmLabel.TabIndex = 3;
			this.passwordConfirmLabel.Text = "パスワード確認用";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.hintsLabel, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.passwordConfirmLabel, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.adminNameTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.adminNameLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.passwordConfirmTextBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.hintsTextBox, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.idTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 125);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// passwordConfirmTextBox
			// 
			this.passwordConfirmTextBox.Location = new System.Drawing.Point(98, 78);
			this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			this.passwordConfirmTextBox.PasswordChar = '*';
			this.passwordConfirmTextBox.Size = new System.Drawing.Size(211, 19);
			this.passwordConfirmTextBox.TabIndex = 4;
			// 
			// hintsTextBox
			// 
			this.hintsTextBox.Location = new System.Drawing.Point(98, 103);
			this.hintsTextBox.Name = "hintsTextBox";
			this.hintsTextBox.Size = new System.Drawing.Size(211, 19);
			this.hintsTextBox.TabIndex = 4;
			// 
			// hintsLabel
			// 
			this.hintsLabel.AutoSize = true;
			this.hintsLabel.Location = new System.Drawing.Point(3, 103);
			this.hintsLabel.Margin = new System.Windows.Forms.Padding(3);
			this.hintsLabel.Name = "hintsLabel";
			this.hintsLabel.Size = new System.Drawing.Size(89, 12);
			this.hintsLabel.TabIndex = 4;
			this.hintsLabel.Text = "パスワード用ヒント";
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(255, 149);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "登録";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(585, 449);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "閉じる";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.authTypeDataGridViewTextBoxColumn,
            this.isAccessableDataGridViewCheckBoxColumn,
            this.isUpdatableDataGridViewCheckBoxColumn,
            this.isDeletableDataGridViewCheckBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.authMasterBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(6, 108);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(636, 131);
			this.dataGridView1.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.authRemarkTextBox);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.authTypeTextBox);
			this.groupBox2.Controls.Add(this.authName);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.addAuthButton);
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(12, 198);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(648, 245);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "権限情報";
			// 
			// authMasterBindingSource
			// 
			this.authMasterBindingSource.DataMember = "AuthMaster";
			this.authMasterBindingSource.DataSource = this.sQLiteDataSetBindingSource;
			// 
			// addAuthButton
			// 
			this.addAuthButton.Location = new System.Drawing.Point(567, 79);
			this.addAuthButton.Name = "addAuthButton";
			this.addAuthButton.Size = new System.Drawing.Size(75, 23);
			this.addAuthButton.TabIndex = 5;
			this.addAuthButton.Text = "追加";
			this.addAuthButton.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.deleteCkBox);
			this.groupBox3.Controls.Add(this.updateCkBox);
			this.groupBox3.Controls.Add(this.accessCkBox);
			this.groupBox3.Location = new System.Drawing.Point(486, 18);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(75, 84);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "権限";
			// 
			// accessCkBox
			// 
			this.accessCkBox.AutoSize = true;
			this.accessCkBox.Location = new System.Drawing.Point(6, 18);
			this.accessCkBox.Name = "accessCkBox";
			this.accessCkBox.Size = new System.Drawing.Size(60, 16);
			this.accessCkBox.TabIndex = 0;
			this.accessCkBox.Text = "参照権";
			this.accessCkBox.UseVisualStyleBackColor = true;
			// 
			// updateCkBox
			// 
			this.updateCkBox.AutoSize = true;
			this.updateCkBox.Location = new System.Drawing.Point(6, 40);
			this.updateCkBox.Name = "updateCkBox";
			this.updateCkBox.Size = new System.Drawing.Size(60, 16);
			this.updateCkBox.TabIndex = 1;
			this.updateCkBox.Text = "更新権";
			this.updateCkBox.UseVisualStyleBackColor = true;
			// 
			// deleteCkBox
			// 
			this.deleteCkBox.AutoSize = true;
			this.deleteCkBox.Location = new System.Drawing.Point(6, 62);
			this.deleteCkBox.Name = "deleteCkBox";
			this.deleteCkBox.Size = new System.Drawing.Size(60, 16);
			this.deleteCkBox.TabIndex = 2;
			this.deleteCkBox.Text = "削除権";
			this.deleteCkBox.UseVisualStyleBackColor = true;
			// 
			// authName
			// 
			this.authName.AutoSize = true;
			this.authName.Location = new System.Drawing.Point(6, 21);
			this.authName.Name = "authName";
			this.authName.Size = new System.Drawing.Size(41, 12);
			this.authName.TabIndex = 7;
			this.authName.Text = "権限名";
			// 
			// authTypeTextBox
			// 
			this.authTypeTextBox.Location = new System.Drawing.Point(53, 18);
			this.authTypeTextBox.Name = "authTypeTextBox";
			this.authTypeTextBox.Size = new System.Drawing.Size(427, 19);
			this.authTypeTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "備考";
			// 
			// authRemarkTextBox
			// 
			this.authRemarkTextBox.Location = new System.Drawing.Point(53, 43);
			this.authRemarkTextBox.Multiline = true;
			this.authRemarkTextBox.Name = "authRemarkTextBox";
			this.authRemarkTextBox.Size = new System.Drawing.Size(427, 59);
			this.authRemarkTextBox.TabIndex = 9;
			// 
			// noDataGridViewTextBoxColumn
			// 
			this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
			this.noDataGridViewTextBoxColumn.HeaderText = "No";
			this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
			// 
			// authTypeDataGridViewTextBoxColumn
			// 
			this.authTypeDataGridViewTextBoxColumn.DataPropertyName = "AuthType";
			this.authTypeDataGridViewTextBoxColumn.HeaderText = "権限";
			this.authTypeDataGridViewTextBoxColumn.Name = "authTypeDataGridViewTextBoxColumn";
			// 
			// isAccessableDataGridViewCheckBoxColumn
			// 
			this.isAccessableDataGridViewCheckBoxColumn.DataPropertyName = "IsAccessable";
			this.isAccessableDataGridViewCheckBoxColumn.HeaderText = "参照権";
			this.isAccessableDataGridViewCheckBoxColumn.Name = "isAccessableDataGridViewCheckBoxColumn";
			// 
			// isUpdatableDataGridViewCheckBoxColumn
			// 
			this.isUpdatableDataGridViewCheckBoxColumn.DataPropertyName = "IsUpdatable";
			this.isUpdatableDataGridViewCheckBoxColumn.HeaderText = "更新権";
			this.isUpdatableDataGridViewCheckBoxColumn.Name = "isUpdatableDataGridViewCheckBoxColumn";
			// 
			// isDeletableDataGridViewCheckBoxColumn
			// 
			this.isDeletableDataGridViewCheckBoxColumn.DataPropertyName = "IsDeletable";
			this.isDeletableDataGridViewCheckBoxColumn.HeaderText = "削除権";
			this.isDeletableDataGridViewCheckBoxColumn.Name = "isDeletableDataGridViewCheckBoxColumn";
			// 
			// remarkDataGridViewTextBoxColumn
			// 
			this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
			this.remarkDataGridViewTextBoxColumn.HeaderText = "備考";
			this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
			// 
			// sQLiteDataSetBindingSource
			// 
			this.sQLiteDataSetBindingSource.DataSource = this.sQLiteDataSet;
			this.sQLiteDataSetBindingSource.Position = 0;
			// 
			// sQLiteDataSet
			// 
			this.sQLiteDataSet.DataSetName = "SQLiteDataSet";
			this.sQLiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// authMasterTableAdapter
			// 
			this.authMasterTableAdapter.ClearBeforeFill = true;
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(98, 3);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(211, 19);
			this.idTextBox.TabIndex = 1;
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(3, 3);
			this.idLabel.Margin = new System.Windows.Forms.Padding(3);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(53, 12);
			this.idLabel.TabIndex = 0;
			this.idLabel.Text = "ログイン名";
			// 
			// StartUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 480);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "StartUp";
			this.Text = "初期登録画面";
			this.Load += new System.EventHandler(this.StartUp_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.authMasterBindingSource)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sQLiteDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sQLiteDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label adminNameLabel;
		private System.Windows.Forms.TextBox adminNameTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label passwordConfirmLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox passwordConfirmTextBox;
		private System.Windows.Forms.Label hintsLabel;
		private System.Windows.Forms.TextBox hintsTextBox;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource sQLiteDataSetBindingSource;
		private SQLiteDataSet sQLiteDataSet;
		private System.Windows.Forms.BindingSource authMasterBindingSource;
		private sqliteTest.SQLiteDataSetTableAdapters.AuthMasterTableAdapter authMasterTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isAccessableDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isUpdatableDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletableDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button addAuthButton;
		private System.Windows.Forms.TextBox authRemarkTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox authTypeTextBox;
		private System.Windows.Forms.Label authName;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox deleteCkBox;
		private System.Windows.Forms.CheckBox updateCkBox;
		private System.Windows.Forms.CheckBox accessCkBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Label idLabel;
	}
}