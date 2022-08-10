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
    public partial class FormStock : Form
    {
        /// データベースの定義
        public ControlDataBase StockDataBase = new ControlDataBase(Define.defStockDataFile);

        /// <summary>
        /// 
        /// </summary>

        public FormStock()
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
            DataGridViewColumn col8 = new DataGridViewColumn();
            DataGridViewImageColumn col9 = new DataGridViewImageColumn();
            DataGridViewImageColumn col10 = new DataGridViewImageColumn();

            dataGridView.setupColumnImg      (col0,  0,  100, "Status", "表示", "");
            dataGridView.setupColumnTxt      (col1,  1,  120, "UniqueNumber", "識別番号", "");
            dataGridView.setupColumnTxtCenter(col2,  2,  95,  "OrderDate", "注文日", "");
            dataGridView.setupColumnTxt      (col3,  3,  150, "OrderNumber", "注文番号", "");
            dataGridView.setupColumnTxtCenter(col4,  4,  133, "Maker", "メーカー", "");
            dataGridView.setupColumnTxt      (col5,  5,  235, "ProductName", "型式", "");
            dataGridView.setupColumnTxtCenter(col6,  6,  95,  "DeliveryDate", "納期", "");
            dataGridView.setupColumnTxtCenter(col7,  7,  85,  "Quantity", "注文数", "");
            dataGridView.setupColumnTxtCenter(col8,  8,  85,  "Delivery", "納品数", "");
            dataGridView.setupColumnImg      (col9,  9,  100, "Edit", "編集", "");
            dataGridView.setupColumnImg      (col10, 10, 100, "Delete", "削除", "");

            dataGridView.Columns.Add(col0);
            dataGridView.Columns.Add(col1);
            dataGridView.Columns.Add(col2);
            dataGridView.Columns.Add(col3);
            dataGridView.Columns.Add(col4);
            dataGridView.Columns.Add(col5);
            dataGridView.Columns.Add(col6);
            dataGridView.Columns.Add(col7);
            dataGridView.Columns.Add(col8);
            dataGridView.Columns.Add(col9);
            dataGridView.Columns.Add(col10);

            /// DataGridViewの先頭列を固定
            dataGridView.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[1].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[2].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[3].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[4].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[5].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[6].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[7].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[8].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[9].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[10].Resizable = DataGridViewTriState.False;

            /// ソート機能を追加
            dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[6].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[7].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView.Columns[8].SortMode = DataGridViewColumnSortMode.Automatic;

            /// DataGridView設定
            dataGridView.setup(true, true, DataGridViewSelectionMode.FullRowSelect);

            /// データベースからロード
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

            selectStatus.Items.Add("指定なし");
            selectStatus.Items.Add("表示");
            selectStatus.Items.Add("非表示");
            selectStatus.SelectedIndex = 0;

            /// 型番

            selectProduct.Items.Clear();
            var products = (from order in query
                            orderby order.Field<string>("ProductName")
                            select order.Field<string>("ProductName")).Distinct();

            selectProduct.Items.Add("指定なし");

            foreach (var product in products) selectProduct.Items.Add(product);

            selectProduct.SelectedIndex = 0;

            /// メーカー

            selectMaker.Items.Clear();
            var makers = (from order in query
                            orderby order.Field<string>("Maker")
                            select order.Field<string>("Maker")).Distinct();

            selectMaker.Items.Add("指定なし");

            foreach (var maker in makers)
            {
                if(maker != "") selectMaker.Items.Add(maker);
            }

            selectMaker.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>

        public void Reload()
        {
            /// データテーブル作成
            EnumerableRowCollection<DataRow> query = LoadDataTable();

            if (query == null) return;

            /// クエリ(品コード)
            if (selectProduct.SelectedIndex > 0)
            {
                query = execQueryProduct(query, (string)selectProduct.SelectedItemEx());
            }

            /// クエリ(メーカー)
            if (selectMaker.SelectedIndex > 0)
            {
                query = execQueryMaker(query, (string)selectMaker.SelectedItemEx());
            }

            /// クエリ(有効/無効)
            if (selectStatus.SelectedIndex > 0)
            {
                bool valid = selectStatus.SelectedItemEx() == "非表示" ? false : true;
                query = execQueryStatus(query, valid);
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
                dataGridView.Rows.Add
                (
                    ((bool)row["Status"]) ? Properties.Resources.btn_invalid : Properties.Resources.btn_valid,
                    row["UniqueNumber"],
                    date1.ToString("yyyy/MM/dd"),
                    row["OrderNumber"],
                    row["Maker"],
                    row["ProductName"],
                    date2.ToString("yyyy/MM/dd"),
                    row["Quantity"],
                    row["Quantity"],
                    Properties.Resources.btn_edit,
                    Properties.Resources.btn_delete
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
                query = from order in StockDataBase.Datas.table.AsEnumerable()
                        orderby order.Field<DateTime>("DeliveryDate")
                        select order;

                return query;
            }
            catch
            {
                Console.WriteLine("[catch] loadDataTable");
                return null;
            }
        }

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

        public EnumerableRowCollection<DataRow> execQueryMaker(EnumerableRowCollection<DataRow> query, string Maker)
        {
            try
            {
                return from order in query
                       where order.Field<string>("Maker") == Maker
                       select order;
            }
            catch
            {
                return null;
            }
        }

        public EnumerableRowCollection<DataRow> execQueryStatus(EnumerableRowCollection<DataRow> query, bool Status)
        {
            try
            {
                return from order in query
                       where order.Field<bool>("Status") == Status
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

        /// <summary>
        /// 
        /// </summary>

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            try
            {
                ///
                var index = dataGridView.Rows[e.RowIndex].Cells[1].Value;

                if (dgv.Columns[e.ColumnIndex].Name == "表示")
                {
                    StockDataBase.ChangeStatus((string)index);

                    /// データベースから読込んで表示
                    Reload();
                }
                else if (dgv.Columns[e.ColumnIndex].Name == "編集")
                {
                    FormRegist FormRegist = new FormRegist();
                    
                    FormRegist.LoadTitle("入荷編集画面");
                    FormRegist.SetParam(StockDataBase.GetData((string)index));

                    if (FormRegist.ShowDialog(this) == DialogResult.OK)
                    {
                        ClassData data = FormRegist.GetParam();

                        /// 削除
                        StockDataBase.Delete((string)index);

                        /// 追加
                        StockDataBase.Add(data);
                    }

                    /// データベースから読込んで表示
                    Reload();
                }
                else if (dgv.Columns[e.ColumnIndex].Name == "削除")
                {
                    /// メッセージボックスを表示する
                    DialogResult result = MessageBox.Show("データを削除しますか？", "削除の確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                    /// Yesなら実行
                    if (result == DialogResult.Yes)
                    {
                        StockDataBase.Delete((string)index);
                    }

                    /// データベースから読込んで表示
                    Reload();
                }
                else
                {
                    /// 型番を取得
                    var productnumber = dataGridView.Rows[e.RowIndex].Cells[5].Value;

                    Console.WriteLine("[Debug] {0}", productnumber);
                }
            }
            catch
            {

            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /// 型番を取得
                var productname = dataGridView.Rows[e.RowIndex].Cells[5].Value;

                /// セレクトボックスに反映
                selectProduct.SelectedItem = (string)productname;
            }
            catch
            {

            }
        }
    }
}
