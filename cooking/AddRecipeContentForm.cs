using Npgsql;
using System.Data;

namespace cooking
{
    public partial class AddRecipeContentForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        int recipe_id, id_rcontent;
        public AddRecipeContentForm(NpgsqlConnection con, int recipe_id)
        {
            InitializeComponent();
            this.con = con;
            this.recipe_id = recipe_id;
            Update();
        }
        public AddRecipeContentForm(NpgsqlConnection con, int recipe_id, int id_rcontent, string name_product, double quantity)
        {
            InitializeComponent();
            this.con = con;
            this.recipe_id = recipe_id;
            this.id_rcontent = id_rcontent;
            Update();
            nameProduct_cmB.SelectedIndex = nameProduct_cmB.FindString(name_product);
            quantity_txtB.Text = quantity.ToString();
        }
        public void Update()
        {
            string sql = "select * from products order by name_product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            nameProduct_cmB.DataSource = dt;
            nameProduct_cmB.DisplayMember = "name_product";
            nameProduct_cmB.ValueMember = "id_product";
        }

        private void addRecipeContent_btn_Click(object sender, EventArgs e)
        {
            if (recipe_id == -1)
            {
                try
                {
                    string sql = "update recipes_content set product_id=@product_id, product_quantity=@quantity where id_rcontent=@id_rcontent";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.Add("@product_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = nameProduct_cmB.SelectedValue;
                        command.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(quantity_txtB.Text);
                        command.Parameters.Add("@id_rcontent", NpgsqlTypes.NpgsqlDbType.Integer).Value = id_rcontent;
                        command.ExecuteNonQuery();
                    }
                    Close();
            }
                catch { }
        }
            else
            {
                try
                {
                    string sql = "insert into recipes_content (recipe_id, product_id, product_quantity) values (@id, @product_id, @quantity)";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = recipe_id;
                        command.Parameters.Add("@product_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = nameProduct_cmB.SelectedValue;
                        command.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(quantity_txtB.Text);
                        command.ExecuteNonQuery();
                    }
                    Close();
                }
                catch { }
            }
        }

        private void cancelAddRecipeContent_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
