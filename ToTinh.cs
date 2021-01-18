using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToTinh
{
	public partial class ToTinh : Form
	{
		Random random = new Random();

		bool firstClicked = false, secondClicked = false;
		int refuseAttempts = 0;

		public ToTinh()
		{
			InitializeComponent();
			lblAsk1.Visible = false;
			lblAsk2.Visible = false;

			btnYes.Visible = false;
			btnNo.Visible = false;
		}

		private void lblHello_Click(object sender, EventArgs e)
		{
			if (!firstClicked && !secondClicked)
			{
				lblHello.Visible = false;
				lblAsk1.Visible = true;

				btnHello.Text = "Okay";

				firstClicked = true;
				return;
			}

			if (firstClicked && !secondClicked)
			{
				lblAsk1.Visible = false;
				lblAsk2.Visible = true;

				btnHello.Visible = false;
				btnYes.Visible = true;
				btnNo.Visible = true;

				secondClicked = true;

				refuseAttempts = random.Next(1, 11);

				return;
			}
		}

		private void btnNo_MouseHover(object sender, EventArgs e)
		{
			btnNo.Location = new Point(random.Next(12, 400), random.Next(12, 120));
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			if (refuseAttempts == 0)
			{
				MessageBox.Show("Đã có lỗi xảy ra.\nVui lòng thử lại nhé!\n\nBạn hãy thử bấm vào nút \"Có\" xem.", "Error");
				refuseAttempts = random.Next(1, 11);
			}
			else
				refuseAttempts--;

			btnNo.Location = new Point(random.Next(12, 400), random.Next(12, 120));
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("I Love You 3K", "<3");
			if (result == DialogResult.OK)
				Environment.Exit(0);
		}

		private void ToTinh_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (firstClicked && secondClicked)
			{
				e.Cancel = true;
				MessageBox.Show("Đã có lỗi xảy ra.\nVui lòng thử lại nhé!\n\nBạn hãy thử bấm vào nút \"Có\" xem.", "Error");
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.C))
			{
				Environment.Exit(0);
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
