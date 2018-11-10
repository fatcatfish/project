using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsrcFileSymulator
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        String nstr = "";
        public String getText()
        {
            foreach (Control cur in this.Controls.OfType<TextBox>())
            {
                if (cur.Name.StartsWith("fileText"))
                {
                    nstr += cur.Text;
                }
            }
            return nstr;
        }
    }
}
