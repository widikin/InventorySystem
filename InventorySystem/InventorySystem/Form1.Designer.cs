namespace InventorySystem
{
    partial class Form1
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
            System.Windows.Forms.Label label2;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastremovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new InventorySystem.inventoryDataSet();
            this.inv_productsTableAdapter = new InventorySystem.inventoryDataSetTableAdapters.inv_productsTableAdapter();
            this.invproductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invproductsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inv_usersTableAdapter = new InventorySystem.inventoryDataSetTableAdapters.inv_usersTableAdapter();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invusersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.serialnumDataGridViewTextBoxColumn,
            this.lastaddedDataGridViewTextBoxColumn,
            this.lastremovedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invproductsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.invusersBindingSource;
            this.comboBox1.DisplayMember = "realname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "userid";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-10",
            "-1",
            "1",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(165, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.invusersBindingSource;
            this.comboBox3.DisplayMember = "username";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(14, 230);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "userid";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(12, 287);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 345);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // serialnumDataGridViewTextBoxColumn
            // 
            this.serialnumDataGridViewTextBoxColumn.DataPropertyName = "serialnum";
            this.serialnumDataGridViewTextBoxColumn.HeaderText = "serialnum";
            this.serialnumDataGridViewTextBoxColumn.Name = "serialnumDataGridViewTextBoxColumn";
            // 
            // lastaddedDataGridViewTextBoxColumn
            // 
            this.lastaddedDataGridViewTextBoxColumn.DataPropertyName = "last_added";
            this.lastaddedDataGridViewTextBoxColumn.HeaderText = "last_added";
            this.lastaddedDataGridViewTextBoxColumn.Name = "lastaddedDataGridViewTextBoxColumn";
            // 
            // lastremovedDataGridViewTextBoxColumn
            // 
            this.lastremovedDataGridViewTextBoxColumn.DataPropertyName = "last_removed";
            this.lastremovedDataGridViewTextBoxColumn.HeaderText = "last_removed";
            this.lastremovedDataGridViewTextBoxColumn.Name = "lastremovedDataGridViewTextBoxColumn";
            // 
            // invproductsBindingSource
            // 
            this.invproductsBindingSource.DataMember = "inv_products";
            this.invproductsBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inv_productsTableAdapter
            // 
            this.inv_productsTableAdapter.ClearBeforeFill = true;
            // 
            // invproductsBindingSource1
            // 
            this.invproductsBindingSource1.DataMember = "inv_products";
            this.invproductsBindingSource1.DataSource = this.inventoryDataSet;
            // 
            // invproductsBindingSource2
            // 
            this.invproductsBindingSource2.DataMember = "inv_products";
            this.invproductsBindingSource2.DataSource = this.inventoryDataSet;
            // 
            // invusersBindingSource
            // 
            this.invusersBindingSource.DataMember = "inv_users";
            this.invusersBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inv_usersTableAdapter
            // 
            this.inv_usersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Submit Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 214);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 9;
            label2.Text = "Display by user";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 644);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invusersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource invproductsBindingSource;
        private inventoryDataSetTableAdapters.inv_productsTableAdapter inv_productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastremovedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource invproductsBindingSource1;
        private System.Windows.Forms.BindingSource invproductsBindingSource2;
        private System.Windows.Forms.BindingSource invusersBindingSource;
        private inventoryDataSetTableAdapters.inv_usersTableAdapter inv_usersTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
    }
}

