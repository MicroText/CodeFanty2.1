
namespace main
{
	partial class wm_HighLightManager
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
			this.lst_HighLightList = new System.Windows.Forms.ListBox();
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.dialog_Open = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// lst_HighLightList
			// 
			this.lst_HighLightList.FormattingEnabled = true;
			this.lst_HighLightList.ItemHeight = 15;
			this.lst_HighLightList.Location = new System.Drawing.Point(12, 12);
			this.lst_HighLightList.Name = "lst_HighLightList";
			this.lst_HighLightList.Size = new System.Drawing.Size(318, 109);
			this.lst_HighLightList.TabIndex = 0;
			this.lst_HighLightList.DoubleClick += new System.EventHandler(this.lst_HighLightList_DoubleClick);
			// 
			// btn_OK
			// 
			this.btn_OK.Location = new System.Drawing.Point(12, 127);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_OK.TabIndex = 1;
			this.btn_OK.Text = "确定";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(93, 127);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 2;
			this.btn_Cancel.Text = "取消";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(174, 127);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 3;
			this.btn_Add.Text = "添加";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(255, 127);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 23);
			this.btn_Delete.TabIndex = 4;
			this.btn_Delete.Text = "删除";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// dialog_Open
			// 
			this.dialog_Open.Filter = "AvalonEdit高亮规则文件|*.xshd";
			// 
			// wm_HighLightManager
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(342, 160);
			this.ControlBox = false;
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.lst_HighLightList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "wm_HighLightManager";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "高亮文件管理器";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lst_HighLightList;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.OpenFileDialog dialog_Open;
	}
}