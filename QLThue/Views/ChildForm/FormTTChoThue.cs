using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLThue.Views.ChildForm
{
    public partial class FormTTChoThue : Form
    {
        Modify modify;
        TTChoThue tTChoThue;
        public FormTTChoThue()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTTChoThue_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.GetAllChiTietPhieuThue();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ctpt = this.textBox1.Text;
            string idphieu = this.textBox2.Text;
            string idsp = this.textBox3.Text;
            string soluong = this.textBox4.Text;
            string bill = this.textBox5.Text;
            tTChoThue = new TTChoThue(ctpt,idphieu, idsp,soluong, bill);
            if (modify.insert(tTChoThue))
            {
                dataGridView1.DataSource = modify.GetAllChiTietPhieuThue();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không thêm vào được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ctpt = this.textBox1.Text;
            string idphieu = this.textBox2.Text;
            string idsp = this.textBox3.Text;
            string soluong = this.textBox4.Text;
            string bill = this.textBox5.Text;
            tTChoThue = new TTChoThue(ctpt,idphieu,idsp,soluong,bill);
            if (modify.update(tTChoThue))
            {
                dataGridView1.DataSource = modify.GetAllChiTietPhieuThue();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không sửa được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deletectpt(id))
            {
                dataGridView1.DataSource = modify.GetAllChiTietPhieuThue();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không xoá được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
