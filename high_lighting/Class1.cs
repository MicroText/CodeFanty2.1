using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using MicroText.FileBindThemeDB;

namespace MicroText.FileType
{
    public static class HighLightingManager
    {
		public static m_FileOptions GetFileOptions(string dbFilePath, string _FileType)
		{
			m_FileOptions ret = new m_FileOptions();
			FileBindThemeDBManager m_dbm = new FileBindThemeDBManager();
			m_FileOptions[] options = m_dbm.GetDBFileSettings(dbFilePath);
			bool isFind = false;
			for (int i = 0; i < options.Length; i++)
			{
				if (options[i].FileType == _FileType)
				{
					isFind = true;
					ret = options[i];
				}
			}
			if (!isFind)
			{
				ret.FileLanguageFileName = "none";
				ret.FileType = _FileType;
				ret.FileTemple = "none";
			}
			return ret;
		}
    }
}
