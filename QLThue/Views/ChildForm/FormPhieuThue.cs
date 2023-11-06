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
    public partial class FormPhieuThue : Form
    {
        Modify modify;
        Thuê thuê;
        public FormPhieuThue()
        {
            InitializeComponent();
        }

        private void FormPhieuThue_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.GetAllPhieuThue();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string idkh = this.textBox2.Text;
            DateTime datego = this.dateTimePicker1.Value;
            DateTime dateback = this.dateTimePicker2.Value;
            string bill = this.textBox3.Text;
            thuê = new Thuê(id,idkh,datego,dateback,bill);
            if (modify.insert(thuê))
            {
                dataGridView1.DataSource = modify.GetAllPhieuThue();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không thêm vào được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string idkh = this.textBox2.Text;
            DateTime datego = this.dateTimePicker1.Value;
            DateTime dateback = this.dateTimePicker2.Value;
            string bill = this.textBox3.Text;
            thuê = new Thuê(id, idkh, datego, dateback, bill);
            if (modify.update(thuê))
            {
                dataGridView1.DataSource = modify.GetAllPhieuThue();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không sửa được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deletethue(id))
            {
                dataGridView1.DataSource = modify.GetAllPhieuThue();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không xoá được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
