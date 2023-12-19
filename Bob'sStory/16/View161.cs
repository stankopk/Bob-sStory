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

namespace Bob_sStory._16
{
    public partial class View161 : Form
    {
        public View161()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View162 bobWolfFormTwo = new View162();
            bobWolfFormTwo.Show();
            Hide();
        }
    }
}
