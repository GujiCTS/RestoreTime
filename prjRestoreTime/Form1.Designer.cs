namespace prjRestoreTime
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbRestoreType = new System.Windows.Forms.ComboBox();
            this.tbMaxHP = new System.Windows.Forms.TextBox();
            this.tbCurrentHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRestoreType
            // 
            this.cbRestoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestoreType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbRestoreType.FormattingEnabled = true;
            this.cbRestoreType.Items.AddRange(new object[] {
            "3分鐘/體",
            "5分鐘/體"});
            this.cbRestoreType.Location = new System.Drawing.Point(50, 50);
            this.cbRestoreType.Name = "cbRestoreType";
            this.cbRestoreType.Size = new System.Drawing.Size(121, 24);
            this.cbRestoreType.TabIndex = 0;
            this.cbRestoreType.TabStop = false;
            // 
            // tbMaxHP
            // 
            this.tbMaxHP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMaxHP.Location = new System.Drawing.Point(169, 100);
            this.tbMaxHP.Name = "tbMaxHP";
            this.tbMaxHP.Size = new System.Drawing.Size(100, 27);
            this.tbMaxHP.TabIndex = 1;
            this.tbMaxHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCurrentHP
            // 
            this.tbCurrentHP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCurrentHP.Location = new System.Drawing.Point(50, 100);
            this.tbCurrentHP.Name = "tbCurrentHP";
            this.tbCurrentHP.Size = new System.Drawing.Size(100, 27);
            this.tbCurrentHP.TabIndex = 1;
            this.tbCurrentHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(150, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsg.Location = new System.Drawing.Point(50, 150);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(157, 21);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "預計滿體時間：";
            // 
            // btnCalculation
            // 
            this.btnCalculation.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculation.Location = new System.Drawing.Point(279, 102);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(75, 23);
            this.btnCalculation.TabIndex = 4;
            this.btnCalculation.Text = "計算";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrentHP);
            this.Controls.Add(this.tbMaxHP);
            this.Controls.Add(this.cbRestoreType);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "回體計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRestoreType;
        private System.Windows.Forms.TextBox tbMaxHP;
        private System.Windows.Forms.TextBox tbCurrentHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCalculation;
    }
}

