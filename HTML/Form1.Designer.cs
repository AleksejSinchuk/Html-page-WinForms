namespace HTML
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InPath = new System.Windows.Forms.TextBox();
            this.btnFooter = new System.Windows.Forms.Button();
            this.btnHeader = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(642, 395);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(185, 142);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(185, 185);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 27);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(185, 229);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 28);
            this.btnP.TabIndex = 3;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(185, 275);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 30);
            this.btnImg.TabIndex = 4;
            this.btnImg.Text = "Img";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(448, 46);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the path";
            // 
            // InPath
            // 
            this.InPath.Location = new System.Drawing.Point(185, 46);
            this.InPath.Name = "InPath";
            this.InPath.Size = new System.Drawing.Size(207, 22);
            this.InPath.TabIndex = 7;
            this.InPath.Text = "D:\\";
            this.InPath.TextChanged += new System.EventHandler(this.InPath_TextChanged);
            // 
            // btnFooter
            // 
            this.btnFooter.Location = new System.Drawing.Point(363, 282);
            this.btnFooter.Name = "btnFooter";
            this.btnFooter.Size = new System.Drawing.Size(75, 23);
            this.btnFooter.TabIndex = 13;
            this.btnFooter.Text = "Footer";
            this.btnFooter.UseVisualStyleBackColor = true;
            this.btnFooter.Click += new System.EventHandler(this.btnFooter_Click);
            // 
            // btnHeader
            // 
            this.btnHeader.Location = new System.Drawing.Point(363, 234);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(75, 23);
            this.btnHeader.TabIndex = 12;
            this.btnHeader.Text = "Header";
            this.btnHeader.UseVisualStyleBackColor = true;
            this.btnHeader.Click += new System.EventHandler(this.btnHeader_Click);
            // 
            // btnArticle
            // 
            this.btnArticle.Location = new System.Drawing.Point(363, 185);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(75, 23);
            this.btnArticle.TabIndex = 11;
            this.btnArticle.Text = "Article";
            this.btnArticle.UseVisualStyleBackColor = true;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnSection
            // 
            this.btnSection.Location = new System.Drawing.Point(363, 142);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(75, 23);
            this.btnSection.TabIndex = 10;
            this.btnSection.Text = "Section";
            this.btnSection.UseVisualStyleBackColor = true;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFooter);
            this.Controls.Add(this.btnHeader);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.InPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnOk);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InPath;
        private System.Windows.Forms.Button btnFooter;
        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnSection;
    }
}

