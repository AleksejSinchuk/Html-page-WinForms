namespace HTML
{
    partial class MiniForm
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
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnHeader = new System.Windows.Forms.Button();
            this.btnFooter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(56, 118);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(56, 160);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(56, 201);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 2;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(56, 243);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 28);
            this.btnImg.TabIndex = 3;
            this.btnImg.Text = "Img";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(123, 431);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add elements in container";
            // 
            // btnSection
            // 
            this.btnSection.Location = new System.Drawing.Point(213, 118);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(75, 23);
            this.btnSection.TabIndex = 6;
            this.btnSection.Text = "Section";
            this.btnSection.UseVisualStyleBackColor = true;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // btnArticle
            // 
            this.btnArticle.Location = new System.Drawing.Point(213, 160);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(75, 23);
            this.btnArticle.TabIndex = 7;
            this.btnArticle.Text = "Article";
            this.btnArticle.UseVisualStyleBackColor = true;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnHeader
            // 
            this.btnHeader.Location = new System.Drawing.Point(213, 201);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(75, 23);
            this.btnHeader.TabIndex = 8;
            this.btnHeader.Text = "Header";
            this.btnHeader.UseVisualStyleBackColor = true;
            this.btnHeader.Click += new System.EventHandler(this.btnHeader_Click);
            // 
            // btnFooter
            // 
            this.btnFooter.Location = new System.Drawing.Point(213, 248);
            this.btnFooter.Name = "btnFooter";
            this.btnFooter.Size = new System.Drawing.Size(75, 23);
            this.btnFooter.TabIndex = 9;
            this.btnFooter.Text = "Footer";
            this.btnFooter.UseVisualStyleBackColor = true;
            this.btnFooter.Click += new System.EventHandler(this.btnFooter_Click);
            // 
            // MiniForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 482);
            this.Controls.Add(this.btnFooter);
            this.Controls.Add(this.btnHeader);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnDiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniForm";
            this.Text = "MiniForm";
            this.Load += new System.EventHandler(this.MiniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.Button btnFooter;
    }
}