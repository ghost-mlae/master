using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM
{
    class DEM
    {
        public int RowsNum;//行数
        public int ColsNum;//列数
        public double Xmin;//x的最小值
        public double Xmax;//x的最大值
        public double Ymin;//Y的最小值
        public double Ymax;//Y的最大值
        public double Zmin;//Z的最小值
        public double Zmax;//Z的最大值
        public double[,] ElementData;//用来存点的
        public int cellsize; //有个栅格的大小
    }
}
