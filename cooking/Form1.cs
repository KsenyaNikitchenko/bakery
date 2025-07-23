using Npgsql;
namespace cooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyLoad();
        }
        public NpgsqlConnection con;
        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost; Port=5432; UserID=postgres; Password=postpass; Database=Cooking");
            con.Open();
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            ProductsForm formProduct = new ProductsForm(con);
            formProduct.ShowDialog();
        }

        private void baking_btn_Click(object sender, EventArgs e)
        {
            BakingForm bakingForm = new BakingForm(con);
            bakingForm.ShowDialog();
        }

        private void binvoice_btn_Click(object sender, EventArgs e)
        {
            BakingInvoiceForm bakingInvoice = new BakingInvoiceForm(con);
            bakingInvoice.ShowDialog();
        }

        private void recipes_btn_Click(object sender, EventArgs e)
        {
            RecipesForm recipesForm = new RecipesForm(con);
            recipesForm.ShowDialog();
        }

        private void iinvoice_btn_Click(object sender, EventArgs e)
        {
            IncomingInvoiceForm IInvoiceForm = new IncomingInvoiceForm(con);
            IInvoiceForm.ShowDialog();
        }

        private void avgCostBaiking_btn_Click(object sender, EventArgs e)
        {
            AverageCostBakingForm averageCost = new AverageCostBakingForm(con);
            averageCost.ShowDialog();
        }

        private void remainsProducts_btn_Click(object sender, EventArgs e)
        {
            RemainsProductsForm remainsProducts=new RemainsProductsForm(con);
            remainsProducts.ShowDialog();
        }
    }
}
