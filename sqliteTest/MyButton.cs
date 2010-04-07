using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sqliteTest.Properties;

namespace sqliteTest {
	public partial class MyButton : Button {
		public MyButton() {
			InitializeComponent();
			this.Image = Resources.button_off;
		}

		public MyButton(IContainer container) {
			container.Add(this);

			InitializeComponent();
		}

		private void MyButton_MouseHover(object sender, EventArgs e) {
			this.Image = Resources.button_hover;
		}

		private void MyButton_MouseDown(object sender, MouseEventArgs e) {
			this.Image = Resources.button_on;
		}

		private void MyButton_MouseLeave(object sender, EventArgs e) {
			this.Image = Resources.button_off;
		}

	}
}
