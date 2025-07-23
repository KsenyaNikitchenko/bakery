namespace cooking
{
    partial class IncomingInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            addIInvoice_menu = new ToolStripMenuItem();
            addIInvoiceContent_menu = new ToolStripMenuItem();
            exportMSEXcel_menu = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            deleteIInvoice_menu = new ToolStripMenuItem();
            deleteFromIInvoiceContent_menu = new ToolStripMenuItem();
            exit_menu = new ToolStripMenuItem();
            dataGridViewIInvoice = new DataGridView();
            dataGridViewIInvoiceContent = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIInvoiceContent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, exportMSEXcel_menu, удалитьToolStripMenuItem, exit_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1427, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addIInvoice_menu, addIInvoiceContent_menu });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(106, 29);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // addIInvoice_menu
            // 
            addIInvoice_menu.Name = "addIInvoice_menu";
            addIInvoice_menu.Size = new Size(302, 34);
            addIInvoice_menu.Text = "Добавить накладную";
            addIInvoice_menu.Click += addIInvoice_menu_Click;
            // 
            // addIInvoiceContent_menu
            // 
            addIInvoiceContent_menu.Name = "addIInvoiceContent_menu";
            addIInvoiceContent_menu.Size = new Size(302, 34);
            addIInvoiceContent_menu.Text = "Добавить в накладную";
            addIInvoiceContent_menu.Click += addIInvoiceContent_menu_Click;
            // 
            // exportMSEXcel_menu
            // 
            exportMSEXcel_menu.Name = "exportMSEXcel_menu";
            exportMSEXcel_menu.Size = new Size(246, 29);
            exportMSEXcel_menu.Text = "Экспортировать в MSExcel";
            exportMSEXcel_menu.Click += exportMSEXcel_menu_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteIInvoice_menu, deleteFromIInvoiceContent_menu });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(92, 29);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // deleteIInvoice_menu
            // 
            deleteIInvoice_menu.Name = "deleteIInvoice_menu";
            deleteIInvoice_menu.Size = new Size(293, 34);
            deleteIInvoice_menu.Text = "Удалить накладную";
            deleteIInvoice_menu.Click += deleteIInvoice_menu_Click;
            // 
            // deleteFromIInvoiceContent_menu
            // 
            deleteFromIInvoiceContent_menu.Name = "deleteFromIInvoiceContent_menu";
            deleteFromIInvoiceContent_menu.Size = new Size(293, 34);
            deleteFromIInvoiceContent_menu.Text = "Удалить из накладной";
            deleteFromIInvoiceContent_menu.Click += deleteFromIInvoiceContent_menu_Click;
            // 
            // exit_menu
            // 
            exit_menu.Name = "exit_menu";
            exit_menu.Size = new Size(80, 29);
            exit_menu.Text = "Выход";
            exit_menu.Click += exit_menu_Click;
            // 
            // dataGridViewIInvoice
            // 
            dataGridViewIInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIInvoice.Location = new Point(12, 49);
            dataGridViewIInvoice.Name = "dataGridViewIInvoice";
            dataGridViewIInvoice.RowHeadersWidth = 62;
            dataGridViewIInvoice.Size = new Size(515, 515);
            dataGridViewIInvoice.TabIndex = 1;
            dataGridViewIInvoice.SelectionChanged += dataGridViewIInvoice_SelectionChanged;
            // 
            // dataGridViewIInvoiceContent
            // 
            dataGridViewIInvoiceContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIInvoiceContent.Location = new Point(566, 49);
            dataGridViewIInvoiceContent.Name = "dataGridViewIInvoiceContent";
            dataGridViewIInvoiceContent.RowHeadersWidth = 62;
            dataGridViewIInvoiceContent.Size = new Size(815, 515);
            dataGridViewIInvoiceContent.TabIndex = 2;
            // 
            // IncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1427, 576);
            Controls.Add(dataGridViewIInvoiceContent);
            Controls.Add(dataGridViewIInvoice);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "IncomingInvoiceForm";
            Text = "Приходные накладные";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIInvoiceContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem addIInvoice_menu;
        private ToolStripMenuItem addIInvoiceContent_menu;
        private ToolStripMenuItem exportMSEXcel_menu;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem deleteIInvoice_menu;
        private ToolStripMenuItem deleteFromIInvoiceContent_menu;
        private ToolStripMenuItem exit_menu;
        private DataGridView dataGridViewIInvoice;
        private DataGridView dataGridViewIInvoiceContent;
    }
}