﻿namespace CountClick
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
            this.labelShow = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btResert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelShow.Location = new System.Drawing.Point(60, 50);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(285, 42);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "你已點了滑鼠  0下";
            this.labelShow.Click += new System.EventHandler(this.labelShow_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btStart.Location = new System.Drawing.Point(87, 121);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(220, 70);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Click";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btResert
            // 
            this.btResert.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btResert.Location = new System.Drawing.Point(87, 206);
            this.btResert.Name = "btResert";
            this.btResert.Size = new System.Drawing.Size(220, 70);
            this.btResert.TabIndex = 2;
            this.btResert.Text = "Resert";
            this.btResert.UseVisualStyleBackColor = true;
            this.btResert.Click += new System.EventHandler(this.btResert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(26, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "說明：藉由點擊Click來計算點擊次數，點擊次數會顯示在視窗內，可點擊Reset重設點擊次數。";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btResert);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.labelShow);
            this.Name = "Form1";
            this.Text = "Count Click";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btResert;
        private System.Windows.Forms.Label label1;
    }
}

