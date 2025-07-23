namespace cooking
{
    partial class ProductsForm
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
            addProduct_menu = new ToolStripMenuItem();
            changeProduct_menu = new ToolStripMenuItem();
            deleteProduct_menu = new ToolStripMenuItem();
            exit_menu = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addProduct_menu, changeProduct_menu, deleteProduct_menu, exit_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(691, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addProduct_menu
            // 
            addProduct_menu.Name = "addProduct_menu";
            addProduct_menu.Size = new Size(106, 29);
            addProduct_menu.Text = "Добавить";
            addProduct_menu.Click += addProduct_menu_Click;
            // 
            // changeProduct_menu
            // 
            changeProduct_menu.Name = "changeProduct_menu";
            changeProduct_menu.Size = new Size(107, 29);
            changeProduct_menu.Text = "Изменить";
            changeProduct_menu.Click += changeProduct_menu_Click;
            // 
            // deleteProduct_menu
            // 
            deleteProduct_menu.Name = "deleteProduct_menu";
            deleteProduct_menu.Size = new Size(92, 29);
            deleteProduct_menu.Text = "Удалить";
            deleteProduct_menu.Click += deleteProduct_menu_Click;
            // 
            // exit_menu
            // 
            exit_menu.Name = "exit_menu";
            exit_menu.Size = new Size(80, 29);
            exit_menu.Text = "Выход";
            exit_menu.Click += exit_menu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 65);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 541);
            dataGridView1.TabIndex = 1;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(691, 619);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "ProductsForm";
            Text = "Продукты";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addProduct_menu;
        private ToolStripMenuItem changeProduct_menu;
        private ToolStripMenuItem deleteProduct_menu;
        private ToolStripMenuItem exit_menu;
        private DataGridView dataGridView1;
    }
}