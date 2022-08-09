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
    public partial class FormResult : Form
    {
        /// データベースの定義
        public ControlDataBase OrderDataBase = new ControlDataBase(Define.defOrderDataFile);
        public ControlDataBase StockDataBase = new ControlDataBase(Define.defStockDataFile);

        /// <summary>
        /// 
        /// </summary>

        public FormResult()
        {
            InitializeComponent();

            /// カラム名を指定

            DataGridViewImageColumn col0 = new DataGridViewImageColumn();
            DataGridViewColumn col1 = new DataGridViewColumn();
            DataGridViewColumn col2 = new DataGridViewColumn();
            DataGridViewColumn col3 = new DataGridViewColumn();
            DataGridViewColumn col4 = new DataGridViewColumn();
            DataGridViewColumn col5 = new DataGridViewColumn();
            DataGridViewColumn col6 = new DataGridViewColumn();
            DataGridViewColumn col7 = new DataGridViewColumn();

            dataGridView.setupColumnImg(col0, 0, 100, "Status", "ステータス", "");
            dataGridView.setupColumnTxtCenter(col1, 1, 95, "OrderDate", "注文日", "");
            dataGridView.setupColumnTxtCenter(col2, 2, 150, "OrderNumber", "注文番号", "");
            dataGridView.setupColumnTxtCenter(col3, 3, 133, "Maker", "メーカー", "");
            dataGridView.setupColumnTxtCenter(col4, 4, 235, "ProductName", "型式", "");
            dataGridView.setupColumnTxtCenter(col5, 5, 95, "DeliveryDate", "納期", "");
            dataGridView.setupColumnTxtCenter(col6, 6, 85, "Quantity", "数量", "");
            dataGridView.setupColumnTxtCenter(col7, 7, 85, "Delivery", "引当", "");

            dataGridView.Columns.Add(col0);
            dataGridView.Columns.Add(col1);
            dataGridView.Columns.Add(col2);
            dataGridView.Columns.Add(col3);
            dataGridView.Columns.Add(col4);
            dataGridView.Columns.Add(col5);
            dataGridView.Columns.Add(col6);
            dataGridView.Columns.Add(col7);

            /// DataGridViewの先頭列を固定
            dataGridView.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[1].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[2].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[3].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[4].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[5].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[6].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[7].Resizable = DataGridViewTriState.False;

            /// ソート機能を追加
            //dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView.Columns[6].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView.Columns[7].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView.Columns[8].SortMode = DataGridViewColumnSortMode.Automatic;

            /// DataGridView設定
            dataGridView.setup(true, true, DataGridViewSelectionMode.FullRowSelect);

            /// 日付の設定
            SetupDate();

            /// データベースからロード
            OrderDataBase.Load();
            StockDataBase.Load();

            /// データテーブル作成
            EnumerableRowCollection<DataRow> query = LoadDataTable();

            /// 検索窓の設定
            SetupSearch(query);

            /// データベースから読込んで表示
            Reload();
        }

        /// <summary>
        /// 
        /// </summary>

        public void SetupSearch(EnumerableRowCollection<DataRow> query)
        {
            /// ステータス

            selectStatus.Items.Add("－");
            selectStatus.Items.Add("未承認");
            selectStatus.Items.Add("完了");
            selectStatus.SelectedIndex = 0;

            /// 型番

            selectProduct.Items.Clear();
            var products = (from order in query
                            orderby order.Field<string>("ProductName") descending
                            select order.Field<string>("ProductName")).Distinct();

            selectProduct.Items.Add("-");

            foreach (var product in products) selectProduct.Items.Add(product);

            selectProduct.SelectedIndex = 0;

            /// メーカー

            selectMaker.Items.Clear();
            var makers = (from order in query
                            orderby order.Field<string>("Maker") descending
                            select order.Field<string>("Maker")).Distinct();

            foreach (var maker in makers) selectMaker.Items.Add(maker);
        }

        public void SetupDate()
        {
            DateTime nowtime = DateTime.Now;

            this.dateTimePicker.Value = nowtime;
        }

        /// <summary>
        /// 
        /// </summary>

        public void Reload()
        {
            /// データテーブル作成
            EnumerableRowCollection<DataRow> query = LoadDataTable();
            EnumerableRowCollection<DataRow> query_next;

            if (query == null) return;

            /// 各品種について入庫総数を計算
            //CreateQuantityDatas();

            /// クエリ(品コード)
            if (selectProduct.SelectedIndex > 0)
            {
                //query_next = query;
                query = execQueryProduct(query, (string)selectProduct.SelectedItemEx());
            }

            /// 選択されている行を取得
            var Current = dataGridView.SelectedRows;
            int CurrentRow = (Current.Count > 0) ? Current[0].Index : 0;

            /// テーブルをクリア
            dataGridView.Rows.Clear();

            foreach (var row in query)
            {
                DateTime date1 = (DateTime)row["OrderDate"];
                DateTime date2 = (DateTime)row["DeliveryDate"];

                /// 
                //int quantity = StockQuantity((string)row["ProductName"], (int)row["Quantity"]);

                /// 
                dataGridView.Rows.Add
                (
                    ((bool)row["Status"]) ? Properties.Resources.btn_check : Properties.Resources.btn_undefined,
                    date1.ToString("yyyy/MM/dd"),
                    row["OrderNumber"],
                    row["Maker"],
                    row["ProductName"],
                    date2.ToString("yyyy/MM/dd"),
                    row["Quantity"],
                    0
                );
            }

            try
            {
                /// 選択されている行にフォーカス
                if (CurrentRow > 0)
                {
                    dataGridView.Rows[CurrentRow].Selected = true;
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>

        public EnumerableRowCollection<DataRow> LoadDataTable()
        {
            EnumerableRowCollection<DataRow> query;

            try
            {
                /// クエリ
                query = from order in OrderDataBase.Datas.table.AsEnumerable()
                        orderby order.Field<DateTime>("DeliveryDate")
                        select order;

                return query;
            }
            catch
            {
                Console.WriteLine("[catch] loadDataTable");
                return null;
            }
#if false

            ControlUser controlUser = new ControlUser();
            ControlProduct controlProduct = new ControlProduct();

            /// データのロード
            controlData.load(this.dateTimeStrDate.Text, this.dateTimeEndDate.Text);

            /// テーブルをクリア
            DataTable.clear();

            /// テーブルに追加
            try
            {
                foreach (var data in controlData.getDatas())
                {
                    if (data.DeleteFlag) continue;

                    DataRow row = DataTable.table.NewRow();

                    int point = Int32.Parse(controlProduct.getPoint(data.ProductNumber));

                    row["LOCK"] = (data.AdminUserNumber != null);
                    row["CHECK"] = (data.LeaderUserNumber != null);
                    row["NUMBER"] = data.Number;
                    row["TIME"] = data.DateYear + "/" + data.DateMonth + "/" + data.DateDay; //data.RegistDate;
                    row["USERNO"] = data.RegistUserNumber;
                    row["PRODUCTID"] = data.ProductNumber;
                    row["UPDATE"] = data.FinalData;
                    row["ORDERNUMBER"] = data.OrderNumber;
                    row["SUBJECT1"] = calcRatio(data.SubjectDatas[0], point);
                    row["SUBJECT2"] = calcRatio(data.SubjectDatas[1], point);
                    row["SUBJECT3"] = calcRatio(data.SubjectDatas[2], point);
                    row["SUBJECT4"] = calcRatio(data.SubjectDatas[3], point);
                    row["SUBJECT5"] = calcRatio(data.SubjectDatas[4], point);

                    DataTable.add(row);
                }

                ClassUser UserInfo = CurrentStatus.getUserInfo();

                /// クエリ
                query = from order in DataTable.table.AsEnumerable()
                        orderby order.Field<DateTime>("TIME") descending
                        select order;

                /// 時間クエリ
                {
                    query_next = query;
                    query = execQueryTime(query_next, this.dateTimeStrDate.Text, this.dateTimeEndDate.Text);
                }

                /// クエリ(管理者)
                if (selectStatus.SelectedIndex != 0)
                {
                    bool valid = selectStatus.SelectedItemEx() == "未承認" ? false : true;
                    query_next = query;
                    query = execQueryStatus(query_next, valid);
                }

                /// クエリ(ユーザ)
                if (UserInfo.Type != (int)Define.UserType.Editor)
                {
                    if (selectUser.SelectedIndex != 0)
                    {
                        var select = (KeyValuePair)selectUser.SelectedItemEx();
                        query_next = query;
                        query = execQueryUser(query_next, select.Key);
                    }
                }
                else
                {
                    var select = (KeyValuePair)selectUser.SelectedItemEx();
                    query_next = query;
                    query = execQueryUser(query_next, select.Key);
                }

                /// クエリ(品コード)
                if (selectProductId.SelectedIndex != 0)
                {
                    string productid = selectProductId.SelectedItemEx();
                    query_next = query;
                    query = execQueryProduct(query_next, controlProduct.getNumber(productid));
                }

                /// クエリ(オーダー番号)
                if (textOrderNumber.Text != "")
                {
                    string[] ordernumbers = textOrderNumber.Text.Split(',');
                    query_next = query;
                    query = execQueryOrderNumber(query_next, ordernumbers);
                }

                return query;
            }
            catch
            {
                Console.WriteLine("[catch] loadDataTable");
                return null;
            }
#endif

        }

        //public EnumerableRowCollection<DataRow> ExecQueryTime(EnumerableRowCollection<DataRow> query, string targettime)
        //{
        //    try
        //    {
        //        return from order in query
        //               where DateTime.Parse(order["DeliveryDate"].ToString()) <= DateTime.Parse(targettime)
        //               orderby order.Field<DateTime>("DeliveryDate") descending
        //               select order;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        public EnumerableRowCollection<DataRow> execQueryProduct(EnumerableRowCollection<DataRow> query, string ProductName)
        {
            try
            {
                return from order in query
                       where order.Field<string>("ProductName") == ProductName
                       select order;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void labelSearch_Click(object sender, EventArgs e)
        {
            /// データベースから読込んで表示
            Reload();
        }

        private void labelSave_Click(object sender, EventArgs e)
        {
            //DataBase.Save();
        }
    }
}
