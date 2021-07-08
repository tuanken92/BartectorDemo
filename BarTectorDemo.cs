using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartectorDemo
{
    public partial class BarTectorDemo : Form
    {
        public BarTectorDemo()
        {
            InitializeComponent();
        }

        private void btnClickEvent(object sender, EventArgs e)
        {

            AddReelID add_reel_id = new AddReelID();
            add_reel_id.ShowDialog();
        }
    }
}
