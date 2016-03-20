namespace Enrollment
{
	partial class MainForm
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
			System.Windows.Forms.Label Bevel;
			System.Windows.Forms.Label label1;
			this.EnrollButton = new System.Windows.Forms.Button();
			this.VerifyButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.LoadButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			Bevel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Bevel
			// 
			Bevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			Bevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			Bevel.Location = new System.Drawing.Point(12, 91);
			Bevel.Name = "Bevel";
			Bevel.Size = new System.Drawing.Size(360, 3);
			Bevel.TabIndex = 2;
			// 
			// label1
			// 
			label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label1.Location = new System.Drawing.Point(12, 187);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(360, 3);
			label1.TabIndex = 5;
			// 
			// EnrollButton
			// 
			this.EnrollButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.EnrollButton.Location = new System.Drawing.Point(12, 12);
			this.EnrollButton.Name = "EnrollButton";
			this.EnrollButton.Size = new System.Drawing.Size(360, 30);
			this.EnrollButton.TabIndex = 0;
			this.EnrollButton.Text = "Fingerprint Enrollment";
			this.EnrollButton.UseVisualStyleBackColor = true;
			this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
			// 
			// VerifyButton
			// 
			this.VerifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.VerifyButton.Enabled = false;
			this.VerifyButton.Location = new System.Drawing.Point(12, 48);
			this.VerifyButton.Name = "VerifyButton";
			this.VerifyButton.Size = new System.Drawing.Size(360, 30);
			this.VerifyButton.TabIndex = 1;
			this.VerifyButton.Text = "Fingerprint Verification";
			this.VerifyButton.UseVisualStyleBackColor = true;
			this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Enabled = false;
			this.SaveButton.Location = new System.Drawing.Point(12, 107);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(360, 30);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Save Fingerprint Template";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// LoadButton
			// 
			this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.LoadButton.Location = new System.Drawing.Point(12, 143);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(360, 30);
			this.LoadButton.TabIndex = 4;
			this.LoadButton.Text = "Read Fingerprint Template";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new System.Drawing.Point(297, 204);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 6;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(384, 239);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(label1);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(Bevel);
			this.Controls.Add(this.VerifyButton);
			this.Controls.Add(this.EnrollButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fingerprint Enrollment and Verification Sample";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button EnrollButton;
		private System.Windows.Forms.Button VerifyButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Button CloseButton;
	}
}

