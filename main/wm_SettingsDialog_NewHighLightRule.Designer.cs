
namespace main
{
	partial class wm_SettingsDialog_NewHighLightRule
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_FileType = new System.Windows.Forms.TextBox();
			this.txt_HighLightFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_FileTemplate = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Explore_HighLight = new System.Windows.Forms.Button();
			this.btn_Explore_FileTemple = new System.Windows.Forms.Button();
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.dialog_Open = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "文件后缀名";
			// 
			// txt_FileType
			// 
			this.txt_FileType.Location = new System.Drawing.Point(100, 12);
			this.txt_FileType.Name = "txt_FileType";
			this.txt_FileType.Size = new System.Drawing.Size(100, 25);
			this.txt_FileType.TabIndex = 1;
			// 
			// txt_HighLightFile
			// 
			this.txt_HighLightFile.Enabled = false;
			this.txt_HighLightFile.Location = new System.Drawing.Point(100, 43);
			this.txt_HighLightFile.Name = "txt_HighLightFile";
			this.txt_HighLightFile.Size = new System.Drawing.Size(195, 25);
			this.txt_HighLightFile.TabIndex = 3;
			this.txt_HighLightFile.Text = "none";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "高亮文件";
			// 
			// txt_FileTemplate
			// 
			this.txt_FileTemplate.Enabled = false;
			this.txt_FileTemplate.Location = new System.Drawing.Point(100, 74);
			this.txt_FileTemplate.Name = "txt_FileTemplate";
			this.txt_FileTemplate.Size = new System.Drawing.Size(195, 25);
			this.txt_FileTemplate.TabIndex = 5;
			this.txt_FileTemplate.Text = "none";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "文件模板";
			// 
			// btn_Explore_HighLight
			// 
			this.btn_Explore_HighLight.Location = new System.Drawing.Point(301, 45);
			this.btn_Explore_HighLight.Name = "btn_Explore_HighLight";
			this.btn_Explore_HighLight.Size = new System.Drawing.Size(23, 23);
			this.btn_Explore_HighLight.TabIndex = 6;
			this.btn_Explore_HighLight.Text = "...";
			this.btn_Explore_HighLight.UseVisualStyleBackColor = true;
			this.btn_Explore_HighLight.Click += new System.EventHandler(this.btn_Explore_HighLight_Click);
			// 
			// btn_Explore_FileTemple
			// 
			this.btn_Explore_FileTemple.Location = new System.Drawing.Point(301, 76);
			this.btn_Explore_FileTemple.Name = "btn_Explore_FileTemple";
			this.btn_Explore_FileTemple.Size = new System.Drawing.Size(23, 23);
			this.btn_Explore_FileTemple.TabIndex = 7;
			this.btn_Explore_FileTemple.Text = "...";
			this.btn_Explore_FileTemple.UseVisualStyleBackColor = true;
			this.btn_Explore_FileTemple.Click += new System.EventHandler(this.btn_Explore_FileTemple_Click);
			// 
			// btn_OK
			// 
			this.btn_OK.Location = new System.Drawing.Point(12, 105);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_OK.TabIndex = 8;
			this.btn_OK.Text = "确定";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(93, 105);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 9;
			this.btn_Cancel.Text = "取消";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// wm_SettingsDialog_NewHighLightRule
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(338, 136);
			this.ControlBox = false;
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.btn_Explore_FileTemple);
			this.Controls.Add(this.btn_Explore_HighLight);
			this.Controls.Add(this.txt_FileTemplate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_HighLightFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_FileType);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "wm_SettingsDialog_NewHighLightRule";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新建文件高亮规则";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_FileType;
		private System.Windows.Forms.TextBox txt_HighLightFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_FileTemplate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Explore_HighLight;
		private System.Windows.Forms.Button btn_Explore_FileTemple;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.OpenFileDialog dialog_Open;
	}
}