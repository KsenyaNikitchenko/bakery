namespace cooking
{
    partial class AddProduct
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
            nameProduct_txtB = new TextBox();
            unit_label = new Label();
            unit_txtB = new TextBox();
            addProduct_btn = new Button();
            cancelAddProduct_btn = new Button();
            SuspendLayout();
            // 
            // nameProduct_label
            // 
            nameProduct_label.AutoSize = true;
            nameProduct_label.Location = new Point(23, 46);
            nameProduct_label.Margin = new Padding(4, 0, 4, 0);
            nameProduct_label.Name = "nameProduct_label";
            nameProduct_label.Size = new Size(233, 32);
            nameProduct_label.TabIndex = 0;
            nameProduct_label.Text = "Название продукта:";
            // 
            // nameProduct_txtB
            // 
            nameProduct_txtB.Location = new Point(273, 44);
            nameProduct_txtB.Name = "nameProduct_txtB";
            nameProduct_txtB.Size = new Size(194, 39);
            nameProduct_txtB.TabIndex = 1;
            // 
            // unit_label
            // 
            unit_label.AutoSize = true;
            unit_label.Location = new Point(23, 110);
            unit_label.Name = "unit_label";
            unit_label.Size = new Size(241, 32);
            unit_label.TabIndex = 2;
            unit_label.Text = "Единица измерения:";
            // 
            // unit_txtB
            // 
            unit_txtB.Location = new Point(273, 108);
            unit_txtB.Name = "unit_txtB";
            unit_txtB.Size = new Size(194, 39);
            unit_txtB.TabIndex = 3;
            // 
            // addProduct_btn
            // 
            addProduct_btn.Location = new Point(70, 214);
            addProduct_btn.Name = "addProduct_btn";
            addProduct_btn.Size = new Size(172, 46);
            addProduct_btn.TabIndex = 4;
            addProduct_btn.Text = "Подтвердить";
            addProduct_btn.UseVisualStyleBackColor = true;
            addProduct_btn.Click += addProduct_btn_Click;
            // 
            // cancelAddProduct_btn
            // 
            cancelAddProduct_btn.Location = new Point(273, 214);
            cancelAddProduct_btn.Name = "cancelAddProduct_btn";
            cancelAddProduct_btn.Size = new Size(147, 46);
            cancelAddProduct_btn.TabIndex = 5;
            cancelAddProduct_btn.Text = "Отменить";
            cancelAddProduct_btn.UseVisualStyleBackColor = true;
            cancelAddProduct_btn.Click += cancelAddProduct_btn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(496, 278);
            Controls.Add(cancelAddProduct_btn);
            Controls.Add(addProduct_btn);
            Controls.Add(unit_txtB);
            Controls.Add(unit_label);
            Controls.Add(nameProduct_txtB);
            Controls.Add(nameProduct_label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddProduct";
            Text = "Добавление/изменение продукта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameProduct_label;
        private TextBox nameProduct_txtB;
        private Label unit_label;
        private TextBox unit_txtB;
        private Button addProduct_btn;
        private Button cancelAddProduct_btn;
    }
}