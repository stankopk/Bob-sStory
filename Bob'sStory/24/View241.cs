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
    public partial class View241 : Form
    {
        public View241()
        {
            InitializeComponent();
        }

        private void btnNxt1_Click(object sender, EventArgs e)
        {
            View242 f = new View242();
            f.Show();
            Hide();
        }
    }
}
