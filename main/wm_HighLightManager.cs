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
	public partial class wm_HighLightManager : Form
	{
		public bool IsCancel = true;
		public string SelectedItemPath = null;
		private string pth = Environment.CurrentDirectory;
		private string[] FileList = new string[0];
		public wm_HighLightManager()
		{
			InitializeComponent();
			RefreshList();
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			if (lst_HighLightList.SelectedIndex == -1)
			{
				MessageBox.Show("请选择项", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				SelectedItemPath = FileList[lst_HighLightList.SelectedIndex];
				IsCancel = false;
				this.Close();
			}
		}

		private void RefreshList()
		{
			lst_HighLightList.Items.Clear();
			FileList = Directory.GetFiles(pth + @"\HighLighting");
			foreach (string item in FileList)
			{
				lst_HighLightList.Items.Add(Path.GetFileName(item));
			}
			lst_HighLightList.Items.Add("none");
			List<string> ListCache = FileList.ToList();
			ListCache.Add("none");
			FileList = ListCache.ToArray();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			IsCancel = true;
			this.Close();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			if (dialog_Open.ShowDialog() == DialogResult.OK)
			{
				string DestFilePath = Path.GetFileName(dialog_Open.FileName);
				if (File.Exists(DestFilePath))
				{
					MessageBox.Show("文件已存在", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					File.Copy(dialog_Open.FileName, pth + @"\HighLighting\" + Path.GetFileName(DestFilePath));
					RefreshList();
				}
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (lst_HighLightList.SelectedIndex == -1)
			{
				MessageBox.Show("请选择项", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (FileList[lst_HighLightList.SelectedIndex] == "none")
			{
				MessageBox.Show("该项不可删除", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("确定要删除吗?", "MicroText CodeFanty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					File.Delete(FileList[lst_HighLightList.SelectedIndex]);
					RefreshList();
				}
			}
		}

		private void lst_HighLightList_DoubleClick(object sender, EventArgs e)
		{
			if (lst_HighLightList.SelectedIndex >= 0)
			{
				btn_OK_Click(null, null);
			}
		}
	}
}
