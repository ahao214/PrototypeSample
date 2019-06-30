using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    /// <summary>
    /// 附件类
    /// </summary>
    class Attachment
    {
        public string Name { get; set; }

        public void DownLoad()
        {
            Console.WriteLine("下载附件，文件名为{0}。", Name);
        }

    }
}
