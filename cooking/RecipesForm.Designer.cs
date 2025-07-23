namespace cooking
{
    partial class RecipesForm
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
            addRecipes_menu = new ToolStripMenuItem();
            addFromRecipes_menu = new ToolStripMenuItem();
            changeRecipeContent_menu = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            deleteRecipes_menu = new ToolStripMenuItem();
            deleteFromRecipes_menu = new ToolStripMenuItem();
            exit_menu = new ToolStripMenuItem();
            dataGridViewRecipes = new DataGridView();
            dataGridViewRecipesContent = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipesContent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, changeRecipeContent_menu, удалитьToolStripMenuItem, exit_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1364, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRecipes_menu, addFromRecipes_menu });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(106, 29);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // addRecipes_menu
            // 
            addRecipes_menu.Name = "addRecipes_menu";
            addRecipes_menu.Size = new Size(269, 34);
            addRecipes_menu.Text = "Добавить рецепт";
            addRecipes_menu.Click += addRecipes_menu_Click;
            // 
            // addFromRecipes_menu
            // 
            addFromRecipes_menu.Name = "addFromRecipes_menu";
            addFromRecipes_menu.Size = new Size(269, 34);
            addFromRecipes_menu.Text = "Добавить в рецепт";
            addFromRecipes_menu.Click += addFromRecipes_menu_Click;
            // 
            // changeRecipeContent_menu
            // 
            changeRecipeContent_menu.Name = "changeRecipeContent_menu";
            changeRecipeContent_menu.Size = new Size(283, 29);
            changeRecipeContent_menu.Text = "Изменить содержание рецепта";
            changeRecipeContent_menu.Click += changeRecipeContent_menu_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteRecipes_menu, deleteFromRecipes_menu });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(92, 29);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // deleteRecipes_menu
            // 
            deleteRecipes_menu.Name = "deleteRecipes_menu";
            deleteRecipes_menu.Size = new Size(272, 34);
            deleteRecipes_menu.Text = "Удалить рецепт";
            deleteRecipes_menu.Click += deleteRecipes_menu_Click;
            // 
            // deleteFromRecipes_menu
            // 
            deleteFromRecipes_menu.Name = "deleteFromRecipes_menu";
            deleteFromRecipes_menu.Size = new Size(272, 34);
            deleteFromRecipes_menu.Text = "Удалить из рецепта";
            deleteFromRecipes_menu.Click += deleteFromRecipes_menu_Click;
            // 
            // exit_menu
            // 
            exit_menu.Name = "exit_menu";
            exit_menu.Size = new Size(80, 29);
            exit_menu.Text = "Выход";
            exit_menu.Click += exit_menu_Click;
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipes.Location = new Point(15, 50);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.RowHeadersWidth = 62;
            dataGridViewRecipes.Size = new Size(516, 428);
            dataGridViewRecipes.TabIndex = 1;
            dataGridViewRecipes.SelectionChanged += dataGridViewRecipes_SelectionChanged;
            // 
            // dataGridViewRecipesContent
            // 
            dataGridViewRecipesContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipesContent.Location = new Point(560, 50);
            dataGridViewRecipesContent.Name = "dataGridViewRecipesContent";
            dataGridViewRecipesContent.RowHeadersWidth = 62;
            dataGridViewRecipesContent.Size = new Size(762, 428);
            dataGridViewRecipesContent.TabIndex = 2;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1364, 503);
            Controls.Add(dataGridViewRecipesContent);
            Controls.Add(dataGridViewRecipes);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "RecipesForm";
            Text = "Рецепты";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipesContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem addRecipes_menu;
        private ToolStripMenuItem addFromRecipes_menu;
        private ToolStripMenuItem changeRecipeContent_menu;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem deleteRecipes_menu;
        private ToolStripMenuItem deleteFromRecipes_menu;
        private ToolStripMenuItem exit_menu;
        private DataGridView dataGridViewRecipes;
        private DataGridView dataGridViewRecipesContent;
    }
}