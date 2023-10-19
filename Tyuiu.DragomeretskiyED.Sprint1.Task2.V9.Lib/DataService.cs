using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return 4 / 3 * 3.14 * r;
        }
    }
}
