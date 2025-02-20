/*
 * 20250122
 * MicroText
 * Mengfx
 * Codefanty.main
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ICSharpCode.AvalonEdit;
using MicroText.TextEditorThemeDataBase;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using MicroText.FileType;
using MicroText.FileBindThemeDB;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace main
{
	public partial class Form1 : Form
	{
		string pth = Environment.CurrentDirectory;
		string assemblyLocation = Assembly.GetExecutingAssembly().Location;
		TextEditor te = new TextEditor();
		string FileName;
		bool IsSave = true;
		string TempText;
		string[] Temp_ScriptFileList = new string[0];
		string ScriptsDictionary;

		public Form1(string FilePath)
		{
			InitializeComponent();
			BindIcon();
			element.Child = te;

			//
			//TextEditorThemeDBManager m_tedb = new TextEditorThemeDBManager();
			//m_tedb.CreateDBFile(pth + @"\testtings.mtdb");
			//TextEditorSettings settings = new TextEditorSettings();
			//settings.FontSize = 15;
			//m_tedb.SaveItem(pth + @"\testtings.mtdb", settings);

			InitTextEditor();
			if (FilePath != "none")
			{
				FileName = FilePath;
				te.Text = TempText = File.ReadAllText(FileName);
			}
			else
			{
				FileName = pth + @"\Noname.txt";
				te.Text = TempText = File.ReadAllText(FileName);
			}

			te.TextChanged += Te_TextChanged;
			RefreshTitle();

			tim_RefreshScriptList.Start();
		}

		private void Te_TextChanged(object sender, EventArgs e)
		{
			if (te.Text != TempText)
			{
				IsSave = false;
				RefreshTitle();
			}
			else
			{
				IsSave = true;
				RefreshTitle();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (DateTime.Now.Month == 10 && DateTime.Now.Day == 1)
			{
				notify.Icon = new Icon(pth + @"\Ico\PRC.ico");
				notify.Text = null;
				notify.BalloonTipIcon = ToolTipIcon.None;
				notify.BalloonTipText = string.Format("热烈庆祝中华人民共和国成立{0}周年!", DateTime.Now.Year - 1949);
				notify.ShowBalloonTip(5000);
			}
		}

		private void BindIcon()
		{
			Menu_New.Image = Image.FromFile(pth + @"\Image\New.png");
			Menu_Open.Image = Image.FromFile(pth + @"\Image\Open.png");
			Menu_Save.Image = Image.FromFile(pth + @"\Image\Save.png");
			Menu_Cut.Image = Image.FromFile(pth + @"\Image\Cut.png");
			Menu_Copy.Image = Image.FromFile(pth + @"\Image\Copy.png");
			Menu_Paste.Image = Image.FromFile(pth + @"\Image\Paste.png");
			Menu_About.Image = Image.FromFile(pth + @"\Image\MicroText Linear 200x200.bmp");
		}

		private void InitTextEditor()
		{
			TextEditorThemeDBManager m_tedb = new TextEditorThemeDBManager();
			TextEditorSettings settings = m_tedb.GetDBFileSettings(pth + @"\SettingsDB\testtings.mtdb");
			te.FontFamily = new System.Windows.Media.FontFamily(settings.FontFamily);
			te.FontSize = settings.FontSize;
			if (settings.Italic)
			{
				te.FontStyle = System.Windows.FontStyles.Italic;
			}
			if (settings.Bold)
			{
				te.FontWeight = System.Windows.FontWeights.Bold;
			}
			//显示行号
			te.ShowLineNumbers = settings.ShowLineNum;
			//设置搜索
			ICSharpCode.AvalonEdit.Search.SearchPanel.Install(te);
		}

		private void Menu_NewWindow_Click(object sender, EventArgs e)
		{
			ProcessStartInfo psi = new ProcessStartInfo();
			psi.FileName = assemblyLocation;
			psi.Arguments = "none nofs";
			Process.Start(psi);
			//Process.Start(assemblyLocation);
		}

		private void Menu_New_Click(object sender, EventArgs e)
		{
			if (!IsSave)
			{
				DialogResult result;
				result = MessageBox.Show("是否保存?", "MicroText CodeFanty", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					Save();
					IsSave = true;
					RefreshTitle();
					NewFile();
				}
				else if (result == DialogResult.No)
				{
					NewFile();
				}
				else
				{
					//Nothing
				}
			}
			else
			{
				NewFile();
			}
		}

		private void NewFile()
		{
			wm_NewFileDialog m_wm_NewFileDialog = new wm_NewFileDialog(true, null);
			m_wm_NewFileDialog.ShowDialog();
			if (m_wm_NewFileDialog.IsCancel == false)
			{
				FileName = m_wm_NewFileDialog.filepath;
				IsSave = true;
				TempText = te.Text = File.ReadAllText(FileName);
				RefreshTitle();
				LoadHighLingting();
			}
		}

		private void OpenFile()
		{
			if (dialog_OpenFile.ShowDialog() == DialogResult.OK)
			{
				FileName = dialog_OpenFile.FileName;
				IsSave = true;
				TempText = te.Text = File.ReadAllText(FileName);
				RefreshTitle();
				LoadHighLingting();
			}
		}

		private void RefreshTitle()
		{
			this.Text = "MicroText CodeFanty - " + Path.GetFileName(FileName);
			if (!IsSave)
			{
				this.Text += "*";
			}
		}

		private void Menu_Open_Click(object sender, EventArgs e)
		{
			if (!IsSave)
			{
				DialogResult result;
				result = MessageBox.Show("是否保存?", "MicroText CodeFanty", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					Save();
					OpenFile();
				}
				else if (result == DialogResult.No)
				{
					OpenFile();
				}
				else
				{
					//Nothing
				}
			}
			else
			{
				OpenFile();
			}
		}

		private void Save()
		{
			File.WriteAllText(FileName, te.Text);
			RefreshTitle();
			TempText = te.Text;
		}

		private void Menu_Save_Click(object sender, EventArgs e)
		{
			Save();
			IsSave = true;
			RefreshTitle();
		}

		private void Menu_SaveAnother_Click(object sender, EventArgs e)
		{
			if (dialog_SaveFile.ShowDialog() == DialogResult.OK)
			{
				FileName = dialog_SaveFile.FileName;
				Save();
				RefreshTitle();
			}
		}

		private void Menu_Undo_Click(object sender, EventArgs e)
		{
			if (te.CanUndo)
			{
				te.Undo();
			}
		}

		private void Menu_Redo_Click(object sender, EventArgs e)
		{
			if (te.CanUndo)
			{
				te.Undo();
			}
		}

		private void Menu_Cut_Click(object sender, EventArgs e)
		{
			if (te.SelectionLength > 0)
			{
				te.Cut();
			}
		}

		private void Menu_Copy_Click(object sender, EventArgs e)
		{
			if (te.SelectionLength > 0)
			{
				te.Copy();
			}
		}

		private void Menu_Paste_Click(object sender, EventArgs e)
		{
			te.Paste();
		}

		private void Menu_SelectAll_Click(object sender, EventArgs e)
		{
			te.SelectAll();
		}

		private void LoadHighLingting()
		{
			//获取后缀名
			string FileType = Path.GetExtension(FileName).ToUpper();
			m_FileOptions options = HighLightingManager.GetFileOptions(pth + @"\SettingsDB\fbsttings.mtdb", FileType);
			te = SetHighLighting(options, te);
		}

		private TextEditor SetHighLighting(m_FileOptions options, TextEditor te)
		{
			if (options.FileLanguageFileName == "none")
			{
				te.SyntaxHighlighting = null;
			}
			else
			{
				try
				{
					XmlReader reader = XmlReader.Create(pth + @"\HighLighting\" + options.FileLanguageFileName);
					te.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);
				}
				catch
				{
					te.SyntaxHighlighting = null;
				}
			}
			return te;
		}

		private void LoadScripts()
		{
			ScriptsDictionary = File.ReadAllText(pth + @"\SettingsDB\ScriptPath.strdb");
			if (ScriptsDictionary == "" || ScriptsDictionary == null)
			{
				ScriptsDictionary = pth + @"\Scripts";
			}
			string[] ScriptsList = Directory.GetFiles(ScriptsDictionary);
			if (!CompareStringArrays(ScriptsList, Temp_ScriptFileList))
			{
				cb_ScriptNum.Items.Clear();
				foreach (string Script in ScriptsList)
				{
					cb_ScriptNum.Items.Add(Path.GetFileName(Script));
				}
				if (ScriptsList.Length > 0)
				{
					cb_ScriptNum.Text = Path.GetFileName(ScriptsList[0]); 
				}
				else
				{
					cb_ScriptNum.Text = null;
				}
				Temp_ScriptFileList = ScriptsList;
			}
		}

		private bool CompareStringArrays(string[] array1, string[] array2)
		{
			bool ret = true;
			if (array1.Length != array2.Length)
			{
				ret = false;
			}
			else
			{
				for (int i = 0; i < array1.Length; i++)
				{
					if (array1[i] != array2[i])
					{
						ret = false;
					}
				}
			}
			return ret;
		}

		private bool ExistsStringInArray(string item, string[] array)
		{
			bool ret = false;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == item)
				{
					ret = true;
				}
			}
			return ret;
		}

		private void tim_RefreshScriptList_Tick(object sender, EventArgs e)
		{
			LoadScripts();
		}

		private void Menu_Run_Click(object sender, EventArgs e)
		{
			Menu_Save_Click(null, null);
			if (!ExistsStringInArray(ScriptsDictionary + @"\" + cb_ScriptNum.Text, Temp_ScriptFileList))
			{
				MessageBox.Show("请输入正确的脚本名称");
			}
			else
			{
				string ScriptText = File.ReadAllText(ScriptsDictionary + @"\" + cb_ScriptNum.Text);
				ScriptText = ScriptText.Replace("%%dd%%", string.Format(@"'{0}\Tools\dd.exe'", pth));
				ScriptText = ScriptText.Replace("%%nasm%%", string.Format(@"'{0}\Tools\nasm.exe'", pth));
				File.WriteAllText(pth + @"\Start.bat", ScriptText);
				ProcessStartInfo info = new ProcessStartInfo();
				info.FileName = "cmd.exe";
				info.Arguments = "/c \"" + pth + @"\Start.bat" + "\"";
				
				Process.Start(info);
			}
		}

		private void Menu_NewScript_Click(object sender, EventArgs e)
		{
			wm_NewFileDialog dialog = new wm_NewFileDialog(false, ScriptsDictionary);
			dialog.ShowDialog();

			if (dialog.IsCancel == false)
			{
				ProcessStartInfo psi = new ProcessStartInfo();
				psi.FileName = assemblyLocation;
				dialog.filepath = dialog.filepath.Replace(' ', '%');
				psi.Arguments = dialog.filepath + " nofs";
				Process.Start(psi);
			}
		}

		private void Menu_EditScript_Click(object sender, EventArgs e)
		{
			if (!ExistsStringInArray(ScriptsDictionary + @"\" + cb_ScriptNum.Text, Temp_ScriptFileList))
			{
				MessageBox.Show("请输入正确的脚本名称", "MicroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ProcessStartInfo psi = new ProcessStartInfo();
				psi.FileName = assemblyLocation;
				string inputPath = ScriptsDictionary + @"\" + cb_ScriptNum.Text;
				inputPath = inputPath.Replace(' ', '%');
				psi.Arguments = inputPath + " nofs";
				Process.Start(psi);
			}
		}

		private void Menu_DeleteScript_Click(object sender, EventArgs e)
		{
			if (!ExistsStringInArray(ScriptsDictionary + @"\" + cb_ScriptNum.Text, Temp_ScriptFileList))
			{
				MessageBox.Show("请输入正确的脚本名称", "MicroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show(string.Format("确定要删除{0}吗?", cb_ScriptNum.Text), "MicroText", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					File.Delete(ScriptsDictionary + @"\" + cb_ScriptNum.Text);
				}
			}
		}

		private void Menu_RenameScript_Click(object sender, EventArgs e)
		{
			if (!ExistsStringInArray(ScriptsDictionary + @"\" + cb_ScriptNum.Text, Temp_ScriptFileList))
			{
				MessageBox.Show("请输入正确的脚本名称", "MicroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				wm_RenameFileDialog dialog = new wm_RenameFileDialog();
				dialog.ShowDialog();
				if (!dialog.IsCancel)
				{
					File.Move(ScriptsDictionary + @"\" + cb_ScriptNum.Text, ScriptsDictionary + @"\" + dialog.Rename);
				}
			}
		}

		private void Menu_Settings_Click(object sender, EventArgs e)
		{
			wm_SettingsDialog wm = new wm_SettingsDialog();
			wm.ShowDialog();
			InitTextEditor();
		}

		private void Menu_About_Click(object sender, EventArgs e)
		{
			Process.Start(pth + @"\about.exe");
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!IsSave)
			{
				DialogResult result;
				result = MessageBox.Show("是否保存?", "MicroText CodeFanty", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					Save();
					e.Cancel = false;
				}
				else if (result == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
				else
				{
					e.Cancel = false;
				}
			}
		}
	}
}
