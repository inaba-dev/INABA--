using System;
using System.Data;
using System.Windows.Forms;

namespace APP
{
    public class ControlOrder
    {
        private ClassSetting _config = new ClassSetting();

        /// データテーブル
        private ClassDataTable Datas = new ClassDataTable();

        /// データベース
        private ControlDataBase DataBase = new ControlDataBase(Define.defOrderDataFile);

        /// <summary>
        /// 
        /// </summary>

        public void Exec(ClassSetting config)
        {
            /// 
            _config = config;

            /// 
            LoadFile();

            /// データベースとマージ
            DataBase.Merge(Datas);
        }

        /// <summary>
        /// 
        /// </summary>

        public void Add(ClassData Data)
        {
            DataBase.Add(Data);
        }

        /// <summary>
        /// 
        /// </summary>

        public void LoadFile()
        {
            /// OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            /// はじめに表示されるフォルダを指定する
            /// 指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";

            /// [ファイルの種類]に表示される選択肢を指定する
            /// 指定しないとすべてのファイルが表示される
            ofd.Filter = "エクセルファイル(*.xlsx)|*.xlsx";

            /// タイトルを設定する
            ofd.Title = "注文ファイルを選択してください。";

            Load("C:\\Users\\makoto\\Documents\\Project\\INABA-納期調整\\sampledata\\因幡管理　進納期表（社内用）2021.4～.xlsx");
            /*
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Load(ofd.FileName);
            }
            else
            {
                /// フォームの終了
                Environment.Exit(0);
            }
            */
        }

        /// <summary>
        /// 
        /// </summary>

        private bool Load(string filepath)
        {
            ControlExcel excel = new ControlExcel();

            try
            {
                /// ワークブックを開く
                if (!excel.Open(filepath, _config.SheetName))
                {
                    MessageBox.Show("ファイルオープンに失敗しました。", "Error");
                    return false;
                }
                
                /// クリア
                Datas.Clear();

                for (int row = _config.RowStart; row < excel.GetRowsCount(); row++)
                {
                    DataRow data = Datas.table.NewRow();

                    ///
                    data["UniqueNumber"] = excel.ReadCell(_config.ColUniqueNumber, row);
                    data["OrderDate"] = Func.ConvDateTime(excel.ReadCell(_config.ColOrderDate, row));
                    data["OrderNumber"] = excel.ReadCell(_config.ColOrderNumber, row);
                    data["Maker"] = excel.ReadCell(_config.ColMaker, row);
                    data["ProductName"] = excel.ReadCell(_config.ColProductName, row);
                    data["DeliveryDate"] = Func.ConvDateTime(excel.ReadCell(_config.ColDeliveryDate, row));
                    data["Quantity"] = Func.ConvInt(excel.ReadCell(_config.ColQuantity, row));
                    data["FixedQuantity"] = 0;
                    data["Status"] = false;

                    ///
                    Datas.Add(data);
                }

                return true;
            }
            catch
            {
                MessageBox.Show("予期せぬエラーが発生しました。", "Error");
                return false;
            }
            finally
            {
                //閉じる
                excel.Close();
            }
        }
    }
}
