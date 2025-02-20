/*2025 01 22
 * MicroText Explorer
 * themedb.dll
 * MengFX
 * TextEditorThemeDBManager
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroText.TextEditorThemeDataBase
{
	public class TextEditorThemeDBManager
	{
		public string CreateDBFile(string path)
		{
			string ret = null;
			try
			{
				if (path == null)
				{
					path = Environment.CurrentDirectory + @"\NEWTextEditorThemeDB.mtdb";
				}
				byte[] FileByte = new byte[0];
				FileByte = bc.addByteArray(FileByte, bc.stb("TETB"));
				FileByte = bc.addByteArray(FileByte, new byte[2] { 0, 0 });
				File.WriteAllBytes(path, FileByte);
			}
			catch (Exception e)
			{
				ret = e.Message;
			}
			return ret;
		}
		public TextEditorSettings GetDBFileSettings(string path)
		{
			TextEditorSettings ret = new TextEditorSettings();
			byte[] FileByte = File.ReadAllBytes(path);
			FileByte = bc.RemoveItem(FileByte, 4);
			ret = new TextEditorSettings(FileByte);
			return ret;
		}
		public string SaveItem(string path, TextEditorSettings f)
		{
			string ret = null;
			try
			{
				byte[] item = f.CompileToByteArray();
				byte[] FileByte = new byte[0];
				FileByte = bc.addByteArray(FileByte, bc.stb("TETB"));
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
		public static int bti16(byte[] input)
		{
			return BitConverter.ToInt16(input, 0);
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

	public class TextEditorSettings
	{
		public TextEditorSettings() { }
		public TextEditorSettings(byte[] Array)
		{
			FromByteArray(Array);
		}
		public void FromByteArray(byte[] Array)
		{
			List<byte[]> item = bc.SplitByteArray(Array, 0xFE, true);
			FontSize = bc.bti(item[0]);
			FontFamily = bc.bts(item[1]);
			int i_ShowLineNum = bc.bti(item[2]);
			int i_Italic = bc.bti(item[3]);
			int i_Bold = bc.bti(item[4]);
			ShowLineNum = i_ShowLineNum != 0;
			Italic = i_Italic != 0;
			Bold = i_Bold != 0;
		}
		public byte[] CompileToByteArray()
		{
			int i_ShowLineNum = 0;
			int i_Italic = 0;
			int i_Bold = 0;

			if (ShowLineNum) { i_ShowLineNum = 1; }
			if (Italic) { i_Italic = 1; }
			if (Bold) { i_Bold = 1; }

			byte[] ret = new byte[0];
			ret = bc.addByteArray(ret, bc.itb(FontSize));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.stb(FontFamily));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(i_ShowLineNum));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(i_Italic));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			ret = bc.addByteArray(ret, bc.itb(i_Bold));
			ret = bc.addByteArray(ret, new byte[1] { 0xFE });
			return ret;
		}
		#region Var
		public int FontSize = 0;
		public string FontFamily = "Consolas";
		public bool ShowLineNum = true;
		public bool Italic = false;
		public bool Bold = false;
		#endregion Var
	}
}
