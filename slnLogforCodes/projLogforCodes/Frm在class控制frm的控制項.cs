using projLogforCodes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLogforCodes
{
    public partial class Frm在class控制frm的控制項 : Form
    {
        public Frm在class控制frm的控制項()
        {
            InitializeComponent();
        }
        //在CCustomer新增電話欄位前
        private void btnShowBefor_Click(object sender, EventArgs e)
        {
            CCustomer x = new CCustomer();
            x.name = txtNameBefor.Text;
            x.email = txtEmailBefor.Text;
            
            string s = txtResultBefor.Text;
            
            CCustomerFactory c = new CCustomerFactory();
            c.show(x,ref s);

            txtResultBefor.Text = s;
        }
        //在CCustomer新增電話欄位後
        private void btnShowAfter_Click(object sender, EventArgs e)
        {
            CCustomer x = new CCustomer();
            x.name = txtNameBefor.Text;
            x.email = txtEmailBefor.Text;
            x.phone = txtPhoneAfter.Text;

             string s = txtResultAfter.Text;

            CCustomerFactory c = new CCustomerFactory();
            c.show(x, ref s);

            txtResultAfter.Text = s;
        }
    }
}
