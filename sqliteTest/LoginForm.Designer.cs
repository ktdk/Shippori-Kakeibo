namespace sqliteTest {
	partial class loginForm {
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.linkStartUpLabel = new System.Windows.Forms.LinkLabel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.sqLiteDataSet = new sqliteTest.SQLiteDataSet();
			((System.ComponentModel.ISupportInitialize)(this.sqLiteDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// linkStartUpLabel
			// 
			this.linkStartUpLabel.AutoSize = true;
			this.linkStartUpLabel.Location = new System.Drawing.Point(16, 67);
			this.linkStartUpLabel.Name = "linkStartUpLabel";
			this.linkStartUpLabel.Size = new System.Drawing.Size(77, 12);
			this.linkStartUpLabel.TabIndex = 0;
			this.linkStartUpLabel.TabStop = true;
			this.linkStartUpLabel.Text = "初期情報設定";
			this.linkStartUpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStartUpLabel_LinkClicked);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(12, 15);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(53, 12);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "ログイン名";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(71, 12);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(103, 19);
			this.nameTextBox.TabIndex = 2;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(71, 37);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(103, 19);
			this.passwordTextBox.TabIndex = 3;			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 40);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(52, 12);
			this.passwordLabel.TabIndex = 4;
			this.passwordLabel.Text = "パスワード";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(99, 62);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "ログイン";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// sqLiteDataSet
			// 
			this.sqLiteDataSet.DataSetName = "SQLiteDataSet";
			this.sqLiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(186, 91);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.linkStartUpLabel);
			this.Name = "loginForm";
			this.Text = "ログイン";
			((System.ComponentModel.ISupportInitialize)(this.sqLiteDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkStartUpLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button loginButton;
		private SQLiteDataSet sqLiteDataSet;
	}
}

