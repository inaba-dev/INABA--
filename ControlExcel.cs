using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace APP
{
    class ControlExcel
    {
        static private XLWorkbook mWorkBook;
        static private IXLWorksheet mWorksheet = null;

        /// <summary>
        /// ファイルが開かれているかを確認
        /// </summary>

        public bool IsOpened(string filePath)
        {
            // filePath が相対パスのとき例外が発生するので fullPath に変換
            string fullPath = System.IO.Path.GetFullPath(filePath);

            try
            {
                /// 試しに書き込んで使用済みかを確認
                using (var fs = File.OpenWrite(fullPath))
                {

                }
                return false;
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// ファイルオープン
        /// </summary>

        public bool CheckError(string filePath)
        {
            // filePath が相対パスのとき例外が発生するので fullPath に変換
            string fullPath = System.IO.Path.GetFullPath(filePath);

            try
            {
                /// すでに開かれていたらエラー
                if (IsOpened(filePath)) return false;
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// ファイルオープン
        /// </summary>

        public bool Open(string filePath, string sheetname)
        {
            // filePath が相対パスのとき例外が発生するので fullPath に変換
            string fullPath = System.IO.Path.GetFullPath(filePath);

            try
            {
                /// すでに開かれていたらエラー
                if (IsOpened(filePath)) return false;

                /// ファイルオープン
                mWorkBook = new XLWorkbook(fullPath);

                /// シート検索
                int index = GetSheetIndex(sheetname);
                if (index < 0) throw null;

                /// シート選択
                mWorksheet = mWorkBook.Worksheet(index);

                return true;
            }
            catch
            {
                Close();
                return false;
            }            
        }

        /// <summary>
        /// 開いているワークブックとエクセルのプロセスを閉じる.
        /// </summary>

        public void Close()
        {
            if (mWorkBook != null)
            {
                mWorkBook.Dispose();
                mWorkBook = null;
            }
        }

        /// <summary>
        /// 上書き保存
        /// </summary>

        public bool Save()
        {
            try
            {
                mWorkBook.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// シート名からインデックスを探し出す
        /// </summary>

        //シート名から：アクセスインデックスを探し出す
        private int GetSheetIndex(string sheetName)
        {
            int i = 0;
            foreach (var worksheet in mWorkBook.Worksheets)
            {
                if (worksheet.Name.Equals(sheetName))
                {
                    return i + 1;
                }
                i += 1;
            }
            return -1;
        }

        /// <summary>
        /// 罫線
        /// </summary>
        /*
        public void WriteBorders(int x, int y, int xSize, int ySize)
        {           
            Microsoft.Office.Interop.Excel.Range range = 
                mWorksheet.Range[mWorksheet.Cells[y, x], mWorksheet.Cells[y + ySize, x + xSize]];

            range.Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
        }
        */

        /// <summary>
        /// 最終行の取得
        /// </summary>

        public int GetRowsCount()
        {
            return mWorksheet.LastRowUsed().RowNumber();
        }

        /// <summary>
        /// 書き込み
        /// </summary>
        /*
        public void WriteCell(int x, int y, object value)
        {
            mWorksheet.Cells[y, x].Value = value;
        }
        */
        /// <summary>
        /// 読み出し
        /// </summary>
        
        public string ReadCell(int col, int row)
        {
            try
            {
                return mWorksheet.Cell(row, col).Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        public string ReadCell(string col, int row)
        {
            try
            {
                string cell = col + row.ToString();
                return mWorksheet.Cell(cell).Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        /*
        public bool ReadCell(int x, int y, out int value)
        {
            var val = mWorksheet.Cells[y, x].Value;
            value = (val == null) ? 0 : (int)val;
            return (val != null);
        }

        public void ReadCellString(int x, int y, out string value)
        {
            var val = mWorksheet.Cells[y, x].Value;
            value = (string)val;
        }
        */
    }
}

