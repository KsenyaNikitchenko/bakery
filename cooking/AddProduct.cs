using Npgsql;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cooking
{
    public partial class AddProduct : Form
    {
        public NpgsqlConnection con;
        int id;
        public AddProduct(NpgsqlConnection con, int id)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            Update();
        }
        public AddProduct(NpgsqlConnection con, int id, string nameproduct, string unit)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            nameProduct_txtB.Text = nameproduct;
            unit_txtB.Text = unit;
            Update();
        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into products(name_product,unit) values (:name_product, :unit)", con);
                    command.Parameters.AddWithValue("name_product", nameProduct_txtB.Text);
                    command.Parameters.AddWithValue("unit", unit_txtB.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("update products set name_product=:name_product, unit=:unit where id_product=:id", con);
                    command.Parameters.AddWithValue("name_product", nameProduct_txtB.Text);
                    command.Parameters.AddWithValue("unit", unit_txtB.Text);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
        }

        private void cancelAddProduct_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
