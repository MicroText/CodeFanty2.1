
using System.Drawing;
using System.Windows.Forms;

namespace main
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notify = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_New = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_SaveAnother = new System.Windows.Forms.ToolStripMenuItem();
			this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Undo = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Redo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Menu_Cut = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Paste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.Menu_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_NewWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_ScriptNum = new System.Windows.Forms.ToolStripComboBox();
			this.脚本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Run = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_EditScript = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_NewScript = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_DeleteScript = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_RenameScript = new System.Windows.Forms.ToolStripMenuItem();
			this.element = new System.Windows.Forms.Integration.ElementHost();
			this.dialog_OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.dialog_SaveFile = new System.Windows.Forms.SaveFileDialog();
			this.tim_RefreshScriptList = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notify
			// 
			this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
			this.notify.Visible = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cb_ScriptNum,
            this.脚本ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 29);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 文件FToolStripMenuItem
			// 
			this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_New,
            this.Menu_Open,
            this.toolStripSeparator,
            this.Menu_Save,
            this.Menu_SaveAnother});
			this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
			this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
			this.文件FToolStripMenuItem.Text = "文件(&F)";
			// 
			// Menu_New
			// 
			this.Menu_New.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Menu_New.Name = "Menu_New";
			this.Menu_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.Menu_New.Size = new System.Drawing.Size(165, 22);
			this.Menu_New.Text = "新建(&N)";
			this.Menu_New.Click += new System.EventHandler(this.Menu_New_Click);
			// 
			// Menu_Open
			// 
			this.Menu_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Menu_Open.Name = "Menu_Open";
			this.Menu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.Menu_Open.Size = new System.Drawing.Size(165, 22);
			this.Menu_Open.Text = "打开(&O)";
			this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(162, 6);
			// 
			// Menu_Save
			// 
			this.Menu_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Menu_Save.Name = "Menu_Save";
			this.Menu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.Menu_Save.Size = new System.Drawing.Size(165, 22);
			this.Menu_Save.Text = "保存(&S)";
			this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
			// 
			// Menu_SaveAnother
			// 
			this.Menu_SaveAnother.Name = "Menu_SaveAnother";
			this.Menu_SaveAnother.Size = new System.Drawing.Size(165, 22);
			this.Menu_SaveAnother.Text = "另存为(&A)";
			this.Menu_SaveAnother.Click += new System.EventHandler(this.Menu_SaveAnother_Click);
			// 
			// 编辑EToolStripMenuItem
			// 
			this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Undo,
            this.Menu_Redo,
            this.toolStripSeparator3,
            this.Menu_Cut,
            this.Menu_Copy,
            this.Menu_Paste,
            this.toolStripSeparator4,
            this.Menu_SelectAll,
            this.toolStripSeparator1,
            this.Menu_Settings});
			this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
			this.编辑EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
			this.编辑EToolStripMenuItem.Text = "编辑(&E)";
			// 
			// Menu_Undo
			// 
			this.Menu_Undo.Name = "Menu_Undo";
			this.Menu_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.Menu_Undo.Size = new System.Drawing.Size(161, 22);
			this.Menu_Undo.Text = "撤消(&U)";
			this.Menu_Undo.Click += new System.EventHandler(this.Menu_Undo_Click);
			// 
			// Menu_Redo
			// 
			this.Menu_Redo.Name = "Menu_Redo";
			this.Menu_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.Menu_Redo.Size = new System.Drawing.Size(161, 22);
			this.Menu_Redo.Text = "重做(&R)";
			this.Menu_Redo.Click += new System.EventHandler(this.Menu_Redo_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
			// 
			// Menu_Cut
			// 
			this.Menu_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Menu_Cut.Name = "Menu_Cut";
			this.Menu_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.Menu_Cut.Size = new System.Drawing.Size(161, 22);
			this.Menu_Cut.Text = "剪切(&T)";
			this.Menu_Cut.Click += new System.EventHandler(this.Menu_Cut_Click);
			// 
			// Menu_Copy
			// 
			this.Menu_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Menu_Copy.Name = "Menu_Copy";
			this.Menu_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.Menu_Copy.Size = new System.Drawing.Size(161, 22);
			this.Menu_Copy.Text = "复制(&C)";
			this.Menu_Copy.Click += new System.EventHandler(this.Menu_Copy_Click);
			// 
			// Menu_Paste
			// 
			this.Menu_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Menu_Paste.Name = "Menu_Paste";
			this.Menu_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.Menu_Paste.Size = new System.Drawing.Size(161, 22);
			this.Menu_Paste.Text = "粘贴(&P)";
			this.Menu_Paste.Click += new System.EventHandler(this.Menu_Paste_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
			// 
			// Menu_SelectAll
			// 
			this.Menu_SelectAll.Name = "Menu_SelectAll";
			this.Menu_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.Menu_SelectAll.Size = new System.Drawing.Size(161, 22);
			this.Menu_SelectAll.Text = "全选(&A)";
			this.Menu_SelectAll.Click += new System.EventHandler(this.Menu_SelectAll_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
			// 
			// Menu_Settings
			// 
			this.Menu_Settings.Name = "Menu_Settings";
			this.Menu_Settings.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.Menu_Settings.Size = new System.Drawing.Size(161, 22);
			this.Menu_Settings.Text = "设置";
			this.Menu_Settings.Click += new System.EventHandler(this.Menu_Settings_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_NewWindow,
            this.Menu_Exit,
            this.Menu_About});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 25);
			this.toolStripMenuItem1.Text = "窗口(&W)";
			// 
			// Menu_NewWindow
			// 
			this.Menu_NewWindow.Name = "Menu_NewWindow";
			this.Menu_NewWindow.Size = new System.Drawing.Size(141, 22);
			this.Menu_NewWindow.Text = "创建新窗口";
			this.Menu_NewWindow.Click += new System.EventHandler(this.Menu_NewWindow_Click);
			// 
			// Menu_Exit
			// 
			this.Menu_Exit.Name = "Menu_Exit";
			this.Menu_Exit.Size = new System.Drawing.Size(141, 22);
			this.Menu_Exit.Text = "退出(Alt-F4)";
			// 
			// Menu_About
			// 
			this.Menu_About.Name = "Menu_About";
			this.Menu_About.Size = new System.Drawing.Size(141, 22);
			this.Menu_About.Text = "关于(&A)";
			this.Menu_About.Click += new System.EventHandler(this.Menu_About_Click);
			// 
			// cb_ScriptNum
			// 
			this.cb_ScriptNum.Name = "cb_ScriptNum";
			this.cb_ScriptNum.Size = new System.Drawing.Size(121, 25);
			// 
			// 脚本ToolStripMenuItem
			// 
			this.脚本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Run,
            this.Menu_EditScript,
            this.Menu_NewScript,
            this.Menu_DeleteScript,
            this.Menu_RenameScript});
			this.脚本ToolStripMenuItem.Name = "脚本ToolStripMenuItem";
			this.脚本ToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
			this.脚本ToolStripMenuItem.Text = "脚本(&S)";
			// 
			// Menu_Run
			// 
			this.Menu_Run.Name = "Menu_Run";
			this.Menu_Run.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.Menu_Run.Size = new System.Drawing.Size(256, 22);
			this.Menu_Run.Text = "运行";
			this.Menu_Run.Click += new System.EventHandler(this.Menu_Run_Click);
			// 
			// Menu_EditScript
			// 
			this.Menu_EditScript.Name = "Menu_EditScript";
			this.Menu_EditScript.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.Menu_EditScript.Size = new System.Drawing.Size(256, 22);
			this.Menu_EditScript.Text = "编辑当前脚本";
			this.Menu_EditScript.Click += new System.EventHandler(this.Menu_EditScript_Click);
			// 
			// Menu_NewScript
			// 
			this.Menu_NewScript.Name = "Menu_NewScript";
			this.Menu_NewScript.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
			this.Menu_NewScript.Size = new System.Drawing.Size(256, 22);
			this.Menu_NewScript.Text = "新建脚本";
			this.Menu_NewScript.Click += new System.EventHandler(this.Menu_NewScript_Click);
			// 
			// Menu_DeleteScript
			// 
			this.Menu_DeleteScript.Name = "Menu_DeleteScript";
			this.Menu_DeleteScript.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
			this.Menu_DeleteScript.Size = new System.Drawing.Size(256, 22);
			this.Menu_DeleteScript.Text = "删除当前脚本";
			this.Menu_DeleteScript.Click += new System.EventHandler(this.Menu_DeleteScript_Click);
			// 
			// Menu_RenameScript
			// 
			this.Menu_RenameScript.Name = "Menu_RenameScript";
			this.Menu_RenameScript.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
			this.Menu_RenameScript.Size = new System.Drawing.Size(256, 22);
			this.Menu_RenameScript.Text = "重命名当前脚本";
			this.Menu_RenameScript.Click += new System.EventHandler(this.Menu_RenameScript_Click);
			// 
			// element
			// 
			this.element.Dock = System.Windows.Forms.DockStyle.Fill;
			this.element.Location = new System.Drawing.Point(0, 29);
			this.element.Name = "element";
			this.element.Size = new System.Drawing.Size(800, 421);
			this.element.TabIndex = 1;
			this.element.Text = "     ";
			this.element.Child = null;
			// 
			// tim_RefreshScriptList
			// 
			this.tim_RefreshScriptList.Tick += new System.EventHandler(this.tim_RefreshScriptList_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.element);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notify;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 文件FToolStripMenuItem;
		private ToolStripMenuItem Menu_New;
		private ToolStripMenuItem Menu_Open;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem Menu_Save;
		private ToolStripMenuItem Menu_SaveAnother;
		private ToolStripMenuItem 编辑EToolStripMenuItem;
		private ToolStripMenuItem Menu_Undo;
		private ToolStripMenuItem Menu_Redo;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem Menu_Cut;
		private ToolStripMenuItem Menu_Copy;
		private ToolStripMenuItem Menu_Paste;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem Menu_SelectAll;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem Menu_NewWindow;
		private ToolStripMenuItem Menu_Exit;
		private ToolStripComboBox cb_ScriptNum;
		private ToolStripMenuItem Menu_About;
		private System.Windows.Forms.Integration.ElementHost element;
		private OpenFileDialog dialog_OpenFile;
		private SaveFileDialog dialog_SaveFile;
		private Timer tim_RefreshScriptList;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem Menu_Settings;
		private ToolStripMenuItem 脚本ToolStripMenuItem;
		private ToolStripMenuItem Menu_Run;
		private ToolStripMenuItem Menu_EditScript;
		private ToolStripMenuItem Menu_NewScript;
		private ToolStripMenuItem Menu_DeleteScript;
		private ToolStripMenuItem Menu_RenameScript;
	}
}

