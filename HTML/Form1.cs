using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForHtml;


namespace HTML
{
    public partial class MyForm : Form
    {
        string text;
        string text2;
        string tmp = "";
        string path="D:\\";
        public MyForm()
        {
            text2 = "<!DOCTYPE html>\n<html lang=\"ru\">\n";
            ForHtml.Head head = new Head();
            text2 += head.CreateHead();
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ForHtml.Body body = new Body(text);
           text2+= body.CreateBody();
            text2 += "</html>";
           
           
            ForHtml.CreateFile cf = new ForHtml.CreateFile(path, text2);
            cf.CreateHtmlFile();
            this.Close();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            MiniForm mini = new MiniForm();
            mini.ShowDialog();
                if (mini.DialogResult == System.Windows.Forms.DialogResult.OK)
                tmp = mini.Str();
            
            text += add.addDiv(tmp);
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            text += add.addA();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            text += add.addP();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            text += add.addImg();
        }

        private void InPath_TextChanged(object sender, EventArgs e)
        {
            path = InPath.Text;
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            text += add.addSection();
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            text += add.addArticle();
        }

        private void btnHeader_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            MiniForm mini = new MiniForm();
            mini.ShowDialog();
            if (mini.DialogResult == System.Windows.Forms.DialogResult.OK)
                tmp = mini.Str();

            text += add.addHeader(tmp);
        }

        private void btnFooter_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            MiniForm mini = new MiniForm();
            mini.ShowDialog();
            if (mini.DialogResult == System.Windows.Forms.DialogResult.OK)
                tmp = mini.Str();

            text += add.addFooter(tmp);
        }
    }
}
