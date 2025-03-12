namespace Trees
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyTreeView = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribution_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTreeView
            // 
            this.MyTreeView.Location = new System.Drawing.Point(12, 37);
            this.MyTreeView.Name = "MyTreeView";
            this.MyTreeView.Size = new System.Drawing.Size(365, 287);
            this.MyTreeView.TabIndex = 0;
            this.MyTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MyTreeView_NodeMouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Weight,
            this.Distribution_area,
            this.TypeOfAnimal});
            this.dataGridView1.Location = new System.Drawing.Point(383, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Вес";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.Width = 125;
            // 
            // Distribution_area
            // 
            this.Distribution_area.HeaderText = "Зона обитания";
            this.Distribution_area.MinimumWidth = 6;
            this.Distribution_area.Name = "Distribution_area";
            this.Distribution_area.Width = 200;
            // 
            // TypeOfAnimal
            // 
            this.TypeOfAnimal.HeaderText = "Вид";
            this.TypeOfAnimal.MinimumWidth = 6;
            this.TypeOfAnimal.Name = "TypeOfAnimal";
            this.TypeOfAnimal.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MyTreeView);
            //this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView MyTreeView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distribution_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfAnimal;
    }
}

