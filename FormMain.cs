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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormReload();

            FormResult FormResult = new FormResult();

            if (FormResult.ShowDialog(this) == DialogResult.OK)
            {

            }
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


    }
}
