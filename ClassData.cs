using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class ClassData
    {
        public string UniqueNumber;     /// 識別番号
        public DateTime OrderDate;      /// 注文日
        public string OrderNumber;      /// 注文番号
        public string Maker;            /// メーカー
        public string ProductName;      /// 型式
        public DateTime DeliveryDate;   /// 納期
        public int Quantity;            /// 数量
        public bool Category;           /// カテゴリ 
        public bool Status;             /// ステータス
    }
}
