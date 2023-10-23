using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThue.Views.ChildForm
{
    public partial class FormKhachHang : Form
    {
        Modify modify;
        KhachHang khachHang;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.GetAllKhachHang();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemKH_Click(object sender, EventArgs e)
        {
            string idkh = this.textBox1.Text;
            string namekh = this.textBox2.Text;
            string addresskh = this.textBox3.Text;
            string numberkh = this.textBox4.Text;          
            khachHang = new KhachHang(idkh,namekh,addresskh,numberkh);
            if (modify.insert(khachHang))
            {
                dataGridView1.DataSource = modify.GetAllKhachHang();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không thêm vào được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaKH_Click(object sender, EventArgs e)
        {
            string idkh = this.textBox1.Text;
            string namekh = this.textBox2.Text;
            string addresskh = this.textBox3.Text;
            string numberkh = this.textBox4.Text;
            khachHang = new KhachHang(idkh, namekh, addresskh, numberkh);
            if (modify.update(khachHang))
            {
                dataGridView1.DataSource = modify.GetAllKhachHang();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không thêm vào được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaKH_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deletekh(id))
            {
                dataGridView1.DataSource = modify.GetAllKhachHang();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không xoá được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
