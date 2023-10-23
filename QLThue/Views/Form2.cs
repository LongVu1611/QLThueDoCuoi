using QLThue.Views.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThue.Views
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form currenFormChild;
        private void OpenChildForm(Form childForm)
        { 
            if (currenFormChild != null) 
            { 
                currenFormChild.Close() ; 
            }
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void SANPHAMbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham());
            label1.Text = SANPHAMbt.Text;
        }

        private void KHACHHANGbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
            label1.Text = KHACHHANGbt.Text;
        }

        private void TINHTRANGbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTTChoThue());
            label1.Text = TINHTRANGbt.Text;
        }

        private void TAOPHIEUTHUEbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhieuThue());
            label1.Text = TAOPHIEUTHUEbt.Text;
        }
    }
}
