﻿using System;
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
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>

        public void LoadTitle(string Text)
        {
            labelTitle.Text = Text;
        }

        /// <summary>
        /// 
        /// </summary>

        public void LoadUniqueKey()
        {
            textUniqueNumber.Text = DateTime.Now.ToString("yyMM") + "-" + Func.CreateRandNumber();
        }

        /// <summary>
        /// 
        /// </summary>

        public ClassData GetParam()
        {
            ClassData data = new ClassData();

            data.UniqueNumber = textUniqueNumber.Text;
            data.OrderDate = Func.ConvDateTime(textOrderDate.Text);
            data.OrderNumber = textOrderNumber.Text;
            data.Maker = textMaker.Text;
            data.ProductName = textProductName.Text;
            data.DeliveryDate = dateDeliveryDate.Value;
            data.Quantity = (int)numericQuantity.Value;
            data.FixedQuantity = 0;
            data.Status = true;

            return data;
        }

        /// <summary>
        /// 
        /// </summary>

        private bool IsValid()
        {
            ///
            if(textProductName.Text == "")
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>

        private void timer_Tick(object sender, EventArgs e)
        {
            bool valid = IsValid();

            buttonExec.Enabled = valid;
            buttonExec.BackColor = valid ? Color.DarkOrange : Color.Gray;
        }

        /// <summary>
        /// 
        /// </summary>

        //public void LoadTitle(string Text)
        //{
        //    labelTitle.Text = Text;
        //}
    }
}
