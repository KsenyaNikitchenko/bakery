using System.Data;
using Npgsql;
namespace cooking
{
    public partial class BakingInvoiceForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public BakingInvoiceForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select baking_invoice.id_binvoice, baking_invoice.date, baking.name_baking," +
                "baking_invoice.baking_quantity from baking_invoice join baking on (baking_invoice.baking_id=baking.id_baking) order by id_binvoice";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Название выпечки";
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[3].HeaderText = "Количество выпечки";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void addBInvoice_menu_Click(object sender, EventArgs e)
        {
            AddBakingInvoiceForm addBInvoice = new AddBakingInvoiceForm(con, -1);
            addBInvoice.ShowDialog();
            Update();
        }

        private void changeBInvoice_menu_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_binvoice"].Value;
            DateTime date = (DateTime)dataGridView1.CurrentRow.Cells["date"].Value;
            string name_baking = (string)dataGridView1.CurrentRow.Cells["name_baking"].Value;
            int quantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells["baking_quantity"].Value);
            AddBakingInvoiceForm addBInvoice = new AddBakingInvoiceForm(con, id, date, name_baking, quantity);
            addBInvoice.ShowDialog();
            Update();
        }

        private void deleteBInvoice_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную накладную?", "Удаление накладной", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id_binvoice"].Value;
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from baking_invoice where id_binvoice=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            Update();
        }

        private void exit_menu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
