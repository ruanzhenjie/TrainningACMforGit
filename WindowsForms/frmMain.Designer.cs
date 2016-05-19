namespace WindowsFormsApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnIncreasement = new System.Windows.Forms.Button();
            this.btnImportment = new System.Windows.Forms.Button();
            this.btnExportment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnPrepage = new System.Windows.Forms.Button();
            this.btnNextpage = new System.Windows.Forms.Button();
            this.btnTrapage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(26, 24);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "题目";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnIncreasement
            // 
            this.btnIncreasement.Location = new System.Drawing.Point(215, 24);
            this.btnIncreasement.Name = "btnIncreasement";
            this.btnIncreasement.Size = new System.Drawing.Size(75, 23);
            this.btnIncreasement.TabIndex = 1;
            this.btnIncreasement.Text = "增加";
            this.btnIncreasement.UseVisualStyleBackColor = true;
            this.btnIncreasement.Click += new System.EventHandler(this.btnIncreasement_Click);
            // 
            // btnImportment
            // 
            this.btnImportment.Location = new System.Drawing.Point(307, 24);
            this.btnImportment.Name = "btnImportment";
            this.btnImportment.Size = new System.Drawing.Size(75, 23);
            this.btnImportment.TabIndex = 2;
            this.btnImportment.Text = "导入";
            this.btnImportment.UseVisualStyleBackColor = true;
            this.btnImportment.Click += new System.EventHandler(this.btnImportment_Click);
            // 
            // btnExportment
            // 
            this.btnExportment.Location = new System.Drawing.Point(399, 24);
            this.btnExportment.Name = "btnExportment";
            this.btnExportment.Size = new System.Drawing.Size(75, 23);
            this.btnExportment.TabIndex = 3;
            this.btnExportment.Text = "导出";
            this.btnExportment.UseVisualStyleBackColor = true;
            this.btnExportment.Click += new System.EventHandler(this.btnExportment_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 244);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnHomepage
            // 
            this.btnHomepage.Location = new System.Drawing.Point(101, 329);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(38, 23);
            this.btnHomepage.TabIndex = 5;
            this.btnHomepage.Text = "首页";
            this.btnHomepage.UseVisualStyleBackColor = true;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            // 
            // btnPrepage
            // 
            this.btnPrepage.Location = new System.Drawing.Point(145, 329);
            this.btnPrepage.Name = "btnPrepage";
            this.btnPrepage.Size = new System.Drawing.Size(61, 23);
            this.btnPrepage.TabIndex = 6;
            this.btnPrepage.Text = "<上一页";
            this.btnPrepage.UseVisualStyleBackColor = true;
            this.btnPrepage.Click += new System.EventHandler(this.btnPrepage_Click);
            // 
            // btnNextpage
            // 
            this.btnNextpage.Location = new System.Drawing.Point(282, 329);
            this.btnNextpage.Name = "btnNextpage";
            this.btnNextpage.Size = new System.Drawing.Size(56, 23);
            this.btnNextpage.TabIndex = 7;
            this.btnNextpage.Text = "下一页>";
            this.btnNextpage.UseVisualStyleBackColor = true;
            this.btnNextpage.Click += new System.EventHandler(this.btnNextpage_Click);
            // 
            // btnTrapage
            // 
            this.btnTrapage.Location = new System.Drawing.Point(349, 330);
            this.btnTrapage.Name = "btnTrapage";
            this.btnTrapage.Size = new System.Drawing.Size(39, 23);
            this.btnTrapage.TabIndex = 8;
            this.btnTrapage.Text = "尾页";
            this.btnTrapage.UseVisualStyleBackColor = true;
            this.btnTrapage.Click += new System.EventHandler(this.btnTrapage_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(217, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrapage);
            this.Controls.Add(this.btnNextpage);
            this.Controls.Add(this.btnPrepage);
            this.Controls.Add(this.btnHomepage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportment);
            this.Controls.Add(this.btnImportment);
            this.Controls.Add(this.btnIncreasement);
            this.Controls.Add(this.btnTitle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnIncreasement;
        private System.Windows.Forms.Button btnImportment;
        private System.Windows.Forms.Button btnExportment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Button btnPrepage;
        private System.Windows.Forms.Button btnNextpage;
        private System.Windows.Forms.Button btnTrapage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}

