/*2025 01 11
 * MicroText Explorer
 * themedb.dll
 * MengFX
 * FirstScreenThemeDBManager
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroText.FirstScreenThemeDatabase
{
    public class FirstScreenThemeDBManager
    {
        public string CreateDBFile(string path)
		{
            string ret = null;
			try
			{
				if (path == null)
				{
					path = Environment.CurrentDirectory + @"\NEWFirstScreenThemeDB.mtdb";
				}
				byte[] FileByte = new byte[0];
				FileByte = bc.addByteArray(FileByte, bc.stb("FSTB"));
				FileByte = bc.addByteArray(FileByte, new byte[2] { 0, 0 });
				File.WriteAllBytes(path, FileByte);
			}
			catch (Exception e)
			{
				ret = e.Message;
			}
            return ret;
		}
		public FirstScreenSettings[] GetDBFileSettings(string path)
		{
			FirstScreenSettings[] ret = new FirstScreenSettings[0];
			List<FirstScreenSettings> item = new List<FirstScreenSettings>();
			byte[] FileByte = File.ReadAllBytes(path);
			FileByte = bc.RemoveItem(FileByte, 6);
			List<byte[]> FScreenSettingsByteList = new List<byte[]>();
			FScreenSettingsByteList = bc.SplitByteArray(FileByte, 0xFF, true);
			foreach (byte[] _item in FScreenSettingsByteList)
			{
				item.Add(new FirstScreenSettings(_item));
			}
			ret = item.ToArray();
			return ret;
		}
		public string AddItem(string path, FirstScreenSettings f)
		{
			string ret = null;
			try
			{
				byte[] item = f.CompileToByteArray();
				byte[] FileByte = File.ReadAllBytes(path);
				FileByte = bc.addByteArray(FileByte, new byte[1] { 0xFF });
				FileByte = bc.addByteArray(FileByte, item);
				File.WriteAllBytes(path, FileByte);
			}
			catch (Exception e)
			{
				ret = e.Message;
			}
			return ret;
		}
		public string DeleteAll(string path)
		{
			string ret = null;
			try
			{
				File.WriteAllBytes(path, new byte[0]);
				CreateDBFile(path);
			}
			catch (Exception e)
			{
				ret = e.Message;
			}
			return ret;
		}
    }

	public static class bc
	{
		public static byte[] addByteArray(byte[] byte1, byte[] byte2)
		{
			byte[] ret = new byte[byte1.Length + byte2.Length];
			for (int i = 0; i < byte1.Length; i++)
			{
				ret[i] = byte1[i];
			}
			for (int i = 0; i < byte2.Length; i++)
			{
				ret[i + byte1.Length] = byte2[i];
			}
			return ret;
		}
		public static byte[] overrideByteArray(byte[] byte1, byte[] byte2, int StartIndex, int overrideLength)
		{
			byte[] ret = byte1;
			if (overrideLength == -1)
			{
				overrideLength = byte2.Length;
			}
			for (int i = 0; i < overrideLength; i++)
			{
				ret[i + StartIndex] = byte2[i];
			}
			return ret;
		}
		public static List<byte[]> SplitByteArray(byte[] InputArray, byte s, bool JumpEmptyItem)
		{
			List<byte[]> ret = new List<byte[]>();
			byte[] item = new byte[0];
			for (int i = 0; i < InputArray.Length; i++)
			{
				if (InputArray[i] == s)
				{
					if (JumpEmptyItem == true && item.Length == 0)
					{
						//Nothing
					}
					else
					{
						ret.Add(item);
						item = new byte[0];
					}
				}
				else
				{
					item = addByteArray(item, new byte[1] { InputArray[i] });
					if (i == InputArray.Length - 1)
					{
						ret.Add(item);
						item = new byte[0];
					}
				}
			}
			return ret;
		}
		public static byte[] stb(string input)
		{
			return System.Text.Encoding.ASCII.GetBytes(input);
		}
		public static byte[] itb(int input)
		{
			return BitConverter.GetBytes(input);
		}
		public static string bts(byte[] input)
		{
			return System.Text.Encoding.ASCII.GetString(input);
		}
		public static int bti(byte[] input)
		{
			return BitConverter.ToInt32(input, 0);
		}
		public static byte[] RemoveItem(byte[] Input, int length)
		{
			byte[] ret = new byte[0];
			List<byte> temp = Input.ToList();
			for (int i = 0; i < length; i++)
			{
				temp.RemoveAt(0);
			}
			ret = temp.ToArray();
			return ret;
		}
	}

	public class FirstScreenSettings
	{
		public FirstScreenSettings() { }
		public FirstScreenSettings(byte[] Array)
		{
			FromByteArray(Array);
		}
		public void FromByteArray(byte[] Array)
		{
			List<byte[]> item = bc.SplitByteArray(Array, 0xFE, true);
			TeamLabelText = bc.bts(item[0]);
			ProgramLabelText = bc.bts(item[1]);
			CopyrightLabelText = bc.bts(item[2]);
			VersionLabelText = bc.bts(item[3]);
			width = bc.bti(item[4]);
			height = bc.bti(item[5]);
			TeamLabelX = bc.bti(item[6]);
			TeamLabelY = bc.bti(item[7]);
			ProgramLabelX = bc.bti(item[8]);
			ProgramLabelY = bc.bti(item[9]);
			CopyrightLabelX = bc.bti(item[10]);
			CopyrightLabelY = bc.bti(item[11]);
			VersionLabelX = bc.bti(item[12]);
			VersionLabelY = bc.bti(item[13]);
			FontFamily = bc.bts(item[14]);
			TeamLabelSize = bc.bti(item[15]);
			ProgramLabelSize = bc.bti(item[16]);
			CopyrightLabelSize = bc.bti(item[17]);
			VersionLabelSize = bc.bti(item[18]);
			TeamLabelColor = Color.FromName(bc.bts(item[19]));
			ProgramLabelColor = Color.FromName(bc.bts(item[20]));
			CopyrightLabelColor = Color.FromName(bc.bts(item[21]));
			VersionLabelColor = Color.FromName(bc.bts(item[22]));
			imagePath = bc.bts(item[23]);
		}
		public byte[] CompileToByteArray()
		{
			byte[] ret = new byte[0];
			ret = bc.addByteArray(ret, bc.stb(TeamLabelText));
			ret = bc.addByteArray(ret, new byte[1]{ 0xFE });
			ret = bc.addByteArray(ret, bc.stb(ProgramLabelText));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(CopyrightLabelText));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(VersionLabelText));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(width));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(height));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(TeamLabelX));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(TeamLabelY));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(ProgramLabelX));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(ProgramLabelY));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(CopyrightLabelX));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(CopyrightLabelY));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(VersionLabelX));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(VersionLabelY));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(FontFamily));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(TeamLabelSize));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(ProgramLabelSize));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(CopyrightLabelSize));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(VersionLabelSize));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(TeamLabelColor.Name));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(ProgramLabelColor.Name));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(CopyrightLabelColor.Name));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(VersionLabelColor.Name));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(imagePath));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			return ret;
		}
		#region Var
		public string TeamLabelText;
		public string ProgramLabelText;
		public string CopyrightLabelText;
		public string VersionLabelText;
		public int width;
		public int height;
		public int TeamLabelX;
		public int TeamLabelY;
		public int ProgramLabelX;
		public int ProgramLabelY;
		public int CopyrightLabelX;
		public int CopyrightLabelY;
		public int VersionLabelX;
		public int VersionLabelY;
		public string FontFamily;
		public int TeamLabelSize;
		public int ProgramLabelSize;
		public int CopyrightLabelSize;
		public int VersionLabelSize;
		public Color TeamLabelColor;
		public Color ProgramLabelColor;
		public Color CopyrightLabelColor;
		public Color VersionLabelColor;
		public string imagePath;
		#endregion Var
	}
}
