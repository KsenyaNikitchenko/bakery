namespace cooking
{
    partial class AddBaking
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
            nameBaking_label = new Label();
            nameBaking_txtB = new TextBox();
            weigth_label = new Label();
            weigth_txtB = new TextBox();
            addBaking_btn = new Button();
            cancelAddBaking_btn = new Button();
            SuspendLayout();
            // 
            // nameBaking_label
            // 
            nameBaking_label.AutoSize = true;
            nameBaking_label.Location = new Point(10, 32);
            nameBaking_label.Name = "nameBaking_label";
            nameBaking_label.Size = new Size(229, 32);
            nameBaking_label.TabIndex = 0;
            nameBaking_label.Text = "Название выпечки:";
            // 
            // nameBaking_txtB
            // 
            nameBaking_txtB.Location = new Point(245, 32);
            nameBaking_txtB.Name = "nameBaking_txtB";
            nameBaking_txtB.Size = new Size(356, 39);
            nameBaking_txtB.TabIndex = 1;
            // 
            // weigth_label
            // 
            weigth_label.AutoSize = true;
            weigth_label.Location = new Point(34, 100);
            weigth_label.Name = "weigth_label";
            weigth_label.Size = new Size(188, 32);
            weigth_label.TabIndex = 2;
            weigth_label.Text = "Масса нетто, кг:";
            // 
            // weigth_txtB
            // 
            weigth_txtB.Location = new Point(316, 97);
            weigth_txtB.Name = "weigth_txtB";
            weigth_txtB.Size = new Size(202, 39);
            weigth_txtB.TabIndex = 3;
            // 
            // addBaking_btn
            // 
            addBaking_btn.Location = new Point(45, 202);
            addBaking_btn.Name = "addBaking_btn";
            addBaking_btn.Size = new Size(168, 46);
            addBaking_btn.TabIndex = 4;
            addBaking_btn.Text = "Подтвердить";
            addBaking_btn.UseVisualStyleBackColor = true;
            addBaking_btn.Click += addBaking_btn_Click;
            // 
            // cancelAddBaking_btn
            // 
            cancelAddBaking_btn.Location = new Point(381, 202);
            cancelAddBaking_btn.Name = "cancelAddBaking_btn";
            cancelAddBaking_btn.Size = new Size(137, 46);
            cancelAddBaking_btn.TabIndex = 5;
            cancelAddBaking_btn.Text = "Отменить";
            cancelAddBaking_btn.UseVisualStyleBackColor = true;
            cancelAddBaking_btn.Click += cancelAddBaking_btn_Click;
            // 
            // AddBaking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(606, 275);
            Controls.Add(cancelAddBaking_btn);
            Controls.Add(addBaking_btn);
            Controls.Add(weigth_txtB);
            Controls.Add(weigth_label);
            Controls.Add(nameBaking_txtB);
            Controls.Add(nameBaking_label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddBaking";
            Text = "Добавление/изменение выпечки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameBaking_label;
        private TextBox nameBaking_txtB;
        private Label weigth_label;
        private TextBox weigth_txtB;
        private Button addBaking_btn;
        private Button cancelAddBaking_btn;
    }
}