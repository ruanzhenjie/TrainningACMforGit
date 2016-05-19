using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panti.Tests
{
    using System.IO;
    using System.Diagnostics;

    [TestClass()]
    public class PracticsTests
    {
        // 1.将C代码保存成文件  
        //2.Process.Start调用C编译器编译
        //3.检查是否生成相应的exe文件，如没有生成，则程序有问题
        //4.执行生成的exe文件，通过输出的结果判断程序是否有错。
        [TestMethod()]
        public void CompilingDoesNotPass()
        {
             
            string strCode = "#include<stdio.h> \nint main()\n{ int a, b\nscantf(\"%d %d\", &a, &b); \nprintf(\"%d\", a + b);\nreturn 0; \n}";
            List<string[] > IOExampleList = new List<string[]>();
            string[] strIOExample = new string[2] { "a", "b" }; 
            IOExampleList.Add(strIOExample);
            double dblTimeLimited = 1000;

            Practics practics= new Practics();
            string Actual = practics.Panti(strCode, IOExampleList, dblTimeLimited);
            string Result = "Compiling does not pass";
            Assert.AreEqual(Actual,Result);

        }
        [TestMethod]
        public void WrongAnswerOne()
        {

            //题目要求是实现加法运算，输出的程序实现的是减法运算。
             
            string strCode = "#include<stdio.h> \nint main()\n{ int a, b;\nscanf(\"%d %d\", &a, &b); \nprintf(\"%d\", a - b);\nreturn 0; \n}";
            List<string[]> IOExampleList = new List<string[]>();
            string[] strIOExample = new string[2] { "1 2", "3" };
            IOExampleList.Add(strIOExample);
            double dblTimeLimited = 1000;

            Practics practics= new Practics();
            string Actual = practics.Panti(strCode, IOExampleList, dblTimeLimited);
            string Result = "Wrong Answer";
            Assert.AreEqual(Actual, Result);
        }


        [TestMethod]
        public void SomeExampleWrongAnswer()
        {
            //题目要求的是实现乘法运算，输入的程序是加法运算，虽然能通过其中的部分测试用例，但是不能全部通过，所以还是wrong answer.
             
            string strCode = "#include<stdio.h> int main(){ int a, b;scantf(\"%d %d\", &a, &b); printf(\"%d\", a + b);return 0; }";
            List<string[]> IOExampleList = new List<string[]>();
            string[] strIOExample = new string[2] { "2 2", "4" };
            IOExampleList.Add(strIOExample);
            strIOExample[0] = "3 2";
            strIOExample[1] ="6";
            IOExampleList.Add(strIOExample);

            double dblTimeLimited = 1000;
            Practics practics= new Practics();
            string Actual = practics.Panti(strCode, IOExampleList, dblTimeLimited);
            string Result = "Wrong Answer";
            Assert.AreEqual(Actual, Result);
        }


        [TestMethod]
        public void OverTimeTest()
        {
            //题目要求的是计算1到n的累加的和，输入的程序使用的算法是用循序一次次累加。超时了
           
            string strCode = "#include<stdio.h>int main(){ long sum = 0;int num;scancf(\"%d\", num);for (int i = 1; i <= num; i++){sum += i;}printf(\"%d\", sum); }";
            List<string[]> IOExampleList = new List<string[]>();
            string[] strIOExample = new string[2] { "1", "1" };
            IOExampleList.Add(strIOExample);
            strIOExample[0] = "100";
            strIOExample[1] = "5050";
            IOExampleList.Add(strIOExample);
            strIOExample[0] = "1000";
            strIOExample[1] = "500500";
            IOExampleList.Add(strIOExample);

            double dblTimeLimited = 0.001;

            Practics practics= new Practics();
            string Actual = practics.Panti(strCode, IOExampleList, dblTimeLimited);
            string Result = "OverTime";
            Assert.AreEqual(Actual, Result);
        }
        [TestMethod]
        public void AcceptTest()
        {
            //题目要求的是计算1到n的累加的和，输入的程序使用的算法是用循序一次次累加。超时了
           
            string strCode = "#include<stdio.h>int main(){ long sum = 0; long num; scancf(\"%ld\", &num); sum = ((1 + n) * n) / 2; printf(\"%ld\", sum); return 0;}";
         
            List<string[]> IOExampleList = new List<string[]>();
            string[] strIOExample = new string[2] { "1", "1" };
            IOExampleList.Add(strIOExample);
            strIOExample[0] = "100";
            strIOExample[1] = "5050";
            IOExampleList.Add(strIOExample);
            strIOExample[0] = "1000";
            strIOExample[1] = "500500";
            IOExampleList.Add(strIOExample);

            double dblTimeLimited = 0.001;

            Practics practics= new Practics();
            string Actual = practics.Panti(strCode, IOExampleList, dblTimeLimited);
            string Result = "Accept";
            Assert.AreEqual(Actual, Result);
        }

    }
}
        /*
        public void GenerateCTest()
          {
              string Code = "#include<stdio.h>int main(){printf(\"I am Charis！\");return 0;}";
              Practics a = new Practics();
              bool Actual = a.GenerateC(Code);
              bool Result = true;
              Assert.AreEqual(Actual, Result);
          }

          [TestMethod()]
          public void CToExeSuccess()
          {
              string Code ="#include<stdio.h>int main(){printf(\"I am Charis！\");return 0;}";
              Practics a = new Practics();
              if (a.GenerateC(Code))
              {                
                  string Actual = a.CToExe();
                  string Result = "编译成功";
                  Assert.AreEqual(Actual, Result);
              }
          }
          [TestMethod()]
          public void RunExeTest()
          {
              string Code = "#include<stdio.h>\r\nint main(){\r\nint a, b;\r\nscanf(\"%d%d\", &a, &b);\r\nprintf(\"%d\", a+b);\r\nreturn 0;\r\n}";
              Practics a = new Practics();
              if (a.GenerateC(Code))
              {
                   a.CToExe();
                  Topic t = new Topic();
                  t.InputText = new String[3];
                  t.OutputText = new String[3];
                  t.InputText[0] = "1 2";
                  t.InputText[1] = "2 3";
                  t.InputText[2] = "3 4";
                  t.OutputText[0] = "3";
                  t.OutputText[1] = "5";
                  t.OutputText[2] = "7";

                  string Actual = a.RunExe(t);
                  string Result = "Wrong Answer!";
                  Assert.AreEqual(Actual,Result);
                  //string Result = "编译成功";
                 // Assert.AreEqual(Actual, Result);
              }
          }

  }
      */
        //[TestMethod()]
        //public void CToExeFail()
        //{
        //    string Code = "#include<stdio.h>int main(){printf(\"I am Charis！\"return 0;}";
        //    Practics a = new Practics();
        //    if (a.GenerateC(Code))
        //    {
        //        string Actual = a.CToExe();
        //        string Result = "编译出错";
        //        Assert.AreEqual(Actual, Result);
        //    }
        //}
        // string WorkingDirectory = @"F:\git\TrainingSystemForAcm\IOResult";
        // string CFileName = "test.c";
        //在指定的目录下已经有一个test.c


        //}
        //public void RunExe()
        //{
        //    string Result = async
        //}



