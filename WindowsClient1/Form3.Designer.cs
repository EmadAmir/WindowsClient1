namespace WindowsClient1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restaurantDetailsDataSet = new WindowsClient1.RestaurantDetailsDataSet();
            this.tblRestaurantMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRestaurantMenuTableAdapter = new WindowsClient1.RestaurantDetailsDataSetTableAdapters.tblRestaurantMenuTableAdapter();
            this.ListViewTbl = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.ID_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRestaurantMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblRestaurantMenuBindingSource;
            this.comboBox1.DisplayMember = "DishName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // restaurantDetailsDataSet
            // 
            this.restaurantDetailsDataSet.DataSetName = "RestaurantDetailsDataSet";
            this.restaurantDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRestaurantMenuBindingSource
            // 
            this.tblRestaurantMenuBindingSource.DataMember = "tblRestaurantMenu";
            this.tblRestaurantMenuBindingSource.DataSource = this.restaurantDetailsDataSet;
            // 
            // tblRestaurantMenuTableAdapter
            // 
            this.tblRestaurantMenuTableAdapter.ClearBeforeFill = true;
            // 
            // ListViewTbl
            // 
            this.ListViewTbl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_column,
            this.Item_column,
            this.Price_column});
            this.ListViewTbl.Location = new System.Drawing.Point(104, 103);
            this.ListViewTbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListViewTbl.Name = "ListViewTbl";
            this.ListViewTbl.Size = new System.Drawing.Size(304, 269);
            this.ListViewTbl.TabIndex = 3;
            this.ListViewTbl.UseCompatibleStateImageBehavior = false;
            this.ListViewTbl.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_column
            // 
            this.ID_column.Text = "ID";
            // 
            // Item_column
            // 
            this.Item_column.Text = "Item";
            this.Item_column.Width = 133;
            // 
            // Price_column
            // 
            this.Price_column.Text = "Price";
            this.Price_column.Width = 179;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListViewTbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRestaurantMenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private RestaurantDetailsDataSet restaurantDetailsDataSet;
        private System.Windows.Forms.BindingSource tblRestaurantMenuBindingSource;
        private RestaurantDetailsDataSetTableAdapters.tblRestaurantMenuTableAdapter tblRestaurantMenuTableAdapter;
        private System.Windows.Forms.ListView ListViewTbl;
        private System.Windows.Forms.ColumnHeader ID_column;
        private System.Windows.Forms.ColumnHeader Item_column;
        private System.Windows.Forms.ColumnHeader Price_column;
        private System.Windows.Forms.Button button1;
    }
}