using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class DiaWeb : Form
    {
        string UserID;
        Web selectedWeb;
        public DiaWeb(string id, Web web)
        {
            InitializeComponent();
            selectedWeb = new Web(web);
        }

        void SetColor(Color x)
        {
            bOK.BackColor = bOK.ActiveFillColor = bOK.ForeColor = bOK.IdleForecolor = bOK.IdleLineColor =
                 bExit.BackColor = bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor = x;
        }
    }
}
