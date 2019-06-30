using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    /// <summary>
    /// 周报类，充当原型角色
    /// </summary>
    class WeeklyLog
    {
        public Attachment attachment { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        // 使用MemberwiseClone()方法实现浅克隆
        public WeeklyLog Clone()
        {
            return this.MemberwiseClone() as WeeklyLog;     //类型转换
        }
    }
}
