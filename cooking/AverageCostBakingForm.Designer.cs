namespace cooking
{
    partial class AverageCostBakingForm
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
            startDate_label = new Label();
            endDate_label = new Label();
            startDate_dateTP = new DateTimePicker();
            endDate_dateTP = new DateTimePicker();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            countAvgCost_menu = new ToolStripMenuItem();
            exit_menu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // startDate_label
            // 
            startDate_label.AutoSize = true;
            startDate_label.Location = new Point(24, 92);
            startDate_label.Name = "startDate_label";
            startDate_label.Size = new Size(154, 32);
            startDate_label.TabIndex = 0;
            startDate_label.Text = "Дата начала:";
            // 
            // endDate_label
            // 
            endDate_label.AutoSize = true;
            endDate_label.Location = new Point(24, 142);
            endDate_label.Name = "endDate_label";
            endDate_label.Size = new Size(143, 32);
            endDate_label.TabIndex = 1;
            endDate_label.Text = "Дата конца:";
            // 
            // startDate_dateTP
            // 
            startDate_dateTP.Location = new Point(196, 87);
            startDate_dateTP.Name = "startDate_dateTP";
            startDate_dateTP.Size = new Size(300, 39);
            startDate_dateTP.TabIndex = 2;
            // 
            // endDate_dateTP
            // 
            endDate_dateTP.Location = new Point(196, 137);
            endDate_dateTP.Name = "endDate_dateTP";
            endDate_dateTP.Size = new Size(300, 39);
            endDate_dateTP.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(602, 398);
            dataGridView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { countAvgCost_menu, exit_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(660, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // countAvgCost_menu
            // 
            countAvgCost_menu.Name = "countAvgCost_menu";
            countAvgCost_menu.Size = new Size(240, 29);
            countAvgCost_menu.Text = "Рассчитать себестоимость";
            countAvgCost_menu.Click += countAvgCost_menu_Click;
            // 
            // exit_menu
            // 
            exit_menu.Name = "exit_menu";
            exit_menu.Size = new Size(80, 29);
            exit_menu.Text = "Выход";
            exit_menu.Click += exit_menu_Click;
            // 
            // AverageCostBakingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(660, 658);
            Controls.Add(dataGridView1);
            Controls.Add(endDate_dateTP);
            Controls.Add(startDate_dateTP);
            Controls.Add(endDate_label);
            Controls.Add(startDate_label);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AverageCostBakingForm";
            Text = "Средняя себестоимость выпечки";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startDate_label;
        private Label endDate_label;
        private DateTimePicker startDate_dateTP;
        private DateTimePicker endDate_dateTP;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem countAvgCost_menu;
        private ToolStripMenuItem exit_menu;
    }
}