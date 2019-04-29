namespace WindowsClient1
{
    partial class MenuPage
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.restaurantDetailsDataSet5 = new WindowsClient1.RestaurantDetailsDataSet5();
            this.tblRestaurantMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRestaurantMenuTableAdapter = new WindowsClient1.RestaurantDetailsDataSet5TableAdapters.tblRestaurantMenuTableAdapter();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDetailsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRestaurantMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.dishNameDataGridViewTextBoxColumn,
            this.dishCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRestaurantMenuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(598, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 129);
            this.button1.TabIndex = 2;
            this.button1.Text = "Order it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // restaurantDetailsDataSet5
            // 
            this.restaurantDetailsDataSet5.DataSetName = "RestaurantDetailsDataSet5";
            this.restaurantDetailsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRestaurantMenuBindingSource
            // 
            this.tblRestaurantMenuBindingSource.DataMember = "tblRestaurantMenu";
            this.tblRestaurantMenuBindingSource.DataSource = this.restaurantDetailsDataSet5;
            // 
            // tblRestaurantMenuTableAdapter
            // 
            this.tblRestaurantMenuTableAdapter.ClearBeforeFill = true;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishNameDataGridViewTextBoxColumn
            // 
            this.dishNameDataGridViewTextBoxColumn.DataPropertyName = "DishName";
            this.dishNameDataGridViewTextBoxColumn.HeaderText = "Item";
            this.dishNameDataGridViewTextBoxColumn.Name = "dishNameDataGridViewTextBoxColumn";
            // 
            // dishCostDataGridViewTextBoxColumn
            // 
            this.dishCostDataGridViewTextBoxColumn.DataPropertyName = "DishCost";
            this.dishCostDataGridViewTextBoxColumn.HeaderText = "Per unit";
            this.dishCostDataGridViewTextBoxColumn.Name = "dishCostDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPage";
            this.Text = "MenuPage";
            this.Load += new System.EventHandler(this.MenuPage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDetailsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRestaurantMenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestaurantDetailsDataSet5 restaurantDetailsDataSet5;
        private System.Windows.Forms.BindingSource tblRestaurantMenuBindingSource;
        private RestaurantDetailsDataSet5TableAdapters.tblRestaurantMenuTableAdapter tblRestaurantMenuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}