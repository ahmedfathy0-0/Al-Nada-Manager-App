using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Nada_Manager_App
{
    public partial class MainAF : AF
    {
        private static MainAF _obj;
        public MainAF()
        {
            InitializeComponent();
            _obj = this;
        }

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

        private void MainAF_Load(object sender, EventArgs e)
        {
            _obj = this;
            Maxbtn.PerformClick();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
