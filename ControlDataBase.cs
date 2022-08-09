using System;
using System.Data;
using System.Windows.Forms;

namespace APP
{
    public class ControlDataBase
    {
        /// データ本体
        public ClassDataTable Datas = new ClassDataTable();

        /// データベースファイル名
        private string FileName = "";

        /// <summary>
        /// 
        /// </summary>

        public ControlDataBase(string filename)
        {
            FileName = filename;
        }

        /// <summary>
        /// 
        /// </summary>

        public bool Load()
        {
            try
            {
                /// クリア
                Datas.Clear();

                /// ファイルが存在しているか確認
                if (!System.IO.File.Exists(FileName))
                {
                    return true;
                }

                /// 読み出し
                Datas.table.ReadXml(FileName);
                return true;
            }
            catch
            {
                MessageBox.Show("予期せぬエラーが発生しました。", "Error");
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void Merge(ClassDataTable Datatable)
        {
            /// クエリ
            EnumerableRowCollection<DataRow> query = 
                from order in Datatable.table.AsEnumerable() select order;

            /// データベース読み出し
            Load();

            /// 検索したデータをDataTableから削除する
            foreach (var row in query)
            {
                Datas.Delete((string)row["UniqueNumber"]);
            }

            /// データを追加する
            foreach (var row in query)
            {
                DataRow data = Datas.table.NewRow();

                data["UniqueNumber"] = (string)row["UniqueNumber"];
                data["OrderDate"] = (DateTime)row["OrderDate"];
                data["OrderNumber"] = (string)row["OrderNumber"];
                data["Maker"] = (string)row["Maker"];
                data["ProductName"] = (string)row["ProductName"];
                data["DeliveryDate"] = (DateTime)row["DeliveryDate"];
                data["Quantity"] = (int)row["Quantity"];
                data["FixedQuantity"] = (int)row["FixedQuantity"];
                data["Status"] = (bool)row["Status"];

                Datas.Add(data);
            }

            /// データベース書き込み
            Save();
        }

        /// <summary>
        /// データベースに書き込み
        /// </summary>

        public void Save()
        {
            //// データテーブル名を定義
            Datas.table.TableName = "データテーブル";

            //// XMLファイルへ書き出す
            Datas.table.WriteXml(FileName);

            //MessageBox.Show("保存しました。", "Save");
        }

        /// <summary>
        /// 引当確定
        /// </summary>

        public void Commit(string UniqueNumber, int FixedQuantity)
        {
            foreach (DataRow data in Datas.table.Rows)
            {
                if ((string)data["UniqueNumber"] == UniqueNumber)
                {
                    if((bool)data["Status"] == true)
                    {
                        data["Status"] = false;
                        data["FixedQuantity"] = 0;
                    }
                    else
                    {
                        data["Status"] = true;
                        data["FixedQuantity"] = FixedQuantity;
                    }
                    break;
                }
            }

            /// データ保存
            Save();
        }

        /// <summary>
        /// ステータス変更
        /// </summary>

        public void ChangeStatus(string UniqueNumber)
        {
            foreach (DataRow data in Datas.table.Rows)
            {
                if ((string)data["UniqueNumber"] == UniqueNumber)
                {
                    data["Status"] = !(bool)data["Status"];
                    break;
                }
            }

            /// データ保存
            Save();
        }

        /// <summary>
        /// 削除
        /// </summary>

        public void Delete(string UniqueNumber)
        {
            foreach (DataRow data in Datas.table.Rows)
            {
                if ((string)data["UniqueNumber"] == UniqueNumber)
                {
                    Datas.Delete((string)data["UniqueNumber"]);
                    break;
                }
            }

            /// データ保存
            Save();
        }
    }
}
