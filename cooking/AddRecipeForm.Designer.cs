namespace cooking
{
    partial class AddRecipeForm
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
            nameBaking_cmB = new ComboBox();
            addRecipe_btn = new Button();
            cancelAddRecipe_btn = new Button();
            SuspendLayout();
            // 
            // nameBaking_label
            // 
            nameBaking_label.AutoSize = true;
            nameBaking_label.Location = new Point(38, 58);
            nameBaking_label.Name = "nameBaking_label";
            nameBaking_label.Size = new Size(229, 32);
            nameBaking_label.TabIndex = 0;
            nameBaking_label.Text = "Название выпечки:";
            // 
            // nameBaking_cmB
            // 
            nameBaking_cmB.FormattingEnabled = true;
            nameBaking_cmB.Location = new Point(273, 55);
            nameBaking_cmB.Name = "nameBaking_cmB";
            nameBaking_cmB.Size = new Size(338, 40);
            nameBaking_cmB.TabIndex = 1;
            // 
            // addRecipe_btn
            // 
            addRecipe_btn.Location = new Point(100, 164);
            addRecipe_btn.Name = "addRecipe_btn";
            addRecipe_btn.Size = new Size(167, 50);
            addRecipe_btn.TabIndex = 2;
            addRecipe_btn.Text = "Подтвердить";
            addRecipe_btn.UseVisualStyleBackColor = true;
            addRecipe_btn.Click += addRecipe_btn_Click;
            // 
            // cancelAddRecipe_btn
            // 
            cancelAddRecipe_btn.Location = new Point(376, 164);
            cancelAddRecipe_btn.Name = "cancelAddRecipe_btn";
            cancelAddRecipe_btn.Size = new Size(158, 50);
            cancelAddRecipe_btn.TabIndex = 3;
            cancelAddRecipe_btn.Text = "Отменить";
            cancelAddRecipe_btn.UseVisualStyleBackColor = true;
            cancelAddRecipe_btn.Click += cancelAddRecipe_btn_Click;
            // 
            // AddRecipeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(637, 254);
            Controls.Add(cancelAddRecipe_btn);
            Controls.Add(addRecipe_btn);
            Controls.Add(nameBaking_cmB);
            Controls.Add(nameBaking_label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AddRecipeForm";
            Text = "Добавление рецепта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameBaking_label;
        private ComboBox nameBaking_cmB;
        private Button addRecipe_btn;
        private Button cancelAddRecipe_btn;
    }
}