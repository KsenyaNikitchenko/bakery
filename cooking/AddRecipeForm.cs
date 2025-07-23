using Npgsql;
using System.Data;

namespace cooking
{
    public partial class AddRecipeForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AddRecipeForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select * from baking";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            nameBaking_cmB.DataSource = dt;
            nameBaking_cmB.DisplayMember = "name_baking";
            nameBaking_cmB.ValueMember = "id_baking";
        }
        private void addRecipe_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into recipes (baking_id) values (@baking_id)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.Add("@baking_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = nameBaking_cmB.SelectedValue;
                command.ExecuteNonQuery();
                Close();
            }
            catch { }
        }
        private void cancelAddRecipe_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
