using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class ClassMaster
    {
        public string Maker;            /// メーカー
        public string ProductName;      /// 型式
        private List<ClassData> OrderDatas = new List<ClassData>();
        private List<ClassData> StockDatas = new List<ClassData>();
    }
}
