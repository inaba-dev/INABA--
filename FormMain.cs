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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            /// 初期設定情報をロード
            execLoadConfig();

            ///
            FormReload();
        }

        /// <summary>
        /// 
        /// </summary>

        public void FormReload()
        {
            /// データの保存
            execSaveConfig();

            /// 初期設定情報をロード
            execLoadConfig();

            //
            getSoftwareVersion();
        }

        /// <summary>
        /// 
        /// </summary>

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /// データの保存
            execSaveConfig();
        }

        /// <summary>
        /// ソフトウェアバージョンの読込
        /// </summary>

        private void getSoftwareVersion()
        {
            System.Diagnostics.FileVersionInfo ver =
            System.Diagnostics.FileVersionInfo.GetVersionInfo(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

            this.Text = String.Format("{0} Ver {1}.{2}.{3}", ver.ProductName, ver.FileMajorPart.ToString(), ver.FileMinorPart, ver.FileBuildPart);
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonOrderRegist_Click(object sender, EventArgs e)
        {
            FormReload();

            ControlOrder ControlOrder = new ControlOrder();

            ControlOrder.Exec(config.Order);
        }

        private void buttonOrderList_Click(object sender, EventArgs e)
        {
            FormOrder FormOrder = new FormOrder();

            if (FormOrder.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void buttonOrderManual_Click(object sender, EventArgs e)
        {
            FormRegist FormRegist = new FormRegist();

            FormRegist.LoadTitle("注文登録画面");

            if (FormRegist.ShowDialog(this) == DialogResult.OK)
            {
                ClassData data = FormRegist.GetParam();

                ControlOrder ControlOrder = new ControlOrder();

                ControlOrder.Add(data);
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonStockRegist_Click(object sender, EventArgs e)
        {
            FormReload();

            ControlStock ControlStock = new ControlStock();

            ControlStock.Exec(config.Stock);
        }

        private void buttonStockList_Click(object sender, EventArgs e)
        {
            FormStock FormStock = new FormStock();

            if (FormStock.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void buttonStockManual_Click(object sender, EventArgs e)
        {
            FormRegist FormRegist = new FormRegist();

            FormRegist.LoadTitle("入荷登録画面");
            FormRegist.LoadUniqueKey();

            if (FormRegist.ShowDialog(this) == DialogResult.OK)
            {
                ClassData data = FormRegist.GetParam();

                ControlStock ControlStock = new ControlStock();

                ControlStock.Add(data);
            }
        }
    }
}
