namespace cooking
{
    partial class BakingInvoiceForm
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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            addBInvoice_menu = new ToolStripMenuItem();
            changeBInvoice_menu = new ToolStripMenuItem();
            deleteBInvoice_menu = new ToolStripMenuItem();
            exit_menu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(795, 435);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addBInvoice_menu, changeBInvoice_menu, deleteBInvoice_menu, exit_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addBInvoice_menu
            // 
            addBInvoice_menu.Name = "addBInvoice_menu";
            addBInvoice_menu.Size = new Size(106, 29);
            addBInvoice_menu.Text = "Добавить";
            addBInvoice_menu.Click += addBInvoice_menu_Click;
            // 
            // changeBInvoice_menu
            // 
            changeBInvoice_menu.Name = "changeBInvoice_menu";
            changeBInvoice_menu.Size = new Size(107, 29);
            changeBInvoice_menu.Text = "Изменить";
            changeBInvoice_menu.Click += changeBInvoice_menu_Click;
            // 
            // deleteBInvoice_menu
            // 
            deleteBInvoice_menu.Name = "deleteBInvoice_menu";
            deleteBInvoice_menu.Size = new Size(92, 29);
            deleteBInvoice_menu.Text = "Удалить";
            deleteBInvoice_menu.Click += deleteBInvoice_menu_Click;
            // 
            // exit_menu
            // 
            exit_menu.Name = "exit_menu";
            exit_menu.Size = new Size(80, 29);
            exit_menu.Text = "Выход";
            exit_menu.Click += exit_menu_Click;
            // 
            // BakingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(819, 494);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "BakingInvoiceForm";
            Text = "Накладные по выпечке";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addBInvoice_menu;
        private ToolStripMenuItem changeBInvoice_menu;
        private ToolStripMenuItem deleteBInvoice_menu;
        private ToolStripMenuItem exit_menu;
    }
}