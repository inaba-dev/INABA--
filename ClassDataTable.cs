using System;
using System.Data;

namespace APP
{
    public class ClassDataTable
    {
        public DataSet dataset = new DataSet("データセット");
        public DataTable table = new DataTable("Database");

        /// <summary>
        /// 
        /// </summary>

        public ClassDataTable()
        {
            ////
            table = dataset.Tables.Add("データテーブル");

            DataColumn col0 = table.Columns.Add("UniqueNumber", typeof(string));
            DataColumn col1 = table.Columns.Add("OrderDate", typeof(DateTime));
            DataColumn col2 = table.Columns.Add("OrderNumber", typeof(string));
            DataColumn col3 = table.Columns.Add("Maker", typeof(string));
            DataColumn col4 = table.Columns.Add("ProductName", typeof(string));
            DataColumn col5 = table.Columns.Add("DeliveryDate", typeof(DateTime));
            DataColumn col6 = table.Columns.Add("Quantity", typeof(int));
            DataColumn col7 = table.Columns.Add("FixedQuantity", typeof(int));
            DataColumn col8 = table.Columns.Add("Status", typeof(bool));
        }

        /// <summary>
        /// 
        /// </summary>

        public void Clear()
        {
            this.table.Clear();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Delete(string UniqueNumber)
        {
            try
            {
                /// 条件に合致するデータを検索する
                DataRow[] datarow = table.Select("UniqueNumber = '" + UniqueNumber + "'");

                /// 検索したデータをDataTableから削除する
                foreach (var dr in datarow)
                {
                    table.Rows.Remove(dr);
                }
            }
            catch
            {
                Console.WriteLine("[catch] DataBase Delete Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void Add(DataRow row)
        {
            try
            {
                this.table.Rows.Add(row);
            }
            catch
            {
                Console.WriteLine("[catch] DataBase Add Error");
            }
        }
    }
}
