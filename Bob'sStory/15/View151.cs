using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bob_sStory._15
{
    public partial class View151 : Form
    {
        public View151()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View152 f = new View152();
            f.Show();
            Hide();
        }
    }
}
