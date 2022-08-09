using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class UserControlStatus : UserControl
    {
        public UserControlStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Clear()
        {
            labelProduct.Text = "---";

            ///
            labelStock.Text = "---";

            ///
            labelOrder.Text = "---";
        }

        /// <summary>
        /// 
        /// </summary>

        public void Renew (string ProductName, string StockNumber, string OrderNumber)
        {
            labelProduct.Text = ProductName;

            ///
            labelStock.Text = StockNumber;

            ///
            labelOrder.Text = OrderNumber;
        }

    }
}
