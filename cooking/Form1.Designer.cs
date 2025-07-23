namespace cooking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            product_btn = new Button();
            baking_btn = new Button();
            recipes_btn = new Button();
            iinvoice_btn = new Button();
            binvoice_btn = new Button();
            avgCostBaiking_btn = new Button();
            remainsProducts_btn = new Button();
            SuspendLayout();
            // 
            // product_btn
            // 
            product_btn.Location = new Point(75, 60);
            product_btn.Margin = new Padding(5);
            product_btn.Name = "product_btn";
            product_btn.Size = new Size(330, 60);
            product_btn.TabIndex = 0;
            product_btn.Text = "Продукты";
            product_btn.UseVisualStyleBackColor = true;
            product_btn.Click += product_btn_Click;
            // 
            // baking_btn
            // 
            baking_btn.Location = new Point(75, 140);
            baking_btn.Margin = new Padding(5);
            baking_btn.Name = "baking_btn";
            baking_btn.Size = new Size(330, 60);
            baking_btn.TabIndex = 1;
            baking_btn.Text = "Выпечка";
            baking_btn.UseVisualStyleBackColor = true;
            baking_btn.Click += baking_btn_Click;
            // 
            // recipes_btn
            // 
            recipes_btn.Location = new Point(75, 220);
            recipes_btn.Margin = new Padding(5);
            recipes_btn.Name = "recipes_btn";
            recipes_btn.Size = new Size(330, 60);
            recipes_btn.TabIndex = 2;
            recipes_btn.Text = "Рецепты";
            recipes_btn.UseVisualStyleBackColor = true;
            recipes_btn.Click += recipes_btn_Click;
            // 
            // iinvoice_btn
            // 
            iinvoice_btn.Location = new Point(75, 300);
            iinvoice_btn.Margin = new Padding(5);
            iinvoice_btn.Name = "iinvoice_btn";
            iinvoice_btn.Size = new Size(330, 60);
            iinvoice_btn.TabIndex = 3;
            iinvoice_btn.Text = "Приходные накладные";
            iinvoice_btn.UseVisualStyleBackColor = true;
            iinvoice_btn.Click += iinvoice_btn_Click;
            // 
            // binvoice_btn
            // 
            binvoice_btn.Location = new Point(75, 380);
            binvoice_btn.Margin = new Padding(5);
            binvoice_btn.Name = "binvoice_btn";
            binvoice_btn.Size = new Size(330, 60);
            binvoice_btn.TabIndex = 4;
            binvoice_btn.Text = "Накладные по выпечке";
            binvoice_btn.UseVisualStyleBackColor = true;
            binvoice_btn.Click += binvoice_btn_Click;
            // 
            // avgCostBaiking_btn
            // 
            avgCostBaiking_btn.Location = new Point(73, 462);
            avgCostBaiking_btn.Name = "avgCostBaiking_btn";
            avgCostBaiking_btn.Size = new Size(330, 60);
            avgCostBaiking_btn.TabIndex = 5;
            avgCostBaiking_btn.Text = "Средняя себестоимость";
            avgCostBaiking_btn.UseVisualStyleBackColor = true;
            avgCostBaiking_btn.Click += avgCostBaiking_btn_Click;
            // 
            // remainsProducts_btn
            // 
            remainsProducts_btn.Location = new Point(75, 540);
            remainsProducts_btn.Name = "remainsProducts_btn";
            remainsProducts_btn.Size = new Size(330, 60);
            remainsProducts_btn.TabIndex = 6;
            remainsProducts_btn.Text = "Остатки продуктов";
            remainsProducts_btn.UseVisualStyleBackColor = true;
            remainsProducts_btn.Click += remainsProducts_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(472, 683);
            Controls.Add(remainsProducts_btn);
            Controls.Add(avgCostBaiking_btn);
            Controls.Add(binvoice_btn);
            Controls.Add(iinvoice_btn);
            Controls.Add(recipes_btn);
            Controls.Add(baking_btn);
            Controls.Add(product_btn);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Кулинария";
            ResumeLayout(false);
        }

        #endregion

        private Button product_btn;
        private Button baking_btn;
        private Button recipes_btn;
        private Button iinvoice_btn;
        private Button binvoice_btn;
        private Button avgCostBaiking_btn;
        private Button remainsProducts_btn;
    }
}
