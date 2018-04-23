using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils;

namespace Q181266
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            CheckEdit cEdit = (CheckEdit)sender;
            CheckEditViewInfo cInfo = (CheckEditViewInfo)cEdit.GetViewInfo();
            Rectangle r = cInfo.CheckInfo.GlyphRect;
            Rectangle editorRect = new Rectangle(new Point(0, 0), cEdit.Size);
            if (!r.Contains(e.Location) && editorRect.Contains(e.Location))
                ((DXMouseEventArgs)e).Handled = true;
        }
    }
}