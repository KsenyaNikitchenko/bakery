using System.Data;
using Npgsql;

namespace cooking
{
    public partial class RemainsProductsForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public RemainsProductsForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public void UpdateRemains(DateTime date)
        {
            string sql = "select name_product, incoming_quantity,baking_quantity, (incoming_quantity - baking_quantity) as remains " +
                "from(select product_id, sum(quantity) as incoming_quantity from incoming_invoice_content " +
                "where iinvoice_id in (select id_iinvoice from incoming_invoice where date <= :date1) " +
                "group by product_id) as all_incoming join(select product_id, sum(sum_baking * product_quantity) as baking_quantity " +
                "from recipes join (select baking_id, sum(baking_quantity) as sum_baking " +
                "from baking_invoice where date <= :date2 group by baking_id) all_baking " +
                "on(recipes.baking_id = all_baking.baking_id) join recipes_content rc on(recipes.id_recipe= rc.recipe_id) " +
                "group by product_id) as all_baking on(all_incoming.product_id = all_baking.product_id) join products " +
                "on(all_incoming.product_id = products.id_product) order by id_product";
            NpgsqlCommand command = new NpgsqlCommand(sql, con);
            command.Parameters.AddWithValue(":date1", date);
            command.Parameters.AddWithValue(":date2", date);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Название продукта";
            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].HeaderText = "Куплено";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Потрачено";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].HeaderText = "Остатки";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void countRemains_menu_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            UpdateRemains(date);
        }

        private void exit_menu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
