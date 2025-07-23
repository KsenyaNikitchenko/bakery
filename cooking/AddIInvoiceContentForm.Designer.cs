namespace cooking
{
    partial class AddIInvoiceContentForm
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
            price_label = new Label();
            quantity_label = new Label();
            price_txtB = new TextBox();
            quantity_txtB = new TextBox();
            addIInvoiceContent_btn = new Button();
            cancelAddIInvoiceContent_btn = new Button();
            SuspendLayout();
            // 
            // nameProduct_label
            // 
            nameProduct_label.AutoSize = true;
            nameProduct_label.Location = new Point(45, 46);
            nameProduct_label.Name = "nameProduct_label";
            nameProduct_label.Size = new Size(233, 32);
            nameProduct_label.TabIndex = 0;
            nameProduct_label.Text = "Название продукта:";
            // 
            // nameProduct_cmB
            // 
            nameProduct_cmB.FormattingEnabled = true;
            nameProduct_cmB.Location = new Point(303, 43);
            nameProduct_cmB.Name = "nameProduct_cmB";
            nameProduct_cmB.Size = new Size(262, 40);
            nameProduct_cmB.TabIndex = 1;
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Location = new Point(127, 113);
            price_label.Name = "price_label";
            price_label.Size = new Size(76, 32);
            price_label.TabIndex = 2;
            price_label.Text = "Цена:";
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Location = new Point(95, 168);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(149, 32);
            quantity_label.TabIndex = 3;
            quantity_label.Text = "Количество:";
            // 
            // price_txtB
            // 
            price_txtB.Location = new Point(303, 106);
            price_txtB.Name = "price_txtB";
            price_txtB.Size = new Size(262, 39);
            price_txtB.TabIndex = 4;
            // 
            // quantity_txtB
            // 
            quantity_txtB.Location = new Point(303, 168);
            quantity_txtB.Name = "quantity_txtB";
            quantity_txtB.Size = new Size(262, 39);
            quantity_txtB.TabIndex = 5;
            // 
            // addIInvoiceContent_btn
            // 
            addIInvoiceContent_btn.Location = new Point(110, 246);
            addIInvoiceContent_btn.Name = "addIInvoiceContent_btn";
            addIInvoiceContent_btn.Size = new Size(168, 50);
            addIInvoiceContent_btn.TabIndex = 6;
            addIInvoiceContent_btn.Text = "Подтвердить";
            addIInvoiceContent_btn.UseVisualStyleBackColor = true;
            addIInvoiceContent_btn.Click += addIInvoiceContent_btn_Click;
            // 
            // cancelAddIInvoiceContent_btn
            // 
            cancelAddIInvoiceContent_btn.Location = new Point(374, 246);
            cancelAddIInvoiceContent_btn.Name = "cancelAddIInvoiceContent_btn";
            cancelAddIInvoiceContent_btn.Size = new Size(147, 50);
            cancelAddIInvoiceContent_btn.TabIndex = 7;
            cancelAddIInvoiceContent_btn.Text = "Отменить";
            cancelAddIInvoiceContent_btn.UseVisualStyleBackColor = true;
            cancelAddIInvoiceContent_btn.Click += cancelAddIInvoiceContent_btn_Click;
            // 
            // AddIInvoiceContentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(644, 334);
            Controls.Add(cancelAddIInvoiceContent_btn);
            Controls.Add(addIInvoiceContent_btn);
            Controls.Add(quantity_txtB);
            Controls.Add(price_txtB);
            Controls.Add(quantity_label);
            Controls.Add(price_label);
            Controls.Add(nameProduct_cmB);
            Controls.Add(nameProduct_label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddIInvoiceContentForm";
            Text = "Добавление продукта в накладную";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameProduct_label;
        private ComboBox nameProduct_cmB;
        private Label price_label;
        private Label quantity_label;
        private TextBox price_txtB;
        private TextBox quantity_txtB;
        private Button addIInvoiceContent_btn;
        private Button cancelAddIInvoiceContent_btn;
    }
}