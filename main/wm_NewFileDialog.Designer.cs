
namespace main
{
	partial class wm_NewFileDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wm_NewFileDialog));
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Dictionary = new System.Windows.Forms.TextBox();
			this.txt_FileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Explorer = new System.Windows.Forms.Button();
			this.dialog_Folder = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "目录";
			// 
			// txt_Dictionary
			// 
			this.txt_Dictionary.Location = new System.Drawing.Point(70, 12);
			this.txt_Dictionary.Name = "txt_Dictionary";
			this.txt_Dictionary.Size = new System.Drawing.Size(435, 25);
			this.txt_Dictionary.TabIndex = 1;
			this.txt_Dictionary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dictionary_KeyPress);
			// 
			// txt_FileName
			// 
			this.txt_FileName.Location = new System.Drawing.Point(70, 43);
			this.txt_FileName.Name = "txt_FileName";
			this.txt_FileName.Size = new System.Drawing.Size(192, 25);
			this.txt_FileName.TabIndex = 2;
			this.txt_FileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FileName_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "文件名";
			// 
			// btn_OK
			// 
			this.btn_OK.Location = new System.Drawing.Point(268, 43);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_OK.TabIndex = 4;
			this.btn_OK.Text = "确定";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(349, 43);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "取消";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Explorer
			// 
			this.btn_Explorer.Location = new System.Drawing.Point(430, 43);
			this.btn_Explorer.Name = "btn_Explorer";
			this.btn_Explorer.Size = new System.Drawing.Size(75, 23);
			this.btn_Explorer.TabIndex = 6;
			this.btn_Explorer.Text = "浏览";
			this.btn_Explorer.UseVisualStyleBackColor = true;
			this.btn_Explorer.Click += new System.EventHandler(this.btn_Explorer_Click);
			// 
			// wm_NewFileDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(523, 72);
			this.ControlBox = false;
			this.Controls.Add(this.btn_Explorer);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_FileName);
			this.Controls.Add(this.txt_Dictionary);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "wm_NewFileDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新建";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Dictionary;
		private System.Windows.Forms.TextBox txt_FileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Explorer;
		private System.Windows.Forms.FolderBrowserDialog dialog_Folder;
	}
}