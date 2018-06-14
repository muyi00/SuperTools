using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loadForm(this.panel1,new FilterLogForm());
            loadForm(this.panel2, new PictureName());
        }


        private void loadForm(Panel panel, BaseForm baseForm)
        {
            baseForm.FormBorderStyle = FormBorderStyle.None;
            baseForm.TopLevel = false;
            panel.Controls.Add(baseForm);
            baseForm.Show();
        }

    }
}
