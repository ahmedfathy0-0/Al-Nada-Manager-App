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
    public partial class AF : Form
    {
        public AF()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (MainAF.Instance != null)
            {
                guna2MessageDialog1.Parent = MainAF.Instance;
            }
        }

        private void AF_Load(object sender, EventArgs e)
        {

        }
    }
}
