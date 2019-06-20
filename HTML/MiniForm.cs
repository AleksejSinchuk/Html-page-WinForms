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
   
    public partial class MiniForm : Form
    {

        string str="";
       
        public MiniForm()
        {
            
            InitializeComponent();
        }

        public string Str()
        {
            return str;
        }
        private void MiniForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addDiv("");
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addA();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addP();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addImg();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addSection();
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addArticle();
        }

        private void btnHeader_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addHeader("");
        }

        private void btnFooter_Click(object sender, EventArgs e)
        {
            ForHtml.AddTags add = new AddTags();
            str += add.addFooter("");
        }
    }
}
