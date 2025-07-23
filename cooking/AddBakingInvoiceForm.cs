using Npgsql;
using System.Data;

namespace cooking
{
    public partial class AddBakingInvoiceForm : Form
    {
        int id;
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AddBakingInvoiceForm(NpgsqlConnection con, int id)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            Update();
        }
        public AddBakingInvoiceForm(NpgsqlConnection con, int id, DateTime date,string name_baking, int baking_quantity)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            Update();
            date_BInvoice.Value = date;
            nameBaking_cmB.SelectedIndex=nameBaking_cmB.FindString(name_baking);
            quantity_txtB.Text = baking_quantity.ToString();
        }
        private void Update()
        {
            string sql = "select id_baking, name_baking from baking";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            nameBaking_cmB.DataSource = dt;
            nameBaking_cmB.DisplayMember = "name_baking";
            nameBaking_cmB.ValueMember = "id_baking";
        }

        private void addBInvoice_btn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    string sql = "insert into baking_invoice (date, baking_id, baking_quantity) values (@date, @baking_id, @quantity)";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.Add("@date", NpgsqlTypes.NpgsqlDbType.Date).Value = date_BInvoice.Value.Date;
                        command.Parameters.Add("@baking_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = nameBaking_cmB.SelectedValue;
                        command.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(quantity_txtB.Text);
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
                    string sql = "update baking_invoice set date=@date, baking_id=@baking_id, baking_quantity=@quantity where id_binvoice=@id";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.Add("@date", NpgsqlTypes.NpgsqlDbType.Date).Value = date_BInvoice.Value.Date;
                        command.Parameters.Add("@baking_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = nameBaking_cmB.SelectedValue;
                        command.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(quantity_txtB.Text);
                        command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = this.id;
                        command.ExecuteNonQuery();
                    }

                    Close();
                }
                catch { }
            }
        }

        private void cancelBInvoice_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
