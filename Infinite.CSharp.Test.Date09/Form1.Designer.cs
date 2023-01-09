namespace Infinite.CSharp.Test.Date09
{
    partial class Form1
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
            this.LblCustomerCity = new System.Windows.Forms.Label();
            this.TxtCustomerCity = new System.Windows.Forms.TextBox();
            this.LblSortBy = new System.Windows.Forms.Label();
            this.CbSortBy = new System.Windows.Forms.ComboBox();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.LblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustomerCity
            // 
            this.LblCustomerCity.AutoSize = true;
            this.LblCustomerCity.Location = new System.Drawing.Point(112, 51);
            this.LblCustomerCity.Name = "LblCustomerCity";
            this.LblCustomerCity.Size = new System.Drawing.Size(71, 13);
            this.LblCustomerCity.TabIndex = 0;
            this.LblCustomerCity.Text = "Customer City";
            // 
            // TxtCustomerCity
            // 
            this.TxtCustomerCity.Location = new System.Drawing.Point(213, 44);
            this.TxtCustomerCity.Name = "TxtCustomerCity";
            this.TxtCustomerCity.Size = new System.Drawing.Size(165, 20);
            this.TxtCustomerCity.TabIndex = 1;
            // 
            // LblSortBy
            // 
            this.LblSortBy.AutoSize = true;
            this.LblSortBy.Location = new System.Drawing.Point(111, 88);
            this.LblSortBy.Name = "LblSortBy";
            this.LblSortBy.Size = new System.Drawing.Size(41, 13);
            this.LblSortBy.TabIndex = 2;
            this.LblSortBy.Text = "Sort By";
            // 
            // CbSortBy
            // 
            this.CbSortBy.FormattingEnabled = true;
            this.CbSortBy.Location = new System.Drawing.Point(220, 88);
            this.CbSortBy.Name = "CbSortBy";
            this.CbSortBy.Size = new System.Drawing.Size(157, 21);
            this.CbSortBy.TabIndex = 3;
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(54, 153);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(706, 234);
            this.Grid1.TabIndex = 4;
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(578, 31);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(153, 47);
            this.BtnGetData.TabIndex = 5;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(307, 412);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 13);
            this.LblMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.CbSortBy);
            this.Controls.Add(this.LblSortBy);
            this.Controls.Add(this.TxtCustomerCity);
            this.Controls.Add(this.LblCustomerCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomerCity;
        private System.Windows.Forms.TextBox TxtCustomerCity;
        private System.Windows.Forms.Label LblSortBy;
        private System.Windows.Forms.ComboBox CbSortBy;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.Label LblMessage;
    }
}

