using System.Data;
using Npgsql;
namespace cooking
{
    public partial class ProductsForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public ProductsForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select * from products order by id_product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].HeaderText = "Единица измерения";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void addProduct_menu_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(con,-1);
            addProduct.ShowDialog();
            Update();
        }
        private void changeProduct_menu_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_product"].Value;
            string nameproduct = (string)dataGridView1.CurrentRow.Cells["name_product"].Value;
            string unit = (string)dataGridView1.CurrentRow.Cells["unit"].Value;
            AddProduct addProduct = new AddProduct(con, id, nameproduct, unit);
            addProduct.ShowDialog();
            Update();
        }
        private void deleteProduct_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить продукт?", "Удаление продукта", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id_product"].Value;
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from products where id_product=:id", con);
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
