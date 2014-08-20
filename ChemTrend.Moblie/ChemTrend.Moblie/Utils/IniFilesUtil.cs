using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace ChemTrend.Barcode.Utils
{  
    /// <summary>  
    /// IniFiles的类  
    /// 使用方法 
    /// 写信息文件 
    /// IniFile NewIni = new IniFile(ApplicationPath + "\\Test.ini"); 
    /// NewIni.IniWriteValue("测试信息","测试一","1"); 
    /// 读取 
    /// IniFile NewIni = new IniFile(ApplicationPath + "\\Test.ini"); 
    /// string a = NewIni .IniReadValue("测试信息","测试一"); 
    /// 读取结果 
    /// a = 1
    /// </summary>  
    public class IniFilesUtil
    {
        public string path;
        //获取程序运行路径，最后不包含"/"
        public static String GetAppRunPath()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        }
        #region 写入信息文件
        private void WritePrivateProfileString(string ApplicationName, string KeyName, string Value, string FileName)
        {
            string[] iniItems = new string[0];
            string iniLines = null;
            string iniLine = null;
            string iniItem = null;
            int i, j;
            try
            {
                //读取INI文件； 
                System.IO.StreamReader iniFile = new System.IO.StreamReader(FileName, System.Text.Encoding.Default);
                iniLines = iniFile.ReadToEnd();
                iniFile.Close();
            }
            catch
            {
            }

            //如果信息文件还沒有任何內容，將节点写到第一行 
            if (iniLines == null)
            {
                StreamWriter CreatFile = File.CreateText(FileName);
                CreatFile.Close();
                StreamWriter FileWriter = new StreamWriter(FileName, true, System.Text.Encoding.Default);
                FileWriter.WriteLine("[" + ApplicationName + "]");
                FileWriter.WriteLine(KeyName + "=" + Value);
                FileWriter.Close();
                return;
            }
            else
            {
                //否则的话得到已有的节点 
                iniItems = System.Text.RegularExpressions.Regex.Split(iniLines, "\r\n");
            }

            //以回车符分割,得到每一行 
            bool HaveParentNode = false;
            string IniContent = "";
            int IndexLength = 0;
            if (iniItems[iniItems.Length - 1] == "")
            {
                IndexLength = iniItems.Length - 1;
            }
            else
            {
                IndexLength = iniItems.Length;
            }
            for (i = 0; i < IndexLength; i++)
            {
                iniItem = iniItems.ToString();
                if (iniItem[0] == '[' && iniItem[iniItem.Length - 1] == ']')
                {
                    if (IniContent == "")
                    {
                        IniContent = iniItems.ToString();
                    }
                    else
                    {
                        IniContent += "\r\n" + iniItems.ToString();
                    }
                    if (iniItems.ToString() == "[" + ApplicationName + "]")
                    {
                        HaveParentNode = true;
                        bool HaveNode = false;
                        try
                        {
                            //找到相对应的父节点的话，查找是否有对应的子节点 
                            for (j = (i + 1); j < IndexLength; j++)
                            {
                                iniLine = iniItems[j].Trim();
                                if (iniLine[0] == '[' && iniLine[iniLine.Length - 1] == ']')
                                {
                                    if (!HaveNode)
                                    {
                                        HaveNode = true;
                                        IniContent += "\r\n" + KeyName + "=" + Value;
                                    }
                                    break;
                                }

                                iniLine = iniItems[j].TrimStart().Replace(" ", "");
                                if (iniLine.Substring(0, Math.Min(KeyName.Length + 1, iniLine.Length)).ToUpper() == KeyName.ToUpper() + "=")
                                {
                                    //如果找到了Key匹配 
                                    HaveNode = true;
                                    IniContent += "\r\n" + KeyName + "=" + Value;
                                }
                                else
                                {
                                    IniContent += "\r\n" + iniItems[j].ToString();
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            ex.ToString();
                        }

                        if (!HaveNode)
                        {
                            HaveNode = true;
                            IniContent += "\r\n" + KeyName + "=" + Value;
                        }
                    }
                    else
                    {
                        for (j = (i + 1); j < IndexLength; j++)
                        {
                            iniLine = iniItems[j].Trim();
                            if (iniLine[0] == '[' && iniLine[iniLine.Length - 1] == ']')
                            {
                                break;
                            }
                            else
                            {
                                IniContent += "\r\n" + iniItems[j].ToString();
                            }
                        }
                    }
                }
            }

            if (!HaveParentNode)
            {
                IniContent += "\r\n[" + ApplicationName + "]";
                IniContent += "\r\n" + KeyName + "=" + Value;
            }

            StreamWriter ReplaceFile = File.CreateText(FileName);
            ReplaceFile.Close();
            StreamWriter ReplaceWriter = new StreamWriter(FileName, true, System.Text.Encoding.Default);
            ReplaceWriter.Write(IniContent);
            ReplaceWriter.Close();
        }
        #endregion

        #region 读取信息文件
        private string GetPrivateProfileString(string ApplicationName, string KeyName, string Default, string FileName)
        {
            string[] iniItems = new string[0];
            string iniLines;
            string iniLine;
            int i, j;
            try
            {
                //读取INI文件； 
                System.IO.StreamReader iniFile = new System.IO.StreamReader(FileName, System.Text.Encoding.Default);
                iniLines = iniFile.ReadToEnd();
                iniFile.Close();
            }
            catch
            {
                return Default;
            }
            //以回车符分割,得到每一行 
            iniItems = System.Text.RegularExpressions.Regex.Split(iniLines, "\r\n"); ;
            //遍历每一行 
            for (i = 0; i < iniItems.GetLength(0); i++)
            {
                //找到匹配值 
                if (iniItems[i].ToString().Trim().ToUpper() == '[' + ApplicationName.Trim().ToUpper() + ']')
                {
                    //从下一行开始搜索 
                    for (j = i + 1; j < iniItems.GetLength(0); j++)
                    {
                        iniLine = iniItems[j].Trim();
                        if (iniLine.Length > 0)
                        {
                            //如果找到了另一个段，那么就越段了，则返回默认值 
                            if (iniLine[0] == '[' && iniLine[iniLine.Length - 1] == ']') return Default;
                        }
                        //去掉所有空格 
                        iniLine = iniItems[j].TrimStart().Replace(" ", "");
                        if (iniLine.Substring(0, Math.Min(KeyName.Length + 1, iniLine.Length)).ToUpper() == KeyName.ToUpper() + "=")
                        {
                            //如果找到了Key匹配 
                            return iniItems[j].Substring(iniItems[j].IndexOf('=') + 1);
                        }
                    }
                    return Default;//没有找到key匹配的，则返回默认值 
                }
            }
            return Default;//返回默认值 
        }
        #endregion

        public IniFilesUtil(string INIPath)
        {
            path = INIPath;
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        public string IniReadValue(string Section, string Key)
        {
            return GetPrivateProfileString(Section, Key, "", this.path);
        }
    }
}
