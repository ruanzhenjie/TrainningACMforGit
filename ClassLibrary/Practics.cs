using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Panti
{

    public class Practics
    {

        public static string WorkingDirectory = @"IOResult";
        public static string CFileName = "CharisTest";
        public static string Compiler = @"CL.exe";

        private bool GenerateC(string strCode)
        {
            FileStream sFile = new FileStream(WorkingDirectory + "\\" + CFileName + ".c", FileMode.Create, FileAccess.Write);
            sFile.SetLength(0);
            StreamWriter sw = new StreamWriter(sFile);
            sw.Write(strCode);
            sw.Close();
            return true;
          
        }
        //编译
        private bool CompileCode()
        {
            try
            {
                if (!File.Exists(Compiler))
                {
                    throw new MyException("找不到编译器");
                }

                string strWholeCFilePath = WorkingDirectory + "\\" + CFileName + ".c";
                if (!File.Exists(strWholeCFilePath))
                {
                    throw new MyException("找不到C文件" + strWholeCFilePath);
                }

                Process p = new Process();
                p.StartInfo.FileName = Compiler;
                p.StartInfo.WorkingDirectory = WorkingDirectory;
                p.StartInfo.Arguments = "-o " + CFileName + ".exe" + CFileName + ".c";
                p.StartInfo.UseShellExecute = false;//不采用外部调用系统的Shell                                               
                p.StartInfo.RedirectStandardOutput = true;//输入输出流重定向到程序中
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string a = p.StandardOutput.ReadToEnd();
                //   编译正常除了警告外是不会有其他输出信息的
                int exitcode = p.ExitCode;
                //   而程序退出码则是判断是否成功编译的关键
                p.WaitForExit();
                p.Close();
                if (exitcode == 0)
                    return true;
                else
                    return false;
            }
            catch 
            {
               // MessageBox.Show(ex.StackTrace);
                return false;
            }
            
               
         }

        
        public  string Panti(string strCode,List<string[]> IOExampleList, double dblTimeLimited )
        {
                string strResult  = "Accept"; ;
                GenerateC(strCode);//将输入的代码导入生成C文件
            CompileCode();//编译C文件
            string strWholeExePath = WorkingDirectory + "\\" + CFileName + ".exe";
              if(!File.Exists(strWholeExePath))
            { 
                strResult = "Compiling does not pass";
                return strResult;
            }
            Process p2 = new Process();
                p2.StartInfo.FileName = WorkingDirectory + "\\" + CFileName + ".exe";
                p2.StartInfo.UseShellExecute = false;
                p2.StartInfo.RedirectStandardError = true;
                p2.StartInfo.RedirectStandardInput = true;
                p2.StartInfo.RedirectStandardOutput = true;
                p2.StartInfo.CreateNoWindow = true;
                 System.Diagnostics.Stopwatch stopwatch = new Stopwatch();

            //  you code ....

            //double hours = timespan.TotalHours; // 总小时
            //double minutes = timespan.TotalMinutes;  // 总分钟
            //

          
            int intLengthOFIOExampleList = IOExampleList.Count;
                foreach (string[] IOExample in IOExampleList)
                {

                stopwatch.Start(); //  开始监视代码运行时间
                p2.Start();
                    p2.StandardInput.WriteLine(IOExample[0]);
                    if (!String.Equals(p2.StandardOutput.ReadToEnd(), IOExample[1]))
                    {
                        strResult = "Wrong Answer";
                    break;
                    }
                stopwatch.Stop(); //  停止监视
                TimeSpan timespan = stopwatch.Elapsed; //  获取当前实例测量得出的总时间

                double dblSeconds = timespan.TotalSeconds;  //  总秒数
                if (dblSeconds > dblTimeLimited)
                {
                    strResult = "OverTime";
                    break;
                }
            }

            File.Delete(strWholeExePath);
                return strResult;            
        }
        class MyException : ApplicationException
        {
            //public MyException(){}
            public MyException(string message) : base(message) { }
            public override string Message
            {
                get
                {
                    return base.Message;
                }
            }
        }
    }
}

