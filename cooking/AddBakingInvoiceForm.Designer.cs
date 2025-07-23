namespace cooking
{
    partial class AddBakingInvoiceForm
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
            date_label = new Label();
            nameBaking_label = new Label();
            quantity_label = new Label();
            date_BInvoice = new DateTimePicker();
            nameBaking_cmB = new ComboBox();
            quantity_txtB = new TextBox();
            addBInvoice_btn = new Button();
            cancelBInvoice_btn = new Button();
            SuspendLayout();
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Location = new Point(13, 26);
            date_label.Name = "date_label";
            date_label.Size = new Size(228, 32);
            date_label.TabIndex = 0;
            date_label.Text = "Дата изготовления:";
            // 
            // nameBaking_label
            // 
            nameBaking_label.AutoSize = true;
            nameBaking_label.Location = new Point(10, 81);
            nameBaking_label.Name = "nameBaking_label";
            nameBaking_label.Size = new Size(229, 32);
            nameBaking_label.TabIndex = 1;
            nameBaking_label.Text = "Название выпечки:";
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Location = new Point(47, 132);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(149, 32);
            quantity_label.TabIndex = 2;
            quantity_label.Text = "Количество:";
            // 
            // date_BInvoice
            // 
            date_BInvoice.Location = new Point(318, 26);
            date_BInvoice.Name = "date_BInvoice";
            date_BInvoice.Size = new Size(261, 39);
            date_BInvoice.TabIndex = 3;
            // 
            // nameBaking_cmB
            // 
            nameBaking_cmB.FormattingEnabled = true;
            nameBaking_cmB.Location = new Point(263, 78);
            nameBaking_cmB.Name = "nameBaking_cmB";
            nameBaking_cmB.Size = new Size(352, 40);
            nameBaking_cmB.TabIndex = 4;
            // 
            // quantity_txtB
            // 
            quantity_txtB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            quantity_txtB.Location = new Point(318, 130);
            quantity_txtB.Name = "quantity_txtB";
            quantity_txtB.Size = new Size(261, 39);
            quantity_txtB.TabIndex = 5;
            // 
            // addBInvoice_btn
            // 
            addBInvoice_btn.Location = new Point(63, 210);
            addBInvoice_btn.Name = "addBInvoice_btn";
            addBInvoice_btn.Size = new Size(174, 46);
            addBInvoice_btn.TabIndex = 6;
            addBInvoice_btn.Text = "Подтвердить";
            addBInvoice_btn.UseVisualStyleBackColor = true;
            addBInvoice_btn.Click += addBInvoice_btn_Click;
            // 
            // cancelBInvoice_btn
            // 
            cancelBInvoice_btn.Location = new Point(283, 210);
            cancelBInvoice_btn.Name = "cancelBInvoice_btn";
            cancelBInvoice_btn.Size = new Size(152, 46);
            cancelBInvoice_btn.TabIndex = 7;
            cancelBInvoice_btn.Text = "Отменить";
            cancelBInvoice_btn.UseVisualStyleBackColor = true;
            cancelBInvoice_btn.Click += cancelBInvoice_btn_Click;
            // 
            // AddBakingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(626, 282);
            Controls.Add(cancelBInvoice_btn);
            Controls.Add(addBInvoice_btn);
            Controls.Add(quantity_txtB);
            Controls.Add(nameBaking_cmB);
            Controls.Add(date_BInvoice);
            Controls.Add(quantity_label);
            Controls.Add(nameBaking_label);
            Controls.Add(date_label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBakingInvoiceForm";
            Text = "Добавление/изменение накладных по выпечке";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label date_label;
        private Label nameBaking_label;
        private Label quantity_label;
        private DateTimePicker date_BInvoice;
        private ComboBox nameBaking_cmB;
        private TextBox quantity_txtB;
        private Button addBInvoice_btn;
        private Button cancelBInvoice_btn;
    }
}