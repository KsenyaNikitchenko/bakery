using Microsoft.Office.Interop.Excel;
using Npgsql;
using Npgsql.Internal;
using System.Data;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace cooking
{
    public partial class IncomingInvoiceForm : Form
    {
        public NpgsqlConnection con;
        System.Data.DataTable IInvoiceTable = new System.Data.DataTable();
        DataSet IInvoiceSet = new DataSet();
        System.Data.DataTable IInvoiceContentTable = new System.Data.DataTable();
        DataSet IInvoiceContentSet = new DataSet();
        public IncomingInvoiceForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select * from incoming_invoice order by id_iinvoice";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            IInvoiceSet.Reset();
            da.Fill(IInvoiceSet);
            IInvoiceTable = IInvoiceSet.Tables[0];
            dataGridViewIInvoice.DataSource = IInvoiceTable;
            dataGridViewIInvoice.Columns[0].HeaderText = "Номер";
            dataGridViewIInvoice.Columns[1].HeaderText = "Дата";
            dataGridViewIInvoice.Columns[2].HeaderText = "Общая сумма";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void UpdateContent()
        {
            if (dataGridViewIInvoice.SelectedRows.Count > 0) 
            {
                int id_iinvoice = Convert.ToInt32(dataGridViewIInvoice.SelectedRows[0].Cells["id_iinvoice"].Value);
                string sql = "select id_iicontent, name_product, unit, price, quantity from incoming_invoice_content " +
                    "join products on(incoming_invoice_content.product_id = products.id_product) "
                + "where iinvoice_id=:id order by incoming_invoice_content.id_iicontent";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.AddWithValue(":id", id_iinvoice);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                IInvoiceContentSet.Reset();
                da.Fill(IInvoiceContentSet);
                IInvoiceContentTable = IInvoiceContentSet.Tables[0];
                dataGridViewIInvoiceContent.DataSource = IInvoiceContentTable;
                dataGridViewIInvoiceContent.Columns[0].HeaderText = "Номер";
                dataGridViewIInvoiceContent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewIInvoiceContent.Columns[0].Width = 95;
                dataGridViewIInvoiceContent.Columns[1].HeaderText = "Название продукта";
                dataGridViewIInvoiceContent.Columns[1].Width = 270;
                dataGridViewIInvoiceContent.Columns[2].HeaderText = "Единица измерения";
                dataGridViewIInvoiceContent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewIInvoiceContent.Columns[3].HeaderText = "Цена";
                dataGridViewIInvoiceContent.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewIInvoiceContent.Columns[3].Width = 85;
                dataGridViewIInvoiceContent.Columns[4].HeaderText = "Количество";
                dataGridViewIInvoiceContent.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void addIInvoice_menu_Click(object sender, EventArgs e)
        {
            AddIncomingInvoiceForm addIInvoice = new AddIncomingInvoiceForm(con);
            addIInvoice.ShowDialog();
            Update();
        }
        private void addIInvoiceContent_menu_Click(object sender, EventArgs e)
        {
            int iinvoice_id = (int)dataGridViewIInvoice.CurrentRow.Cells["id_iinvoice"].Value;
            AddIInvoiceContentForm addIInvoiceContentForm = new AddIInvoiceContentForm(con, iinvoice_id);
            addIInvoiceContentForm.ShowDialog();
            UpdateContent();
            Update();
        }
        private void deleteIInvoice_menu_Click(object sender, EventArgs e)
        {
            int id_iinvoice = (int)dataGridViewIInvoice.CurrentRow.Cells["id_iinvoice"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную накладную?", "Удаление приходной накладной", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from incoming_invoice where id_iinvoice=:id", con);
                    command.Parameters.AddWithValue("id", id_iinvoice);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
            Update();
        }
        private void deleteFromIInvoiceContent_menu_Click(object sender, EventArgs e)
        {
            int id_iicontent = (int)dataGridViewIInvoiceContent.CurrentRow.Cells["id_iicontent"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данный продукт из накладной?", "Удаление продукта из приходной накладной",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from incoming_invoice_content where id_iicontent=:id", con);
                    command.Parameters.AddWithValue("id", id_iicontent);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
            Update();
        }
        private void exit_menu_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridViewIInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIInvoice.SelectedRows.Count > 0)
            {
                UpdateContent();
            }
        }
        private void SaveToMSExcel(string filepath)
        {
            Excel.Application excelInvoice = new Excel.Application();
            Workbook workbook = excelInvoice.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            Excel.Range title = worksheet.get_Range("A2", "D2");
            title.Cells.Font.Name = "Aptos Narrow";
            title.Cells.Font.Size = 14;
            title.Cells.Font.Bold = true;
            title.Merge(Type.Missing);
            title.HorizontalAlignment = Constants.xlCenter;
            title.VerticalAlignment = Constants.xlCenter;

            int id_iinvoice = (int)dataGridViewIInvoice.CurrentRow.Cells["id_iinvoice"].Value;
            DateTime date = (DateTime)dataGridViewIInvoice.CurrentRow.Cells["date"].Value;

            double total_sum = (double)dataGridViewIInvoice.CurrentRow.Cells["total_sum"].Value;
            title.Value = "ПРИХОДНАЯ НАКЛАДНАЯ № " + id_iinvoice.ToString() + " от " + date.ToShortDateString();

            Excel.Range titleTable = worksheet.get_Range("A4", "E4");
            titleTable.Cells.Font.Name = "Aptos Narrow";
            titleTable.Cells.Font.Size = 12;

            worksheet.Cells[4, 1] = "№";
            worksheet.Cells[4, 2] = "Наименование товара";
            worksheet.Cells[4, 3] = "Единица измерения";
            worksheet.Cells[4, 4] = "Цена за единицу товара";
            worksheet.Cells[4, 5] = "Количество";

            worksheet.Columns.EntireColumn.AutoFit();

            int rows_content = dataGridViewIInvoiceContent.Rows.Count;
            int columns_content = dataGridViewIInvoiceContent.Columns.Count;
            for (int i = 0; i < rows_content - 1; i++)
            {
                worksheet.Cells[i + 5, 1] = i + 1;
                for (int j = 1; j < columns_content; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = dataGridViewIInvoiceContent.Rows[i].Cells[j].Value.ToString();
                }
            }

            string end_table = "E" + (3 + rows_content).ToString();
            Excel.Range table = worksheet.get_Range("A4", end_table);
            table.HorizontalAlignment = Constants.xlCenter;
            table.Borders.Value = XlLineStyle.xlContinuous;

            Excel.Range titleSum = (Excel.Range)worksheet.Cells[rows_content + 5, 4];
            titleSum.Cells.Font.Name = "Aptos Narrow";
            titleSum.Cells.Font.Size = 14;
            titleSum.Font.Bold = true;
            titleSum.Font.Italic = true;
            titleSum.HorizontalAlignment = Constants.xlRight;
            titleSum.Value = "Общая сумма:";
            worksheet.Cells[rows_content + 5, 5] = total_sum.ToString();
            worksheet.Cells[rows_content + 5, 5].HorizontalAlignment = Constants.xlCenter;

            workbook.SaveAs(filepath);
            workbook.Close();
        }
        private void exportMSEXcel_menu_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Сохранить как";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                SaveToMSExcel(filename);
            }
        }
    }
}
