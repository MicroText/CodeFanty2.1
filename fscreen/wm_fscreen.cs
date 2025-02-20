/*2025 01 11
 * MicroText Explorer
 * fscreen.dll
 * MengFX
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroText.FirstScreenThemeDatabase;
using System.Threading;

namespace MicroText.fscreen
{
	public partial class wm_fscreen : Form
	{
		public wm_fscreen(string ThemeFilePath)
		{
			CheckForIllegalCrossThreadCalls = false;
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			FirstScreenThemeDBManager m_dbm = new FirstScreenThemeDBManager();

			FirstScreenSettings[] settings = m_dbm.GetDBFileSettings(ThemeFilePath);

			Random random = new Random();
			int index = random.Next(0, settings.Length);
			FirstScreenSettings theme = settings[index];
			InitializeComponent();
			this.Width = theme.width;
			this.Height = theme.height;
			m_TeamLabel.Location = new Point(theme.TeamLabelX, theme.TeamLabelY);
			m_ProgramLabel.Location = new Point(theme.ProgramLabelX, theme.ProgramLabelY);
			m_CopyrightLabel.Location = new Point(theme.CopyrightLabelX, theme.CopyrightLabelY);
			m_VersionLabel.Location = new Point(theme.VersionLabelX, theme.VersionLabelY);
			m_TeamLabel.Font = new Font(theme.FontFamily, theme.TeamLabelSize);
			m_ProgramLabel.Font = new Font(theme.FontFamily, theme.ProgramLabelSize);
			m_CopyrightLabel.Font = new Font(theme.FontFamily, theme.CopyrightLabelSize);
			m_VersionLabel.Font = new Font(theme.FontFamily, theme.VersionLabelSize);
			m_TeamLabel.ForeColor = theme.TeamLabelColor;
			m_ProgramLabel.ForeColor = theme.ProgramLabelColor;
			m_CopyrightLabel.ForeColor = theme.CopyrightLabelColor;
			m_VersionLabel.ForeColor = theme.VersionLabelColor;
			this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\Image\" + theme.imagePath);
			m_TeamLabel.Text = theme.TeamLabelText;
			m_ProgramLabel.Text = theme.ProgramLabelText;
			m_CopyrightLabel.Text = theme.CopyrightLabelText;
			m_VersionLabel.Text = theme.VersionLabelText;

			Thread t = new Thread(ClockToExit);
			t.Start();
		}

		private void ClockToExit()
		{
			Thread.Sleep(2000);
			this.Close();
		}
	}
}
