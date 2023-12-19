using Bob_sStory._14;
using Bob_sStory._24;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bob_sStory
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnForest_Click(object sender, EventArgs e)
        {
            View241 f = new View241();
            f.Show();
            Hide();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            View141 f = new View141();
            f.Show();
            Hide();
        }
    }
}
