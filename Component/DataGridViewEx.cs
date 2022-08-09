using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace APP
{
    public class DataGridViewEx : System.Windows.Forms.DataGridView
    { 
        public DataGridViewEx() : base()
        {
            this.BackgroundColor = SystemColors.Control;

            this.RowHeadersVisible = false;
            this.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);

            /// フォントを変更する
            this.DefaultCellStyle.Font = new Font("メイリオ", 9);

            ///列ヘッダーを表示にする
            this.ColumnHeadersVisible = true;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /// 行ヘッダの背景色の変更
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            ///行ヘッダーを非表示にする
            this.RowHeadersVisible = false;

            //グリッド線の色
            this.GridColor = Define.defBaseColor3;

            /// Visualスタイルを使用しない
            this.EnableHeadersVisualStyles = false;

            /// 行の高さ
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.RowTemplate.Height = 40;

            // 行の高さは変更不可
            this.AllowUserToResizeRows = false;

            /// DataGridViewの表示幅に合わせて列幅自動調整
            //this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /// セル、行、列が複数選択されないようにする
            this.MultiSelect = false;

            /// 枠線を消す 
            //dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            /// 選択されているセルは無し
            this.CurrentCell = null;
        }

        /// <summary>
        /// 
        /// </summary>

        public void setup(
            bool _readonly,
            bool _rowfix,
            DataGridViewSelectionMode _selectmode
            )
        {
            /// ReadOnlyモードに設定
            if (_readonly) this.ReadOnly = true;

            /// 列・行追加禁止
            if (_rowfix)
            {
                this.AllowUserToAddRows = false;
                this.AllowUserToDeleteRows = false;
            }

            /// 選択モードを設定
            this.SelectionMode = _selectmode;
        }

        /// <summary>
        /// 
        /// </summary>

        public void setupColumnTxt(DataGridViewColumn col, int index, int width, string id, string name, string tooltop)
        {
            col.Name = name;
            col.DataPropertyName = id;
            col.Width = width;
            col.DisplayIndex = index;
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.DefaultCellStyle.BackColor = Define.defBaseColor1;
            col.ToolTipText = tooltop;
        }

        public void setupColumnTxtCenter(DataGridViewColumn col, int index, int width, string id, string name, string tooltop)
        {
            col.Name = name;
            col.DataPropertyName = id;
            col.Width = width;
            col.DisplayIndex = index;
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.DefaultCellStyle.BackColor = Define.defBaseColor1;
            col.DefaultCellStyle.Padding = new Padding(3, 3, 3, 3);
            col.ToolTipText = tooltop;

            //列のセルのテキストの配置を上下左右とも中央にする
            col.HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void setupColumnTxtCenter(DataGridViewColumn col, int width, Color color)
        {
            col.Width = width;
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.DefaultCellStyle.BackColor = color;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void setupColumnChk(DataGridViewCheckBoxColumn col, int index, int width, string id, string name, string tooltop)
        {
            col.Name = name;
            col.DataPropertyName = id;
            col.Width = width;
            col.DisplayIndex = index;
            col.DefaultCellStyle.BackColor = Define.defBaseColor1;
            col.ToolTipText = tooltop;
        }

        public void setupColumnImg(DataGridViewImageColumn col, int index, int width, string id, string name, string tooltop)
        {
            col.Name = name;
            col.DataPropertyName = id;
            col.Width = width;
            col.DisplayIndex = index;
            col.DefaultCellStyle.BackColor = Define.defBaseColor1;
            col.ToolTipText = tooltop;
        }
    }
}
