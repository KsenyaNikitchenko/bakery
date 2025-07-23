namespace cooking
{
    partial class BakingForm
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
            addBaking_menu = new ToolStripMenuItem();
            changeBaking_menu = new ToolStripMenuItem();
            deleteBaking_menu = new ToolStripMenuItem();
            exit_menu = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addBaking_menu, changeBaking_menu, deleteBaking_menu, exit_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(765, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addBaking_menu
            // 
            addBaking_menu.Name = "addBaking_menu";
            addBaking_menu.Size = new Size(106, 29);
            addBaking_menu.Text = "Добавить";
            addBaking_menu.Click += addBaking_menu_Click;
            // 
            // changeBaking_menu
            // 
            changeBaking_menu.Name = "changeBaking_menu";
            changeBaking_menu.Size = new Size(107, 29);
            changeBaking_menu.Text = "Изменить";
            changeBaking_menu.Click += changeBaking_menu_Click;
            // 
            // deleteBaking_menu
            // 
            deleteBaking_menu.Name = "deleteBaking_menu";
            deleteBaking_menu.Size = new Size(92, 29);
            deleteBaking_menu.Text = "Удалить";
            deleteBaking_menu.Click += deleteBaking_menu_Click;
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
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(741, 512);
            dataGridView1.TabIndex = 1;
            // 
            // BakingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(765, 577);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BakingForm";
            Text = "Выпечка";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addBaking_menu;
        private ToolStripMenuItem changeBaking_menu;
        private ToolStripMenuItem deleteBaking_menu;
        private ToolStripMenuItem exit_menu;
        private DataGridView dataGridView1;
    }
}