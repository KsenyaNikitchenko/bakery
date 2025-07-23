using System.Data;
using Npgsql;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cooking
{
    public partial class AverageCostBakingForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AverageCostBakingForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public void UpdateAvgCoast(DateTime start, DateTime end)
        {
            string sql = "select name_baking, price from(select baking_id, sum(product_quantity*average_price) as price " +
                "from recipes join recipes_content rc on (recipes.id_recipe=rc.recipe_id) join (select product_id, " +
                "avg(price) as average_price from incoming_invoice_content where iinvoice_id in(select id_iinvoice " +
                "from incoming_invoice where date between :start and :end) group by product_id) product_info " +
                "on (product_info.product_id=rc.product_id) group by recipes.baking_id) baking_price join baking on " +
                "(baking_price.baking_id=baking.id_baking) order by baking.id_baking";
            NpgsqlCommand command = new NpgsqlCommand(sql, con);
            command.Parameters.AddWithValue(":start", start);
            command.Parameters.AddWithValue(":end", end);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Название выпечки";
            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].HeaderText = "Средняя себестоимость";
            dataGridView1.Columns[1].Width=270;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void countAvgCost_menu_Click(object sender, EventArgs e)
        {
            DateTime start = startDate_dateTP.Value.Date;
            DateTime end = endDate_dateTP.Value.Date;
            UpdateAvgCoast(start, end);
        }

        private void exit_menu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
