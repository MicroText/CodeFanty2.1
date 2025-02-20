/*
 * 20250127
 * MicroText
 * Mengfx
 * Codefanty.main
 */
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
using MicroText.FileBindThemeDB;

namespace main
{
	public partial class wm_SettingsDialog_NewHighLightRule : Form
	{
		public bool IsCancel = true;
		private string HighLightFilePath = "none";
		private string TemplateFilePath = "none";
		private string pth = Environment.CurrentDirectory;
		public m_FileOptions options = new m_FileOptions() ;
		public wm_SettingsDialog_NewHighLightRule()
		{
			InitializeComponent();
		}

		private void btn_Explore_HighLight_Click(object sender, EventArgs e)
		{
			wm_HighLightManager wm = new wm_HighLightManager();
			wm.ShowDialog();
			if (wm.IsCancel == false)
			{
				HighLightFilePath = txt_HighLightFile.Text = Path.GetFileName(wm.SelectedItemPath);
			}
			//dialog_Open.FileName = "";
			//dialog_Open.Filter = "AvalonEdit高亮文件|*.xshd";
			//if (dialog_Open.ShowDialog() == DialogResult.OK)
			//{
			//	HighLightFilePath = dialog_Open.FileName;
			//	txt_HighLightFile.Text = Path.GetFileName(HighLightFilePath);
			//}
		}

		private void btn_Explore_FileTemple_Click(object sender, EventArgs e)
		{
			wm_TemplateManager wm = new wm_TemplateManager();
			wm.ShowDialog();
			if (wm.IsCancel == false)
			{
				TemplateFilePath = txt_FileTemplate.Text = Path.GetFileName(wm.SelectedItemPath);
			}
			//dialog_Open.FileName = "";
			//dialog_Open.Filter = "所有文件|*.*";
			//if (dialog_Open.ShowDialog() == DialogResult.OK)
			//{
			//	TempleFilePath = dialog_Open.FileName;
			//	HighLightFilePath = TempleFilePath;
			//	txt_FileTemple.Text = Path.GetFileName(TempleFilePath);
			//}
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			if (txt_FileType == null)
			{
				MessageBox.Show("文件类型不能为空", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (HighLightFilePath != "none")
				{
					//File.Copy(HighLightFilePath, pth + @"\HighLighting\" + TemplateFilePath);
					options.FileLanguageFileName = TemplateFilePath;
				}
				else
				{
					options.FileLanguageFileName = "none";
				}
				if (HighLightFilePath != "none")
				{
					//File.Copy(HighLightFilePath, pth + @"\HighLighting\" + Path.GetFileName(HighLightFilePath));
					options.FileTemple = Path.GetFileName(HighLightFilePath);
				}
				else
				{
					options.FileTemple = "none";
				}
				options.FileType = txt_FileType.Text.ToUpper();
				IsCancel = false;
				this.Close();
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			IsCancel = true;
			this.Close();
		}
	}
}
