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

namespace MicroText.FileBindThemeDB
{
	public class FileBindThemeDBManager
	{
		public string CreateDBFile(string path)
		{
			string ret = null;
			try
			{
				if (path == null)
				{
					path = Environment.CurrentDirectory + @"\NEWFileBindThemeDB.mtdb";
				}
				byte[] FileByte = new byte[0];
				FileByte = bc.addByteArray(FileByte, bc.stb("FBTB"));
				FileByte = bc.addByteArray(FileByte, new byte[2] { 0, 0 });
				File.WriteAllBytes(path, FileByte);
			}
			catch (Exception e)
			{
				ret = e.Message;
			}
			return ret;
		}
		public m_FileOptions[] GetDBFileSettings(string path)
		{
			m_FileOptions[] ret = new m_FileOptions[0];
			List<m_FileOptions> item = new List<m_FileOptions>();
			byte[] FileByte = File.ReadAllBytes(path);
			FileByte = bc.RemoveItem(FileByte, 6);
			List<byte[]> FScreenSettingsByteList = new List<byte[]>();
			FScreenSettingsByteList = bc.SplitByteArray(FileByte, 0xFF, true);
			foreach (byte[] _item in FScreenSettingsByteList)
			{
				item.Add(new m_FileOptions(_item));
			}
			ret = item.ToArray();
			return ret;
		}
		public string AddItem(string path, m_FileOptions f)
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
			//try
			//{
				File.WriteAllBytes(path, new byte[0]);
				CreateDBFile(path);
			//}
			//catch (Exception e)
			//{
			//	ret = e.Message;
			//}
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

	public class m_FileOptions
	{
		public m_FileOptions() { }
		public m_FileOptions(byte[] Array)
		{
			FromByteArray(Array);
		}
		public m_FileOptions(string _FileType, string _FileLanguageFileName, string _FileTemple)
		{
			FileType = _FileType;
			FileLanguageFileName = _FileLanguageFileName;
			FileTemple = _FileTemple;
		}
		public void FromByteArray(byte[] Array)
		{
			List<byte[]> item = bc.SplitByteArray(Array, 0xFE, true);
			FileType = bc.bts(item[0]);
			FileLanguageFileName = bc.bts(item[1]);
			FileTemple = bc.bts(item[2]);
		}
		public byte[] CompileToByteArray()
		{
			byte[] ret = new byte[0];
			ret = bc.addByteArray(ret, bc.stb(FileType));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(FileLanguageFileName));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(FileTemple));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			return ret;
		}
		#region Var
		public string FileType;
		public string FileLanguageFileName;
		public string FileTemple = "none";
		#endregion Var
	}
}
