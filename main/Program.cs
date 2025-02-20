using System;
using System.Windows.Forms;
using MicroText.fscreen;

namespace main
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string path = Environment.CurrentDirectory + @"\SettingsDB\fsttings.mtdb";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run(new wm_SettingsDialog());
			//Application.Exit();

			if (args.Length == 0)
			{
				Application.Run(new wm_fscreen(path));
				Application.Run(new Form1("none"));
			}
			else if (args.Length == 1)
			{
				//MessageBox.Show(args[0]);
				Application.Run(new wm_fscreen(path));
				Application.Run(new Form1(args[0].Replace('%', ' ')));
			}
			else if (args.Length == 2 && args[1] == "nofs")
			{
				//MessageBox.Show("2" + args[0] + args[1]);
				Application.Run(new Form1(args[0].Replace('%', ' ')));
			}
			else
			{
				//for (int i = 0; i < args.Length; i++)
				//{
				//	MessageBox.Show(args[i]);
				//}
				Application.Run(new wm_fscreen(path));
				Application.Run(new Form1("none"));
			}
			//m_FirstScreenManager m_fsManager = new m_FirstScreenManager();
			//m_fsManager.CreateDatabaseFile(null);
			//FirstScreenThemeDBManager m_fsdb = new FirstScreenThemeDBManager();
			//MessageBox.Show(m_fsdb.CreateDBFile(path));
			//FirstScreenSettings item = new FirstScreenSettings();
			//item.width = 800;
			//item.height = 500;
			//item.TeamLabelX = 38;
			//item.TeamLabelY = 48;
			//item.ProgramLabelX = 28;
			//item.ProgramLabelY = 90;
			//item.CopyrightLabelX = 38;
			//item.CopyrightLabelY = 175;
			//item.VersionLabelX = 700;
			//item.VersionLabelY = 475;
			//item.FontFamily = "Microsoft YaHei UI";
			//item.TeamLabelSize = 18;
			//item.ProgramLabelSize = 36;
			//item.CopyrightLabelSize = 10;
			//item.VersionLabelSize = 12;
			//item.TeamLabelColor = Color.FromName("White");
			//item.ProgramLabelColor = Color.FromName("White");
			//item.CopyrightLabelColor = Color.FromName("White");
			//item.VersionLabelColor = Color.FromName("White");
			//item.imagePath = "Default.jpeg";
			//item.TeamLabelText = "MicroText Explorer";
			//item.ProgramLabelText = "CodeFanty";
			//item.VersionLabelText = "1.0";
			//item.CopyrightLabelText = "Copyright by MicroText All Rights Reserived";
			//MessageBox.Show(m_fsdb.AddItem(path, item));
			////item = m_fsdb.GetDBFileSettings(path)[0];
			////MessageBox.Show("");
		}
	}
}
