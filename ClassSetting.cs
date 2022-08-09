using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class ClassSetting
    {
        public string ColUniqueNumber;        /// 識別番号
        public string ColOrderDate;           /// 注文日
        public string ColOrderNumber;         /// 注文番号
        public string ColMaker;               /// メーカー
        public string ColProductName;         /// 型式
        public string ColDeliveryDate;        /// 納期
        public string ColQuantity;            /// 数量
        public int RowStart = 1;
        public string SheetName;
    }
}
