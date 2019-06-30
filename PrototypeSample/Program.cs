using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    class Program
    {
        /// <summary>
        /// 客户端测试类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WeeklyLog log_pervious, log_new;
            log_pervious = new WeeklyLog();
            Attachment attachment = new Attachment();
            log_pervious.Attachment = attachment;
            log_new = log_pervious.Clone();
            Console.WriteLine("周报是否相同?{0}", (log_pervious == log_new) ? "是" : "否");
            Console.WriteLine("月报是否相同?{0}", (log_pervious.Attachment == log_new.Attachment) ? "是" : "否");
            Console.ReadLine();
        }
    }
}
