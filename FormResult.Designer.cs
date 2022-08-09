namespace APP
{
    partial class FormResult
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectMaker = new APP.SelectBoxEx();
            this.selectProduct = new APP.SelectBoxEx();
            this.selectStatus = new APP.SelectBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.dataGridView = new APP.DataGridViewEx();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.selectMaker);
            this.panel1.Controls.Add(this.selectProduct);
            this.panel1.Controls.Add(this.selectStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 70);
            this.panel1.TabIndex = 37;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker.Font = new System.Drawing.Font("メイリオ", 10F);
            this.dateTimePicker.Location = new System.Drawing.Point(18, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker.TabIndex = 132;
            // 
            // selectMaker
            // 
            this.selectMaker.BackColor = System.Drawing.SystemColors.Info;
            this.selectMaker.BorderColor = System.Drawing.Color.Silver;
            this.selectMaker.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.selectMaker.Font = new System.Drawing.Font("メイリオ", 10F);
            this.selectMaker.FormattingEnabled = true;
            this.selectMaker.Location = new System.Drawing.Point(403, 30);
            this.selectMaker.Name = "selectMaker";
            this.selectMaker.Size = new System.Drawing.Size(150, 28);
            this.selectMaker.TabIndex = 63;
            this.selectMaker.Visible = false;
            // 
            // selectProduct
            // 
            this.selectProduct.BackColor = System.Drawing.SystemColors.Info;
            this.selectProduct.BorderColor = System.Drawing.Color.Silver;
            this.selectProduct.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.selectProduct.Font = new System.Drawing.Font("メイリオ", 10F);
            this.selectProduct.FormattingEnabled = true;
            this.selectProduct.Location = new System.Drawing.Point(159, 30);
            this.selectProduct.Name = "selectProduct";
            this.selectProduct.Size = new System.Drawing.Size(225, 28);
            this.selectProduct.TabIndex = 62;
            // 
            // selectStatus
            // 
            this.selectStatus.BackColor = System.Drawing.SystemColors.Info;
            this.selectStatus.BorderColor = System.Drawing.Color.Silver;
            this.selectStatus.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.selectStatus.Font = new System.Drawing.Font("メイリオ", 10F);
            this.selectStatus.FormattingEnabled = true;
            this.selectStatus.Location = new System.Drawing.Point(574, 30);
            this.selectStatus.Name = "selectStatus";
            this.selectStatus.Size = new System.Drawing.Size(81, 28);
            this.selectStatus.TabIndex = 61;
            this.selectStatus.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(577, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "ステータス";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(163, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "型番";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "対象日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(406, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "メーカー";
            this.label1.Visible = false;
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSearch.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(679, 14);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(119, 46);
            this.labelSearch.TabIndex = 36;
            this.labelSearch.Text = "検索実行";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelSave
            // 
            this.labelSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSave.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSave.ForeColor = System.Drawing.Color.White;
            this.labelSave.Location = new System.Drawing.Point(852, 26);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(157, 46);
            this.labelSave.TabIndex = 39;
            this.labelSave.Text = "保存";
            this.labelSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
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
            this.dataGridView.Size = new System.Drawing.Size(1000, 552);
            this.dataGridView.TabIndex = 38;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 661);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1043, 700);
            this.MinimumSize = new System.Drawing.Size(1043, 700);
            this.Name = "FormResult";
            this.Text = "納期状況";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SelectBoxEx selectMaker;
        private SelectBoxEx selectStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSearch;
        private SelectBoxEx selectProduct;
        private System.Windows.Forms.Label label3;
        private DataGridViewEx dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelSave;
    }
}