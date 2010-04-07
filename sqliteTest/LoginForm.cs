using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sqliteTest {
	public partial class loginForm : Form {

		private UserInformation user;

		public UserInformation User {
			get {
				return this.user;
			}
		}

		public loginForm() {
			InitializeComponent();
		}

		private void linkStartUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			StartUp form = new StartUp();
			form.ShowDialog();
		}

		private void loginButton_Click(object sender, EventArgs e) {
			string hashedPass = Common.Common.getHashedValue(this.passwordTextBox.Text);
			using (SQLiteDataSetTableAdapters.UserInformationTableAdapter ta
				= new sqliteTest.SQLiteDataSetTableAdapters.UserInformationTableAdapter()) {
				ta.FillByLogin(this.sqLiteDataSet.UserInformation, this.nameTextBox.Text, hashedPass);
			}
			if (this.sqLiteDataSet.UserInformation.Rows.Count <= 0) {
				MessageBox.Show("ログイン名かパスワードが間違っています。");
				return;
			}
			this.user = new UserInformation(this.sqLiteDataSet.UserInformation[0]);
			this.Close();
		}
	}
}
