using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖倒置升级版
{
    public class WorkShiftForFixation : IWorkShift
    {
        public DateTime duttyOntime;
        public DateTime offDutytime;

        public WorkShiftTemlate GetWorkShiftTemplate(IWorkShift workShift)
        {
            var workShiftForFix = workShift as WorkShiftForFixation;
            Console.WriteLine("获取固定班次");
            return null;
        }
    }
}
