namespace APP
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOrderList = new System.Windows.Forms.Button();
            this.buttonOrderRegist = new System.Windows.Forms.Button();
            this.userControlOrder = new APP.UserControlSetting();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStockList = new System.Windows.Forms.Button();
            this.buttonStockRegist = new System.Windows.Forms.Button();
            this.userControlStock = new APP.UserControlSetting();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOrderList);
            this.groupBox1.Controls.Add(this.buttonOrderRegist);
            this.groupBox1.Controls.Add(this.userControlOrder);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 345);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注文シート設定";
            // 
            // buttonOrderList
            // 
            this.buttonOrderList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOrderList.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOrderList.ForeColor = System.Drawing.Color.White;
            this.buttonOrderList.Location = new System.Drawing.Point(181, 38);
            this.buttonOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderList.Name = "buttonOrderList";
            this.buttonOrderList.Size = new System.Drawing.Size(130, 80);
            this.buttonOrderList.TabIndex = 170;
            this.buttonOrderList.Text = "引当状況";
            this.buttonOrderList.UseVisualStyleBackColor = false;
            this.buttonOrderList.Click += new System.EventHandler(this.buttonOrderList_Click);
            // 
            // buttonOrderRegist
            // 
            this.buttonOrderRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOrderRegist.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOrderRegist.ForeColor = System.Drawing.Color.White;
            this.buttonOrderRegist.Location = new System.Drawing.Point(181, 126);
            this.buttonOrderRegist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderRegist.Name = "buttonOrderRegist";
            this.buttonOrderRegist.Size = new System.Drawing.Size(130, 80);
            this.buttonOrderRegist.TabIndex = 169;
            this.buttonOrderRegist.Text = "注文登録";
            this.buttonOrderRegist.UseVisualStyleBackColor = false;
            this.buttonOrderRegist.Click += new System.EventHandler(this.buttonOrderRegist_Click);
            // 
            // userControlOrder
            // 
            this.userControlOrder.Location = new System.Drawing.Point(9, 23);
            this.userControlOrder.Name = "userControlOrder";
            this.userControlOrder.Size = new System.Drawing.Size(280, 310);
            this.userControlOrder.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStockList);
            this.groupBox2.Controls.Add(this.buttonStockRegist);
            this.groupBox2.Controls.Add(this.userControlStock);
            this.groupBox2.Location = new System.Drawing.Point(365, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 343);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "納期シート設定";
            // 
            // buttonStockList
            // 
            this.buttonStockList.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonStockList.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStockList.ForeColor = System.Drawing.Color.White;
            this.buttonStockList.Location = new System.Drawing.Point(178, 37);
            this.buttonStockList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockList.Name = "buttonStockList";
            this.buttonStockList.Size = new System.Drawing.Size(130, 80);
            this.buttonStockList.TabIndex = 171;
            this.buttonStockList.Text = "納期一覧";
            this.buttonStockList.UseVisualStyleBackColor = false;
            this.buttonStockList.Click += new System.EventHandler(this.buttonStockList_Click);
            // 
            // buttonStockRegist
            // 
            this.buttonStockRegist.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonStockRegist.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStockRegist.ForeColor = System.Drawing.Color.White;
            this.buttonStockRegist.Location = new System.Drawing.Point(178, 125);
            this.buttonStockRegist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockRegist.Name = "buttonStockRegist";
            this.buttonStockRegist.Size = new System.Drawing.Size(130, 80);
            this.buttonStockRegist.TabIndex = 170;
            this.buttonStockRegist.Text = "納期登録";
            this.buttonStockRegist.UseVisualStyleBackColor = false;
            this.buttonStockRegist.Click += new System.EventHandler(this.buttonStockRegist_Click);
            // 
            // userControlStock
            // 
            this.userControlStock.Location = new System.Drawing.Point(6, 26);
            this.userControlStock.Name = "userControlStock";
            this.userControlStock.Size = new System.Drawing.Size(280, 310);
            this.userControlStock.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(740, 530);
            this.MinimumSize = new System.Drawing.Size(740, 530);
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private UserControlSetting userControlOrder;
        private UserControlSetting userControlStock;
        private System.Windows.Forms.Button buttonOrderRegist;
        private System.Windows.Forms.Button buttonStockRegist;
        private System.Windows.Forms.Button buttonOrderList;
        private System.Windows.Forms.Button buttonStockList;
    }
}

