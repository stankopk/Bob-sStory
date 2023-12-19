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
    public partial class View152 : Form
    {
        public View152()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View153 n = new View153();
            n.Show();
            Hide();
        }
    }
}
