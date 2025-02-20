using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroText.FileBindThemeDB;

namespace ThemeDBOperate
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("BindFile : ");
			string _File = Console.ReadLine();
			FileBindThemeDBManager m_dbm = new FileBindThemeDBManager();

			while (true)
			{
				string input = Console.ReadLine();
				string[] CommandBlock = input.Split(new char[1] { ' ' });
				switch (CommandBlock[0])
				{
					case "deleteall": Console.WriteLine(m_dbm.DeleteAll(_File)); break;
					case "additem": m_dbm.AddItem(_File, new m_FileOptions(CommandBlock[1], CommandBlock[2], CommandBlock[3])); break;
					case "show":
						m_FileOptions[] options = m_dbm.GetDBFileSettings(_File);
						for (int i = 0; i < options.Length; i++)
						{
							Console.WriteLine("{0}\t{1}\t{2}\t", options[i].FileType, options[i].FileLanguageFileName, options[i].FileTemple);
						}
						break;
					default:
						break;
				}
			}
			//string pth = Environment.CurrentDirectory + @"\a.mtdb";

			//m_dbm.CreateDBFile(pth);
			////.asp;.aspx;.asax;.asmx;.ascx;.master
			//m_FileOptions options;
			//options = new m_FileOptions(".ASP", "ASPX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ASPX", "ASPX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ASMX", "ASPX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ASCX", "ASPX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ASAX", "ASPX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".MASTER", "ASPX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.s;.asm
			//options = new m_FileOptions(".S", "AssemblyLanguage.xshd", "ASM");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ASM", "AssemblyLanguage.xshd", "ASM");
			//m_dbm.AddItem(pth, options);
			////.boo
			//options = new m_FileOptions(".BOO", "Boo.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.atg
			//options = new m_FileOptions(".ATG", "Coco.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.c;.h;.cc;.cpp;.hpp
			//options = new m_FileOptions(".C", "cpp.xshd", "C");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".H", "cpp.xshd", "C");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".CPP", "cpp.xshd", "C");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".CC", "cpp.xshd", "C");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".HPP", "cpp.xshd", "C");
			//m_dbm.AddItem(pth, options);
			////.css
			//options = new m_FileOptions(".CSS", "CSS.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.htm;.html
			//options = new m_FileOptions(".HTM", "HTML.xshd", "HTML");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".HTML", "HTML.xshd", "HTML");
			//m_dbm.AddItem(pth, options);
			////.java
			//options = new m_FileOptions(".JAVA", "Java.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.js
			//options = new m_FileOptions(".JS", "JavaScript.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.json
			//options = new m_FileOptions(".JSON", "Json.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.md
			//options = new m_FileOptions(".MD", "Markdown.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.patch
			//options = new m_FileOptions(".PATCH", "Patch.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.php
			//options = new m_FileOptions(".PHP", "PHP.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.ps1;.psm1;.psd1
			//options = new m_FileOptions(".PS1", "Powershell.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".PSM1", "Powershell.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".PSD1", "Powershell.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.py;.pyw
			//options = new m_FileOptions(".PY", "Python.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".PYW", "Python.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.tex
			//options = new m_FileOptions(".TEX", "TEX.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.sql
			//options = new m_FileOptions(".SQL", "TSQL.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.vb
			//options = new m_FileOptions(".VB", "VB.xshd", "none");
			//m_dbm.AddItem(pth, options);
			////.xml;.xsl;.xslt;.xsd;.manifest;.config;.addin;.xshd;.wxs;.wxi;.wxl;.proj;.csproj;.vbproj;.ilproj;.booproj;.build;.xfrm;.targets;.xaml;.xpt;.xft;.map;.wsdl;.disco;.ps1xml;.nuspec
			//options = new m_FileOptions(".XML", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XSL", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XSLT", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XSD", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".MANIFEST", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".CONFIG", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ADDIN", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XSHD", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".WXS", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".WXI", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".WXL", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".PORJ", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".CSPORJ", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".VBPORJ", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".ILPROJ", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".BOOPROJ", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".BUILD", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XFRM", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".TARGETS", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XMAL", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XPT", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".XFT", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".MAP", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".WSDL", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".DISCO", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".PS1XML", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
			//options = new m_FileOptions(".NUSPEC", "XML.xshd", "none");
			//m_dbm.AddItem(pth, options);
		}
	}
}
