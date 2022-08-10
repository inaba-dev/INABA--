namespace APP
{
    partial class FormRegist
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaker = new System.Windows.Forms.TextBox();
            this.dateDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textOrderDate = new APP.TextBoxAlphabet();
            this.textUniqueNumber = new APP.TextBoxAlphabet();
            this.textProductName = new APP.TextBoxAlphabet();
            this.textOrderNumber = new APP.TextBoxAlphabet();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(252, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 177;
            this.label3.Text = "メーカー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 178;
            this.label2.Text = "型式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(252, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 179;
            this.label6.Text = "納期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(252, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 180;
            this.label4.Text = "数量";
            // 
            // textMaker
            // 
            this.textMaker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMaker.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textMaker.Location = new System.Drawing.Point(256, 120);
            this.textMaker.Name = "textMaker";
            this.textMaker.Size = new System.Drawing.Size(240, 24);
            this.textMaker.TabIndex = 187;
            // 
            // dateDeliveryDate
            // 
            this.dateDeliveryDate.CalendarFont = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateDeliveryDate.Font = new System.Drawing.Font("メイリオ", 11F);
            this.dateDeliveryDate.Location = new System.Drawing.Point(256, 241);
            this.dateDeliveryDate.Name = "dateDeliveryDate";
            this.dateDeliveryDate.Size = new System.Drawing.Size(147, 29);
            this.dateDeliveryDate.TabIndex = 189;
            // 
            // numericQuantity
            // 
            this.numericQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericQuantity.Font = new System.Drawing.Font("メイリオ", 12F);
            this.numericQuantity.Location = new System.Drawing.Point(255, 304);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(147, 27);
            this.numericQuantity.TabIndex = 190;
            this.numericQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(28, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(468, 40);
            this.labelTitle.TabIndex = 191;
            this.labelTitle.Text = "XXXXXXXX";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 176;
            this.label1.Text = "注文番号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(292, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 193;
            this.label5.Text = "(必須)";
            // 
            // buttonExec
            // 
            this.buttonExec.BackColor = System.Drawing.Color.Gray;
            this.buttonExec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonExec.Enabled = false;
            this.buttonExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExec.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExec.ForeColor = System.Drawing.Color.White;
            this.buttonExec.Location = new System.Drawing.Point(28, 365);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(468, 61);
            this.buttonExec.TabIndex = 196;
            this.buttonExec.Text = "登録";
            this.buttonExec.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 197;
            this.label7.Text = "識別番号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(23, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 199;
            this.label10.Text = "注文日";
            // 
            // textOrderDate
            // 
            this.textOrderDate.BackColor = System.Drawing.Color.Silver;
            this.textOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOrderDate.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textOrderDate.Location = new System.Drawing.Point(28, 243);
            this.textOrderDate.Name = "textOrderDate";
            this.textOrderDate.ReadOnly = true;
            this.textOrderDate.Size = new System.Drawing.Size(147, 24);
            this.textOrderDate.TabIndex = 200;
            // 
            // textUniqueNumber
            // 
            this.textUniqueNumber.BackColor = System.Drawing.Color.Silver;
            this.textUniqueNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUniqueNumber.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textUniqueNumber.Location = new System.Drawing.Point(28, 183);
            this.textUniqueNumber.Name = "textUniqueNumber";
            this.textUniqueNumber.ReadOnly = true;
            this.textUniqueNumber.Size = new System.Drawing.Size(200, 24);
            this.textUniqueNumber.TabIndex = 198;
            // 
            // textProductName
            // 
            this.textProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProductName.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textProductName.Location = new System.Drawing.Point(256, 182);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(240, 24);
            this.textProductName.TabIndex = 188;
            // 
            // textOrderNumber
            // 
            this.textOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOrderNumber.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textOrderNumber.Location = new System.Drawing.Point(28, 120);
            this.textOrderNumber.Name = "textOrderNumber";
            this.textOrderNumber.Size = new System.Drawing.Size(200, 24);
            this.textOrderNumber.TabIndex = 185;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkStatus.Location = new System.Drawing.Point(27, 304);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(109, 28);
            this.checkStatus.TabIndex = 201;
            this.checkStatus.Text = "ステータス";
            this.checkStatus.UseVisualStyleBackColor = true;
            this.checkStatus.Visible = false;
            // 
            // FormRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.checkStatus);
            this.Controls.Add(this.textOrderDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textUniqueNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.dateDeliveryDate);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.textMaker);
            this.Controls.Add(this.textOrderNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRegist";
            this.Text = "XXXXXX";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaker;
        private TextBoxAlphabet textProductName;
        private System.Windows.Forms.DateTimePicker dateDeliveryDate;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private TextBoxAlphabet textOrderNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Timer timer;
        private TextBoxAlphabet textUniqueNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private TextBoxAlphabet textOrderDate;
        private System.Windows.Forms.CheckBox checkStatus;
    }
}