using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroText.TextEditorThemeDataBase;
using MicroText.FileBindThemeDB;
namespace main
{
	public partial class wm_SettingsDialog : Form
	{
		private string pth = Environment.CurrentDirectory;
		private PropertyGrid_TextEditorSettings textEditorSettings;
		public bool IsCancel = true;
		List<m_FileOptions> _FileOptions = new List<m_FileOptions>();
		public wm_SettingsDialog()
		{
			InitializeComponent();
			textEditorSettings = new PropertyGrid_TextEditorSettings();
			TextEditorThemeDBManager m_dbm = new TextEditorThemeDBManager();
			TextEditorSettings settings = m_dbm.GetDBFileSettings(pth + @"\SettingsDB\testtings.mtdb");
			textEditorSettings.FontSize = settings.FontSize;
			textEditorSettings.FontFamily = settings.FontFamily;
			textEditorSettings.ShowLineNum = settings.ShowLineNum;
			textEditorSettings.Italic = settings.Italic;
			textEditorSettings.Bold = settings.Bold;
			grid_EditorSettings.SelectedObjects = new object[] { textEditorSettings };
			columnHeader1.Width = columnHeader2.Width = columnHeader3.Width = list_BindText.Width / 3;
			RefreshList();
		}
		public void RefreshList()
		{
			list_BindText.Items.Clear();
			FileBindThemeDBManager m_dbm = new FileBindThemeDBManager();
			m_FileOptions[] options = m_dbm.GetDBFileSettings(pth + @"\SettingsDB\fbsttings.mtdb");
			foreach (m_FileOptions item in options)
			{
				ListViewItem value = new ListViewItem(new string[3] { item.FileType, item.FileLanguageFileName, item.FileTemple });
				list_BindText.Items.Add(value);
				_FileOptions.Add(item);
			}
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			wm_SettingsDialog_NewHighLightRule dialog = new wm_SettingsDialog_NewHighLightRule();
			dialog.ShowDialog();

			if (dialog.IsCancel == false)
			{
				list_BindText.Items.Add(new ListViewItem(new string[3] { dialog.options.FileType, dialog.options.FileTemple, dialog.options.FileLanguageFileName }));
				_FileOptions.Add(dialog.options);
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (list_BindText.SelectedIndices.Count == 0)
			{
				MessageBox.Show("请选择项", "MicroText CodeFanty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("确定要删除吗?", "MicroText CodeFanty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					list_BindText.Items.RemoveAt(list_BindText.SelectedIndices[0]);
					_FileOptions.RemoveAt(list_BindText.SelectedIndices[0]);
				}
			}
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			TextEditorThemeDBManager m_bdbm = new TextEditorThemeDBManager();
			FileBindThemeDBManager m_fdbm = new FileBindThemeDBManager();
			TextEditorSettings settings = new TextEditorSettings();
			settings.FontSize = textEditorSettings.FontSize;
			settings.FontFamily = textEditorSettings.FontFamily;
			settings.ShowLineNum = textEditorSettings.ShowLineNum;
			settings.Italic = textEditorSettings.Italic;
			settings.Bold = textEditorSettings.Bold;
			m_bdbm.DeleteAll(pth + @"\SettingsDB\testtings.mtdb");
			m_bdbm.SaveItem(pth + @"\SettingsDB\testtings.mtdb", settings);
			m_fdbm.DeleteAll(pth + @"\SettingsDB\fbsttings.mtdb");
			foreach (m_FileOptions item in _FileOptions)
			{
				m_fdbm.AddItem(pth + @"\SettingsDB\fbsttings.mtdb", item);
			}
			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

	[DefaultProperty("TextEditorSettings")]
	public class PropertyGrid_TextEditorSettings
	{
		private int _FontSize = 0;
		private string _FontFamily = "Consolas";
		private bool _ShowLineNum = true;
		private bool _Italic = false;
		private bool _Bold = false;

		[Category("TextEditorSettings"), ReadOnly(false), Browsable(true), Description("编辑器的字体大小")]
		public int FontSize { get => _FontSize; set => _FontSize = value; }
		[Category("TextEditorSettings"), ReadOnly(false), Browsable(true), Description("编辑器的字体")]
		public string FontFamily { get => _FontFamily; set => _FontFamily = value; }
		[Category("TextEditorSettings"), ReadOnly(false), Browsable(true), Description("编辑器是否显示行号")]
		public bool ShowLineNum { get => _ShowLineNum; set => _ShowLineNum = value; }
		[Category("TextEditorSettings"), ReadOnly(false), Browsable(true), Description("编辑器的字体是否为斜体")]
		public bool Italic { get => _Italic; set => _Italic = value; }
		[Category("TextEditorSettings"), ReadOnly(false), Browsable(true), Description("编辑器的字体是否加粗")]
		public bool Bold { get => _Bold; set => _Bold = value; }
	}
}
