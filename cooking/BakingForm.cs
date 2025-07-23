using Npgsql;
using System.Data;

namespace cooking
{
    public partial class BakingForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public BakingForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select * from baking order by id_baking";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[1].Width = 427;
            dataGridView1.Columns[2].HeaderText = "Масса нетто";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void addBaking_menu_Click(object sender, EventArgs e)
        {
            AddBaking addBaking = new AddBaking(con, -1);
            addBaking.ShowDialog();
            Update();
        }
        private void changeBaking_menu_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_baking"].Value;
            string namebaking = (string)dataGridView1.CurrentRow.Cells["name_baking"].Value;
            double weigth= Convert.ToDouble(dataGridView1.CurrentRow.Cells["weigth"].Value);
            AddBaking addBaking = new AddBaking(con, id, namebaking, weigth);
            addBaking.ShowDialog();
            Update();
        }
        private void deleteBaking_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выпечку?", "Удаление выпечки", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id_baking"].Value;
                try
                {
                NpgsqlCommand command = new NpgsqlCommand("delete from baking where id_baking=:id", con);
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
