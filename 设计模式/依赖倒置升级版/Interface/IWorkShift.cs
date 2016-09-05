using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 依赖倒置升级版;

namespace 依赖倒置升级版
{
    public interface IWorkShift
    {
        WorkShiftTemlate GetWorkShiftTemplate(IWorkShift model);
    }
}
