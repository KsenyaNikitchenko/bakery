using Npgsql;
using System.Data;

namespace cooking
{
    public partial class AddIncomingInvoiceForm : Form
    {
        public NpgsqlConnection con;
        public AddIncomingInvoiceForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void addIInvoice_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into incoming_invoice (date, total_sum) values (@date, 0)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.Add("@date", NpgsqlTypes.NpgsqlDbType.Date).Value = dateTimePicker.Value.Date;
                command.ExecuteNonQuery();
                Close();
            }
            catch { }
        }

        private void cancelAddIInvoice_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
