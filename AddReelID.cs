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
    public partial class AddReelID : Form
    {
        public AddReelID()
        {
            InitializeComponent();
        }

        private void keydown_event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            var txt_current = sender as TextBox;
            switch(txt_current.Name)
            {
                case "tbx_reel_id": tbx_part_no.Focus(); break;
                case "tbx_part_no": tbx_supplier_pn.Focus(); break;
                case "tbx_supplier_pn": tbx_date_code.Focus(); break;
                case "tbx_date_code": tbx_lot_code.Focus(); break;
                case "tbx_lot_code": tbx_supplier.Focus(); break;
                case "tbx_supplier": tbx_quantity.Focus(); break;
                case "tbx_quantity": tbx_slot.Focus();  break;
                case "tbx_slot": tbx_value.Focus();  break;
                case "tbx_value": tbx_reel_id.Focus(); break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
