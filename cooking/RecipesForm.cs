using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace cooking
{
    public partial class RecipesForm : Form
    {
        public NpgsqlConnection con;
        DataTable resipesTable = new DataTable();
        DataSet recipesSet = new DataSet();
        DataTable resipesContentTable = new DataTable();
        DataSet recipesContentSet = new DataSet();
        public RecipesForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select id_recipe, name_baking from recipes join baking on " +
                "(recipes.baking_id=baking.id_baking) order by id_recipe";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            recipesSet.Reset();
            da.Fill(recipesSet);
            resipesTable = recipesSet.Tables[0];
            dataGridViewRecipes.DataSource = resipesTable;
            dataGridViewRecipes.Columns[0].HeaderText = "Номер";
            dataGridViewRecipes.Columns[1].HeaderText = "Название выпечки";
            dataGridViewRecipes.Columns[1].Width = 302;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void UpdateContent()
        {
            if (dataGridViewRecipes.SelectedRows.Count > 0)
            {
                int id_recipe = Convert.ToInt32(dataGridViewRecipes.SelectedRows[0].Cells["id_recipe"].Value);
                string sql = "select id_rcontent, name_product, product_quantity, unit " +
                "from recipes_content join products on (recipes_content.product_id=products.id_product) "
                + "where recipes_content.recipe_id=:id order by id_rcontent";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.AddWithValue(":id", id_recipe);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                recipesContentSet.Reset();
                da.Fill(recipesContentSet);
                resipesContentTable = recipesContentSet.Tables[0];
                dataGridViewRecipesContent.DataSource = resipesContentTable;
                dataGridViewRecipesContent.Columns[0].HeaderText = "Номер";
                dataGridViewRecipesContent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRecipesContent.Columns[1].HeaderText = "Название продукта";
                dataGridViewRecipesContent.Columns[1].Width = 257;
                dataGridViewRecipesContent.Columns[2].HeaderText = "Количество продукта";
                dataGridViewRecipesContent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRecipesContent.Columns[3].HeaderText = "Единица измерения";
                dataGridViewRecipesContent.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRecipesContent.Columns[3].Width = 140;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void addRecipes_menu_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipe = new AddRecipeForm(con);
            addRecipe.ShowDialog();
            Update();
        }

        private void addFromRecipes_menu_Click(object sender, EventArgs e)
        {
            int id_recipe = (int)dataGridViewRecipes.CurrentRow.Cells["id_recipe"].Value;
            AddRecipeContentForm addRecipeContent = new AddRecipeContentForm(con, id_recipe);
            addRecipeContent.ShowDialog();
            UpdateContent();
        }

        private void deleteRecipes_menu_Click(object sender, EventArgs e)
        {
            int id_recipe = (int)dataGridViewRecipes.CurrentRow.Cells["id_recipe"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данный рецепт?", "Удаление рецепта", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from recipes where id_recipe=:id", con);
                    command.Parameters.AddWithValue("id", id_recipe);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
            Update();
        }

        private void deleteFromRecipes_menu_Click(object sender, EventArgs e)
        {
            int id_rcontent = (int)dataGridViewRecipesContent.CurrentRow.Cells["id_rcontent"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данный продукт из рецепта?", "Удаление продукта из рецепта", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from recipes_content where id_rcontent=:id", con);
                    command.Parameters.AddWithValue("id", id_rcontent);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
        }

        private void exit_menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRecipes.SelectedRows.Count > 0)
            {
                UpdateContent();
            }
        }

        private void changeRecipeContent_menu_Click(object sender, EventArgs e)
        {
            int recipe_id=(int)dataGridViewRecipes.CurrentRow.Cells["id_recipe"].Value;
            int id_rcontent = (int)dataGridViewRecipesContent.CurrentRow.Cells["id_rcontent"].Value;
            string name_product=(string)dataGridViewRecipesContent.CurrentRow.Cells["name_product"].Value;
            double quantity=(double)dataGridViewRecipesContent.CurrentRow.Cells["product_quantity"].Value;
            AddRecipeContentForm addRecipeContent = new AddRecipeContentForm(con, -1, id_rcontent,name_product,quantity);
            addRecipeContent.ShowDialog();
            UpdateContent();
        }
    }
}
