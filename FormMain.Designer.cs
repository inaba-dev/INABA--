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
            this.buttonOrderList = new System.Windows.Forms.Button();
            this.buttonOrderRegist = new System.Windows.Forms.Button();
            this.buttonStockList = new System.Windows.Forms.Button();
            this.buttonStockRegist = new System.Windows.Forms.Button();
            this.buttonStockManual = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlStock = new APP.UserControlSetting();
            this.userControlOrder = new APP.UserControlSetting();
            this.buttonOrderManual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrderList
            // 
            this.buttonOrderList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOrderList.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold);
            this.buttonOrderList.ForeColor = System.Drawing.Color.White;
            this.buttonOrderList.Location = new System.Drawing.Point(218, 65);
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
            this.buttonOrderRegist.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold);
            this.buttonOrderRegist.ForeColor = System.Drawing.Color.White;
            this.buttonOrderRegist.Location = new System.Drawing.Point(218, 155);
            this.buttonOrderRegist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderRegist.Name = "buttonOrderRegist";
            this.buttonOrderRegist.Size = new System.Drawing.Size(130, 80);
            this.buttonOrderRegist.TabIndex = 169;
            this.buttonOrderRegist.Text = "注文登録\r\n(ファイル)";
            this.buttonOrderRegist.UseVisualStyleBackColor = false;
            this.buttonOrderRegist.Click += new System.EventHandler(this.buttonOrderRegist_Click);
            // 
            // buttonStockList
            // 
            this.buttonStockList.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonStockList.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold);
            this.buttonStockList.ForeColor = System.Drawing.Color.White;
            this.buttonStockList.Location = new System.Drawing.Point(214, 65);
            this.buttonStockList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockList.Name = "buttonStockList";
            this.buttonStockList.Size = new System.Drawing.Size(130, 80);
            this.buttonStockList.TabIndex = 171;
            this.buttonStockList.Text = "入荷一覧";
            this.buttonStockList.UseVisualStyleBackColor = false;
            this.buttonStockList.Click += new System.EventHandler(this.buttonStockList_Click);
            // 
            // buttonStockRegist
            // 
            this.buttonStockRegist.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonStockRegist.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold);
            this.buttonStockRegist.ForeColor = System.Drawing.Color.White;
            this.buttonStockRegist.Location = new System.Drawing.Point(214, 155);
            this.buttonStockRegist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockRegist.Name = "buttonStockRegist";
            this.buttonStockRegist.Size = new System.Drawing.Size(130, 80);
            this.buttonStockRegist.TabIndex = 170;
            this.buttonStockRegist.Text = "入荷登録\r\n(ファイル)";
            this.buttonStockRegist.UseVisualStyleBackColor = false;
            this.buttonStockRegist.Click += new System.EventHandler(this.buttonStockRegist_Click);
            // 
            // buttonStockManual
            // 
            this.buttonStockManual.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonStockManual.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold);
            this.buttonStockManual.ForeColor = System.Drawing.Color.White;
            this.buttonStockManual.Location = new System.Drawing.Point(214, 245);
            this.buttonStockManual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockManual.Name = "buttonStockManual";
            this.buttonStockManual.Size = new System.Drawing.Size(130, 80);
            this.buttonStockManual.TabIndex = 172;
            this.buttonStockManual.Text = "入荷登録\r\n(マニュアル)";
            this.buttonStockManual.UseVisualStyleBackColor = false;
            this.buttonStockManual.Click += new System.EventHandler(this.buttonStockManual_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.buttonOrderManual);
            this.panel1.Controls.Add(this.buttonOrderRegist);
            this.panel1.Controls.Add(this.buttonOrderList);
            this.panel1.Controls.Add(this.userControlOrder);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 452);
            this.panel1.TabIndex = 148;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.buttonStockRegist);
            this.panel2.Controls.Add(this.buttonStockManual);
            this.panel2.Controls.Add(this.buttonStockList);
            this.panel2.Controls.Add(this.userControlStock);
            this.panel2.Location = new System.Drawing.Point(397, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 452);
            this.panel2.TabIndex = 149;
            // 
            // userControlStock
            // 
            this.userControlStock.BackColor = System.Drawing.Color.Transparent;
            this.userControlStock.Location = new System.Drawing.Point(24, 54);
            this.userControlStock.Name = "userControlStock";
            this.userControlStock.Size = new System.Drawing.Size(320, 380);
            this.userControlStock.TabIndex = 1;
            // 
            // userControlOrder
            // 
            this.userControlOrder.BackColor = System.Drawing.Color.Transparent;
            this.userControlOrder.Location = new System.Drawing.Point(19, 54);
            this.userControlOrder.Name = "userControlOrder";
            this.userControlOrder.Size = new System.Drawing.Size(320, 380);
            this.userControlOrder.TabIndex = 0;
            // 
            // buttonOrderManual
            // 
            this.buttonOrderManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOrderManual.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold);
            this.buttonOrderManual.ForeColor = System.Drawing.Color.White;
            this.buttonOrderManual.Location = new System.Drawing.Point(218, 247);
            this.buttonOrderManual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderManual.Name = "buttonOrderManual";
            this.buttonOrderManual.Size = new System.Drawing.Size(130, 80);
            this.buttonOrderManual.TabIndex = 173;
            this.buttonOrderManual.Text = "注文登録\r\n(マニュアル)";
            this.buttonOrderManual.UseVisualStyleBackColor = false;
            this.buttonOrderManual.Click += new System.EventHandler(this.buttonOrderManual_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlSetting userControlOrder;
        private UserControlSetting userControlStock;
        private System.Windows.Forms.Button buttonOrderRegist;
        private System.Windows.Forms.Button buttonStockRegist;
        private System.Windows.Forms.Button buttonOrderList;
        private System.Windows.Forms.Button buttonStockList;
        private System.Windows.Forms.Button buttonStockManual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOrderManual;
    }
}

