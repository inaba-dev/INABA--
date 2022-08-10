namespace APP
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectStatus = new APP.SelectBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.selectMaker = new APP.SelectBoxEx();
            this.selectProduct = new APP.SelectBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userControlStatus = new APP.UserControlStatus();
            this.dataGridView = new APP.DataGridViewEx();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.selectStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.selectMaker);
            this.panel1.Controls.Add(this.selectProduct);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 70);
            this.panel1.TabIndex = 37;
            // 
            // selectStatus
            // 
            this.selectStatus.BackColor = System.Drawing.SystemColors.Info;
            this.selectStatus.BorderColor = System.Drawing.Color.Silver;
            this.selectStatus.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.selectStatus.Font = new System.Drawing.Font("メイリオ", 10F);
            this.selectStatus.FormattingEnabled = true;
            this.selectStatus.Location = new System.Drawing.Point(527, 32);
            this.selectStatus.Name = "selectStatus";
            this.selectStatus.Size = new System.Drawing.Size(81, 28);
            this.selectStatus.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(527, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 139;
            this.label4.Text = "ステータス";
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSearch.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(627, 12);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(152, 49);
            this.labelSearch.TabIndex = 36;
            this.labelSearch.Text = "検索実行";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker.Font = new System.Drawing.Font("メイリオ", 10F);
            this.dateTimePicker.Location = new System.Drawing.Point(20, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(17, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 137;
            this.label7.Text = "対象日";
            // 
            // selectMaker
            // 
            this.selectMaker.BackColor = System.Drawing.SystemColors.Info;
            this.selectMaker.BorderColor = System.Drawing.Color.Silver;
            this.selectMaker.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.selectMaker.Font = new System.Drawing.Font("メイリオ", 10F);
            this.selectMaker.FormattingEnabled = true;
            this.selectMaker.Location = new System.Drawing.Point(393, 32);
            this.selectMaker.Name = "selectMaker";
            this.selectMaker.Size = new System.Drawing.Size(120, 28);
            this.selectMaker.TabIndex = 63;
            // 
            // selectProduct
            // 
            this.selectProduct.BackColor = System.Drawing.SystemColors.Info;
            this.selectProduct.BorderColor = System.Drawing.Color.Silver;
            this.selectProduct.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.selectProduct.Font = new System.Drawing.Font("メイリオ", 10F);
            this.selectProduct.FormattingEnabled = true;
            this.selectProduct.Location = new System.Drawing.Point(155, 32);
            this.selectProduct.Name = "selectProduct";
            this.selectProduct.Size = new System.Drawing.Size(225, 28);
            this.selectProduct.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(158, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "型番";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(390, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "メーカー";
            // 
            // userControlStatus
            // 
            this.userControlStatus.BackColor = System.Drawing.Color.LightGray;
            this.userControlStatus.Location = new System.Drawing.Point(829, 12);
            this.userControlStatus.Name = "userControlStatus";
            this.userControlStatus.Size = new System.Drawing.Size(400, 70);
            this.userControlStatus.TabIndex = 39;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(12, 97);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(1320, 542);
            this.dataGridView.TabIndex = 38;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.userControlStatus);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1360, 700);
            this.MinimumSize = new System.Drawing.Size(1360, 700);
            this.Name = "FormOrder";
            this.Text = "納期状況";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SelectBoxEx selectMaker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSearch;
        private SelectBoxEx selectProduct;
        private System.Windows.Forms.Label label3;
        private DataGridViewEx dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private UserControlStatus userControlStatus;
        private SelectBoxEx selectStatus;
        private System.Windows.Forms.Label label4;
    }
}