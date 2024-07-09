using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Nada_Manager
{
    public partial class MainAF : AF

    {
        static MainAF _obj;
        public static MainAF Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainAF();
                }
                return _obj;
            }
        }
        public MainAF()
        {
            InitializeComponent();
        }
        private void MainAF_load(object sender, EventArgs e)
        {
            _obj = this;
        }


    }
}
