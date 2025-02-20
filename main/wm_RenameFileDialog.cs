using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
	public partial class wm_RenameFileDialog : Form
	{
		public string Rename = null;
		public bool IsCancel = true;
		public wm_RenameFileDialog()
		{
			InitializeComponent();
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			if (txt_Rename.Text == null)
			{
				MessageBox.Show("文件名不能为空", "MicroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (IsValidFilename(txt_Rename.Text))
			{
				MessageBox.Show("文件名包括无效字符", "MicroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Rename = txt_Rename.Text;
				IsCancel = false;
				this.Close();
			}
		}

		private static bool IsValidFilename(string filename)
		{
			// 检查是否包含任何无效字符
			foreach (char c in Path.GetInvalidFileNameChars())
			{
				if (filename.Contains(c))
				{
					return true;
				}
			}
			return false;
		}

		private void txt_Rename_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btn_OK_Click(null, null);
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
			IsCancel = true;
		}
	}
}
