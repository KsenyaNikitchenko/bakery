namespace cooking
{
    partial class AddIncomingInvoiceForm
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
            addIInvoice_btn = new Button();
            cancelAddIInvoice_btn = new Button();
            date_label = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // addIInvoice_btn
            // 
            addIInvoice_btn.Location = new Point(53, 116);
            addIInvoice_btn.Name = "addIInvoice_btn";
            addIInvoice_btn.Size = new Size(178, 50);
            addIInvoice_btn.TabIndex = 0;
            addIInvoice_btn.Text = "Подтвердить";
            addIInvoice_btn.UseVisualStyleBackColor = true;
            addIInvoice_btn.Click += addIInvoice_btn_Click;
            // 
            // cancelAddIInvoice_btn
            // 
            cancelAddIInvoice_btn.Location = new Point(320, 116);
            cancelAddIInvoice_btn.Name = "cancelAddIInvoice_btn";
            cancelAddIInvoice_btn.Size = new Size(133, 55);
            cancelAddIInvoice_btn.TabIndex = 1;
            cancelAddIInvoice_btn.Text = "Отменить";
            cancelAddIInvoice_btn.UseVisualStyleBackColor = true;
            cancelAddIInvoice_btn.Click += cancelAddIInvoice_btn_Click;
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Location = new Point(92, 52);
            date_label.Name = "date_label";
            date_label.Size = new Size(70, 32);
            date_label.TabIndex = 2;
            date_label.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(191, 45);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(262, 39);
            dateTimePicker.TabIndex = 3;
            // 
            // AddIncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(515, 198);
            Controls.Add(dateTimePicker);
            Controls.Add(date_label);
            Controls.Add(cancelAddIInvoice_btn);
            Controls.Add(addIInvoice_btn);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddIncomingInvoiceForm";
            Text = "Добавление приходной накладной";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addIInvoice_btn;
        private Button cancelAddIInvoice_btn;
        private Label date_label;
        private DateTimePicker dateTimePicker;
    }
}