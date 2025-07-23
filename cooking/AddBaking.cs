using Npgsql;

namespace cooking
{
    public partial class AddBaking : Form
    {
        public NpgsqlConnection con;
        int id;
        public AddBaking(NpgsqlConnection con, int id)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            Update();
        }
        public AddBaking(NpgsqlConnection con, int id, string namebaking, double weigth)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            nameBaking_txtB.Text=namebaking;
            weigth_txtB.Text = weigth.ToString();
            Update();
        }

        private void addBaking_btn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    string sql = "insert into baking(name_baking,weigth) values (@name_baking, @weigth)";
                    using(NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.Add("@name_baking", NpgsqlTypes.NpgsqlDbType.Varchar).Value= nameBaking_txtB.Text;
                        command.Parameters.Add("@weigth", NpgsqlTypes.NpgsqlDbType.Double).Value=Convert.ToDouble(weigth_txtB.Text);
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
                    string sql = "update baking set name_baking=@name_baking, weigth=@weigth where id_baking=@id";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.Add("@name_baking", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nameBaking_txtB.Text;
                        command.Parameters.Add("@weigth", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(weigth_txtB.Text);
                        command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value=id;
                        command.ExecuteNonQuery();
                    }
                        
                    Close();
                }
                catch { }
            }
        }

        private void cancelAddBaking_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
