using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sqliteTest.Properties;

namespace sqliteTest.Controls {
	public partial class CustomButton : Button {
		public CustomButton():base() {
			
			InitializeComponent();
			this.Image = Resources.button_off;
		}

		protected override void OnMouseEnter(EventArgs e) {
			this.Image = Resources.button_hover;
			base.OnMouseHover(e);
		}

		protected override void OnMouseDown(MouseEventArgs mevent) {
			base.OnMouseDown(mevent);
		}

		private void CustomButton_MouseHover(object sender, EventArgs e) {
			
		}

		private void CustomButton_MouseDown(object sender, MouseEventArgs e) {
			this.Image = Resources.button_on;
		}

		private void CustomButton_MouseLeave(object sender, EventArgs e) {
			this.Image = Resources.button_off;
		}
	
	}
}
