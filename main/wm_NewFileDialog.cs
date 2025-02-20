using MicroText.FileBindThemeDB;
using MicroText.FileType;
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
	public partial class wm_NewFileDialog : Form
	{
		private string pth = Environment.CurrentDirectory;
		public string filepath;
		public bool IsCancel = true;
		private bool IsLoadSavePathSettings;
		public wm_NewFileDialog(bool _IsLoadSavePathSettings, string path)
		{
			InitializeComponent();
			IsLoadSavePathSettings = _IsLoadSavePathSettings;
			if (IsLoadSavePathSettings)
			{
				try
				{
					dialog_Folder.SelectedPath = txt_Dictionary.Text = File.ReadAllText(pth + @"\SettingsDB\DefaultPath.strdb");
				}
				catch
				{
					//Nothing
				}
			}
			else
			{
				dialog_Folder.SelectedPath = txt_Dictionary.Text = path;
			}
		}

		private void txt_Dictionary_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				txt_FileName.Focus();
			}
		}

		private void txt_FileName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btn_OK_Click(null, null);
			}
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			filepath = txt_Dictionary.Text + "\\" + txt_FileName.Text;
			if (txt_Dictionary.Text == "" || txt_FileName.Text == "")
			{
				MessageBox.Show("文件名和文件目录不能为空", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (File.Exists(filepath))
			{
				MessageBox.Show("此文件已存在", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (IsValidFilename(txt_FileName.Text))
			{
				MessageBox.Show("文件名包括无效字符", "MicroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.Close();
				IsCancel = false;
				if (IsLoadSavePathSettings)
				{
					File.WriteAllText(pth + @"\SettingsDB\DefaultPath.strdb", txt_Dictionary.Text);
				}
				string TemplateFile = GetTemplateFile(filepath);
				string TemplateFileText = File.ReadAllText(pth + @"\Template\" + TemplateFile);
				TemplateFileText = TemplateFileText.Replace("%%DATE%%", string.Format("{0}/{1}/{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
				TemplateFileText = TemplateFileText.Replace("%%FILENAME%%", txt_FileName.Text);
				File.WriteAllText(filepath, TemplateFileText);
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
			IsCancel = true;
		}

		private void btn_Explorer_Click(object sender, EventArgs e)
		{
			if (dialog_Folder.ShowDialog() == DialogResult.OK)
			{
				txt_Dictionary.Text = dialog_Folder.SelectedPath;
			}
		}

		private string GetTemplateFile(string FileName)
		{
			//获取后缀名
			string FileType = Path.GetExtension(FileName).ToUpper();
			m_FileOptions options = HighLightingManager.GetFileOptions(pth + @"\SettingsDB\fbsttings.mtdb", FileType);
			return options.FileTemple;
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
	}
}
