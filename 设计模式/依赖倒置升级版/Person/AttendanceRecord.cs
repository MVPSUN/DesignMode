using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖倒置升级版
{
    public class AttendanceRecord
    {
        public void GetWorkShift(IWorkShift workShift)
        {
            Console.WriteLine("获取班次详细信息。");
            var result = workShift.GetWorkShiftTemplate(workShift);
        }
    }
}
