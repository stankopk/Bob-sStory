using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bob_sStory._24
{
    public partial class View242 : Form
    {
        public View242()
        {
            InitializeComponent();
        }

        private void btnBck1_Click(object sender, EventArgs e)
        {
            View241 f = new View241();
            f.Show();
            Hide();
        }

        private void btnNxt2_Click(object sender, EventArgs e)
        {
            View243 f = new View243();
            f.Show();
            Hide();
        }
    }
}
