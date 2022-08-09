using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    partial class FormOrder : Form
    {
        /// 在庫数量管理用
        private List<ClassQuantity> QuantityDatas = new List<ClassQuantity>();

        /// <summary>
        /// 
        /// </summary>

        private int GetOrderNumber(string ProductName)
        {
            foreach (ClassQuantity QuantityData in QuantityDatas)
            {
                if (QuantityData.ProductName == ProductName)
                {
                    return QuantityData.OrderAllQuantity;
                }
            }

            /// 該当なし
            return 0;
        }

        private int GetStockNumber(string ProductName)
        {
            foreach (ClassQuantity QuantityData in QuantityDatas)
            {
                if (QuantityData.ProductName == ProductName)
                {
                    return QuantityData.StockAllQuantity;
                }
            }

            /// 該当なし
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>

        private void CreateQuantityDatas()
        {
            /// クリア
            QuantityDatas.Clear();

            /// 計算してデータ追加(注文)
            foreach (string item in selectProduct.Items)
            {
                ClassQuantity data = new ClassQuantity();

                data.ProductName = item;
                data.OrderAllQuantity = CalcOrderAllSum(item);
                data.StockAllQuantity = CalcStockAllSum(item);
                data.StockTemporary = data.StockAllQuantity;

                QuantityDatas.Add(data);
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private int StockQuantity(string ProductName, int TargetQuantity)
        {
            int resQuantity = 0;

            /// 計算してデータ追加
            foreach (ClassQuantity QuantityData in QuantityDatas)
            {
                if (QuantityData.ProductName == ProductName)
                {
                    if (QuantityData.StockTemporary > 0)
                    {
                        if (QuantityData.StockTemporary >= TargetQuantity)
                        {
                            resQuantity = TargetQuantity;
                            QuantityData.StockTemporary -= resQuantity;
                            return resQuantity;
                        }
                        else
                        {
                            resQuantity = QuantityData.StockTemporary;
                            QuantityData.StockTemporary -= resQuantity;
                            return resQuantity;
                        }
                    }
                    else
                    {
                        /// 在庫無し
                        return 0;
                    }
                }
            }

            /// 対象無し
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>

        private int CalcOrderNotShippedSum(string productname)
        {
            EnumerableRowCollection<DataRow> query;

            try
            {
                /// クエリ
                query = from data in OrderDataBase.Datas.table.AsEnumerable()
                        where (string)data["ProductName"] == productname
                        && (bool)data["Status"] == false
                        orderby data.Field<DateTime>("DeliveryDate") descending
                        select data;

                /// 合計する
                return (from data in query
                        orderby data.Field<int>("Quantity") descending
                        select data.Field<int>("Quantity")).Sum();
            }
            catch
            {
                Console.WriteLine("[catch] CalcSum");
                return -1;
            }
        }

        private int CalcOrderShippedSum(string productname)
        {
            EnumerableRowCollection<DataRow> query;

            try
            {
                /// クエリ
                query = from data in OrderDataBase.Datas.table.AsEnumerable()
                        where (string)data["ProductName"] == productname
                        && (bool)data["Status"] == true
                        orderby data.Field<DateTime>("DeliveryDate") descending
                        select data;

                /// 合計する
                return (from data in query
                        orderby data.Field<int>("Quantity") descending
                        select data.Field<int>("Quantity")).Sum();
            }
            catch
            {
                Console.WriteLine("[catch] CalcSum");
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private int CalcStockAllSum(string ProductName)
        {
            EnumerableRowCollection<DataRow> query;

            try
            {
                /// クエリ
                query = from data in StockDataBase.Datas.table.AsEnumerable()
                        where (string)data["ProductName"] == ProductName
                        && DateTime.Parse(data["DeliveryDate"].ToString()) <= this.dateTimePicker.Value
                        && (bool)data["Status"] == true
                        orderby data.Field<DateTime>("DeliveryDate") descending
                        select data;

                /// 合計する
                return (from data in query
                        orderby data.Field<int>("Quantity") descending
                        select data.Field<int>("Quantity")).Sum();
            }
            catch
            {
                Console.WriteLine("[catch] CalcSum");
                return -1;
            }
        }

        private int CalcOrderAllSum(string ProductName)
        {
            EnumerableRowCollection<DataRow> query;

            try
            {
                /// クエリ
                query = from data in OrderDataBase.Datas.table.AsEnumerable()
                        where (string)data["ProductName"] == ProductName
                        orderby data.Field<DateTime>("DeliveryDate") descending
                        select data;

                /// 合計する
                return (from data in query
                        orderby data.Field<int>("Quantity") descending
                        select data.Field<int>("Quantity")).Sum();
            }
            catch
            {
                Console.WriteLine("[catch] CalcSum");
                return -1;
            }
        }
    }
}
