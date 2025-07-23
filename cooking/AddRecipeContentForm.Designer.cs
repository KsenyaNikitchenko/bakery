namespace cooking
{
    partial class AddRecipeContentForm
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
            nameProduct_label = new Label();
            nameProduct_cmB = new ComboBox();
            quantity_label = new Label();
            quantity_txtB = new TextBox();
            addRecipeContent_btn = new Button();
            cancelAddRecipeContent_btn = new Button();
            SuspendLayout();
            // 
            // nameProduct_label
            // 
            nameProduct_label.AutoSize = true;
            nameProduct_label.Location = new Point(37, 42);
            nameProduct_label.Name = "nameProduct_label";
            nameProduct_label.Size = new Size(233, 32);
            nameProduct_label.TabIndex = 0;
            nameProduct_label.Text = "Название продукта:";
            // 
            // nameProduct_cmB
            // 
            nameProduct_cmB.FormattingEnabled = true;
            nameProduct_cmB.Location = new Point(292, 39);
            nameProduct_cmB.Name = "nameProduct_cmB";
            nameProduct_cmB.Size = new Size(270, 40);
            nameProduct_cmB.TabIndex = 1;
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Location = new Point(46, 110);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(224, 32);
            quantity_label.TabIndex = 2;
            quantity_label.Text = "Количество, в кг/л:";
            // 
            // quantity_txtB
            // 
            quantity_txtB.Location = new Point(329, 103);
            quantity_txtB.Name = "quantity_txtB";
            quantity_txtB.Size = new Size(200, 39);
            quantity_txtB.TabIndex = 3;
            // 
            // addRecipeContent_btn
            // 
            addRecipeContent_btn.Location = new Point(82, 202);
            addRecipeContent_btn.Name = "addRecipeContent_btn";
            addRecipeContent_btn.Size = new Size(169, 50);
            addRecipeContent_btn.TabIndex = 4;
            addRecipeContent_btn.Text = "Подтвердить";
            addRecipeContent_btn.UseVisualStyleBackColor = true;
            addRecipeContent_btn.Click += addRecipeContent_btn_Click;
            // 
            // cancelAddRecipeContent_btn
            // 
            cancelAddRecipeContent_btn.Location = new Point(350, 202);
            cancelAddRecipeContent_btn.Name = "cancelAddRecipeContent_btn";
            cancelAddRecipeContent_btn.Size = new Size(142, 50);
            cancelAddRecipeContent_btn.TabIndex = 5;
            cancelAddRecipeContent_btn.Text = "Отменить";
            cancelAddRecipeContent_btn.UseVisualStyleBackColor = true;
            cancelAddRecipeContent_btn.Click += cancelAddRecipeContent_btn_Click;
            // 
            // AddRecipeContentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(616, 283);
            Controls.Add(cancelAddRecipeContent_btn);
            Controls.Add(addRecipeContent_btn);
            Controls.Add(quantity_txtB);
            Controls.Add(quantity_label);
            Controls.Add(nameProduct_cmB);
            Controls.Add(nameProduct_label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AddRecipeContentForm";
            Text = "Добавление продукта в рецепт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameProduct_label;
        private ComboBox nameProduct_cmB;
        private Label quantity_label;
        private TextBox quantity_txtB;
        private Button addRecipeContent_btn;
        private Button cancelAddRecipeContent_btn;
    }
}