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
    public partial class FormSanPham : Form
    {
        Modify modify;
        SanPham sanPham;
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.GetAllSanPham();
              
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Lỗi"+ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string name = this.textBox2.Text;
            string country=this.textBox3.Text; 
            string info = this.textBox4.Text;
            string von = this.textBox5.Text;
            string giathue = this.textBox6.Text;
            sanPham = new SanPham(id,name,country,info,von,giathue);
            if(modify.insert(sanPham) )
            {
                dataGridView1.DataSource = modify.GetAllSanPham();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không thêm vào được ", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        private void Fix_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string name = this.textBox2.Text;
            string country = this.textBox3.Text;
            string info = this.textBox4.Text;
            string von = this.textBox5.Text;
            string giathue = this.textBox6.Text;
            sanPham = new SanPham(id, name, country, info, von, giathue);
            if (modify.update(sanPham))
            {
                dataGridView1.DataSource = modify.GetAllSanPham();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không sửa được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(modify.delete(id))
            {
                dataGridView1.DataSource = modify.GetAllSanPham();
            }
            else
            {
                MessageBox.Show("Lỗi:" + "Không xoá được ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
