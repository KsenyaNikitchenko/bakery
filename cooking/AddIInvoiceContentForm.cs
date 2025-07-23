using Npgsql;
using System.Data;

namespace cooking
{
    public partial class AddIInvoiceContentForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        int iinvoice_id;
        public AddIInvoiceContentForm( NpgsqlConnection con,int iinvoice_id)
        {
            InitializeComponent();
            this.con = con;
            this.iinvoice_id = iinvoice_id;
            Update();
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
        private void addIInvoiceContent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into incoming_invoice_content (iinvoice_id, product_id, price, quantity) " +
                    "values (@iinvoice_id, @product_id, @price, @quantity)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.Add("@iinvoice_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = iinvoice_id;
                    command.Parameters.Add("@product_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = nameProduct_cmB.SelectedValue;
                    command.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(price_txtB.Text);
                    command.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(quantity_txtB.Text);
                    command.ExecuteNonQuery();
                }
                Close();
            }
            catch { }
        }
        private void cancelAddIInvoiceContent_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
