using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace sqliteTest {
	public partial class StartUp : Form {
		public StartUp() {
			InitializeComponent();
		}

		private void StartUp_Load(object sender, EventArgs e) {
			// TODO: このコード行はデータを 'sQLiteDataSet.AuthMaster' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
			this.authMasterTableAdapter.Fill(this.sQLiteDataSet.AuthMaster);

		}

		private void closeButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void updateButton_Click(object sender, EventArgs e) {
			//入力チェック
			if (string.IsNullOrEmpty(this.adminNameTextBox.Text)
				|| string.IsNullOrEmpty(this.passwordTextBox.Text)
				|| string.IsNullOrEmpty(this.passwordConfirmTextBox.Text)) {
				MessageBox.Show("入力されていない項目があります。");
				return;
			}
			//パスワード一致チェック
			if (!this.passwordConfirmTextBox.Text.Equals(this.passwordTextBox.Text)) {
				MessageBox.Show("パスワードが一致しません。");
				return;
			}


			using (SQLiteDataSetTableAdapters.UserInformationTableAdapter ta
				= new sqliteTest.SQLiteDataSetTableAdapters.UserInformationTableAdapter()) {
				
				
				using (SQLiteConnection con = ta.Connection) {
					con.Open();

					using (SQLiteTransaction tran = con.BeginTransaction()) {
						SQLiteDataSet.UserInformationRow row = this.sQLiteDataSet.UserInformation.NewUserInformationRow();
						row.UserID = this.idTextBox.Text;
						row.UserName = this.adminNameTextBox.Text;
						row.Password = Common.Common.getHashedValue(this.passwordTextBox.Text);
						row.AuthNo = 1;//管理者なので固定・・・・
						row.Hints = string.IsNullOrEmpty(this.hintsTextBox.Text) ? string.Empty : this.hintsTextBox.Text;
						this.sQLiteDataSet.UserInformation.AddUserInformationRow(row);
						ta.Update(this.sQLiteDataSet.UserInformation);
						tran.Commit();
						MessageBox.Show("完了");
					}
				}
			}



		}
	}
}
