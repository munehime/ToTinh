
namespace ToTinh
{
	partial class ToTinh
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
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
			this.lblHello = new System.Windows.Forms.Label();
			this.btnYes = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.btnHello = new System.Windows.Forms.Button();
			this.lblAsk1 = new System.Windows.Forms.Label();
			this.lblAsk2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblHello
			// 
			this.lblHello.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblHello.AutoSize = true;
			this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHello.Location = new System.Drawing.Point(204, 51);
			this.lblHello.Name = "lblHello";
			this.lblHello.Size = new System.Drawing.Size(78, 16);
			this.lblHello.TabIndex = 0;
			this.lblHello.Text = "Chào bạn!";
			this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnYes
			// 
			this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnYes.Location = new System.Drawing.Point(125, 80);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(75, 23);
			this.btnYes.TabIndex = 1;
			this.btnYes.TabStop = false;
			this.btnYes.Text = "Có";
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// btnNo
			// 
			this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnNo.Location = new System.Drawing.Point(287, 80);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(75, 23);
			this.btnNo.TabIndex = 2;
			this.btnNo.TabStop = false;
			this.btnNo.Text = "Không";
			this.btnNo.UseVisualStyleBackColor = true;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			this.btnNo.MouseHover += new System.EventHandler(this.btnNo_MouseHover);
			// 
			// btnHello
			// 
			this.btnHello.Location = new System.Drawing.Point(206, 80);
			this.btnHello.Name = "btnHello";
			this.btnHello.Size = new System.Drawing.Size(75, 23);
			this.btnHello.TabIndex = 3;
			this.btnHello.Text = "Xin chào!";
			this.btnHello.UseVisualStyleBackColor = true;
			this.btnHello.Click += new System.EventHandler(this.lblHello_Click);
			// 
			// lblAsk1
			// 
			this.lblAsk1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblAsk1.AutoSize = true;
			this.lblAsk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAsk1.Location = new System.Drawing.Point(64, 51);
			this.lblAsk1.Name = "lblAsk1";
			this.lblAsk1.Size = new System.Drawing.Size(358, 16);
			this.lblAsk1.TabIndex = 4;
			this.lblAsk1.Text = "Bạn có thể cho mình hỏi một câu có được không? :3";
			this.lblAsk1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAsk2
			// 
			this.lblAsk2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblAsk2.AutoSize = true;
			this.lblAsk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAsk2.Location = new System.Drawing.Point(85, 51);
			this.lblAsk2.Name = "lblAsk2";
			this.lblAsk2.Size = new System.Drawing.Size(317, 16);
			this.lblAsk2.TabIndex = 5;
			this.lblAsk2.Text = "Bạn có muốn làm người yêu của tớ không? <3";
			this.lblAsk2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ToTinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 155);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnHello);
			this.Controls.Add(this.lblAsk2);
			this.Controls.Add(this.lblHello);
			this.Controls.Add(this.lblAsk1);
			this.Controls.Add(this.btnYes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ToTinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hello";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToTinh_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHello;
		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Button btnHello;
		private System.Windows.Forms.Label lblAsk1;
		private System.Windows.Forms.Label lblAsk2;
	}
}

