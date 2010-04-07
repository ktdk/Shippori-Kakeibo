using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sqliteTest {
	public class UserInformation {

		private string userId;
		private string userName;
		private string password;
		private bool isAccessable;
		private bool isUpdatable;
		private bool isDetelable;

		public string UserId {
			get {
				return this.userId;
			}
		}

		public string UserName {
			get {
				return this.userName;
			}
		}

		public string Password {
			get {
				return this.password;
			}
		}

		public bool IsAccessable {
			get {
				return this.isAccessable;
			}
		}

		public bool IsUpdatable {
			get {
				return this.isUpdatable;
			}
		}

		public bool IsDetelable {
			get {
				return this.isDetelable;
			}
		}
	
		public UserInformation(SQLiteDataSet.UserInformationRow row) {
			this.userId = row.UserID;
			this.userName = row.UserName;
			this.password = row.Password;
			using (SQLiteDataSet ds = new SQLiteDataSet()) {
				using (SQLiteDataSetTableAdapters.AuthMasterTableAdapter ta
					= new sqliteTest.SQLiteDataSetTableAdapters.AuthMasterTableAdapter()) {
					ta.FillByAuthNo(ds.AuthMaster, row.AuthNo);
				}
				SQLiteDataSet.AuthMasterRow authRow = ds.AuthMaster[0];
				this.isAccessable = authRow.IsAccessable;
				this.isUpdatable = authRow.IsUpdatable;
				this.isDetelable = authRow.IsDeletable;
			}
		}

		public bool IsAuthcated()
		{
			return (this.IsAccessable || this.IsDetelable || this.IsUpdatable);
		}

	}
}
