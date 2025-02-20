using System.Drawing;
namespace MicroText.fscreen
{
	partial class wm_fscreen
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
			this.m_TeamLabel = new System.Windows.Forms.Label();
			this.m_ProgramLabel = new System.Windows.Forms.Label();
			this.m_VersionLabel = new System.Windows.Forms.Label();
			this.m_CopyrightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_TeamLabel
			// 
			this.m_TeamLabel.AutoSize = true;
			this.m_TeamLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.m_TeamLabel.Location = new System.Drawing.Point(0, 0);
			this.m_TeamLabel.Name = "m_TeamLabel";
			this.m_TeamLabel.Size = new System.Drawing.Size(15, 15);
			this.m_TeamLabel.TabIndex = 0;
			this.m_TeamLabel.Text = "m";
			// 
			// m_ProgramLabel
			// 
			this.m_ProgramLabel.AutoSize = true;
			this.m_ProgramLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.m_ProgramLabel.Location = new System.Drawing.Point(0, 32);
			this.m_ProgramLabel.Name = "m_ProgramLabel";
			this.m_ProgramLabel.Size = new System.Drawing.Size(119, 15);
			this.m_ProgramLabel.TabIndex = 1;
			this.m_ProgramLabel.Text = "m_ProgramLabel";
			// 
			// m_VersionLabel
			// 
			this.m_VersionLabel.AutoSize = true;
			this.m_VersionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.m_VersionLabel.Location = new System.Drawing.Point(667, 426);
			this.m_VersionLabel.Name = "m_VersionLabel";
			this.m_VersionLabel.Size = new System.Drawing.Size(15, 15);
			this.m_VersionLabel.TabIndex = 2;
			this.m_VersionLabel.Text = "m";
			// 
			// m_CopyrightLabel
			// 
			this.m_CopyrightLabel.AutoSize = true;
			this.m_CopyrightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.m_CopyrightLabel.Location = new System.Drawing.Point(0, 57);
			this.m_CopyrightLabel.Name = "m_CopyrightLabel";
			this.m_CopyrightLabel.Size = new System.Drawing.Size(15, 15);
			this.m_CopyrightLabel.TabIndex = 3;
			this.m_CopyrightLabel.Text = "m";
			// 
			// wm_fscreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.m_CopyrightLabel);
			this.Controls.Add(this.m_VersionLabel);
			this.Controls.Add(this.m_ProgramLabel);
			this.Controls.Add(this.m_TeamLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "wm_fscreen";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "wm_fscreen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label m_TeamLabel;
		private System.Windows.Forms.Label m_ProgramLabel;
		private System.Windows.Forms.Label m_VersionLabel;
		private System.Windows.Forms.Label m_CopyrightLabel;
	}
}