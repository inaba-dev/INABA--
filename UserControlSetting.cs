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
    public partial class UserControlSetting : UserControl
    {
        public UserControlSetting()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>

        public void setParameter(ClassSetting param)
        {
            comboUnique.SelectedItem = param.ColUniqueNumber;
            comboOrderDate.SelectedItem = param.ColOrderDate;
            comboOrderNumber.SelectedItem = param.ColOrderNumber;
            comboMaker.SelectedItem = param.ColMaker;
            comboProductName.SelectedItem = param.ColProductName;
            comboDeliveryDate.SelectedItem = param.ColDeliveryDate;
            comboQuantity.SelectedItem = param.ColQuantity;
            numericRowStart.Value = param.RowStart;
            textSheetName.Text = param.SheetName;
        }

        public ClassSetting getParameter()
        {
            ClassSetting param = new ClassSetting();

            param.ColUniqueNumber = (string)comboUnique.SelectedItem;
            param.ColOrderDate = (string)comboOrderDate.SelectedItem;
            param.ColOrderNumber = (string)comboOrderNumber.SelectedItem;
            param.ColMaker = (string)comboMaker.SelectedItem;
            param.ColProductName = (string)comboProductName.SelectedItem;
            param.ColDeliveryDate = (string)comboDeliveryDate.SelectedItem;
            param.ColQuantity = (string)comboQuantity.SelectedItem;
            param.RowStart = (int)numericRowStart.Value;
            param.SheetName = textSheetName.Text;

            return param;
        }
    }
}
