using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==  (char)13)
            {
                if (string.IsNullOrEmpty(txtsearch.Text))
                {
                    this.betamartTableAdapter.Fill(this.appData.Betamart);
                    betamartBindingSource.DataSource = this.appData.Betamart;
                    //dataGridView.DataSource = betamartBindingSource;
                }
                else
                {
                    var query = from o in this.appData.Betamart
                                where o.NamaBarang.Contains(txtsearch.Text)
                                select o;
                    betamartBindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    betamartBindingSource.RemoveCurrent();
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() {Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtnamabarang.Focus();
                this.appData.Betamart.AddBetamartRow(this.appData.Betamart.NewBetamartRow());
                betamartBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtnamabarang.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            betamartBindingSource.ResetBindings(false);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                betamartBindingSource.EndEdit();
                betamartTableAdapter.Update(this.appData.Betamart);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Betamart' table. You can move, or remove it, as needed.
            this.betamartTableAdapter.Fill(this.appData.Betamart);
            betamartBindingSource.DataSource = this.appData.Betamart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Produk Ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                betamartBindingSource.RemoveCurrent();
                betamartTableAdapter.Update(this.appData.Betamart);
                betamartBindingSource.EndEdit();
                betamartBindingSource.ResetBindings(false);
            }
        }
    }
}
