using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sqliteTest {
	static class Program {
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() {
			UserInformation user;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (loginForm form = new loginForm()) {
				Application.Run(form);
				user = form.User;
			}

			if (user != null) {
				Application.Run(new MenuForm(user));
			}
		}
	}
}
