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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastremovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new InventorySystem.inventoryDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSerial_Add = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.invusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inv_productsTableAdapter = new InventorySystem.inventoryDataSetTableAdapters.inv_productsTableAdapter();
            this.invproductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invproductsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inv_usersTableAdapter = new InventorySystem.inventoryDataSetTableAdapters.inv_usersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxID_Add = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Remove = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxSerial_Remove = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 326);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 9;
            label2.Text = "Display by user";
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.invproductsBindingSource;
            this.comboBox1.DisplayMember = "product";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "product";
            // 
            // comboBox2
            // 
            this.comboBoxSerial_Add.DataSource = this.invproductsBindingSource;
            this.comboBoxSerial_Add.DisplayMember = "serialnum";
            this.comboBoxSerial_Add.FormattingEnabled = true;
            this.comboBoxSerial_Add.Location = new System.Drawing.Point(298, 178);
            this.comboBoxSerial_Add.Name = "comboBox2";
            this.comboBoxSerial_Add.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial_Add.TabIndex = 2;
            this.comboBoxSerial_Add.ValueMember = "serialnum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.invusersBindingSource;
            this.comboBox3.DisplayMember = "username";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 342);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "userid";
            // 
            // invusersBindingSource
            // 
            this.invusersBindingSource.DataMember = "inv_users";
            this.invusersBindingSource.DataSource = this.inventoryDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 342);
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
            this.listView1.Location = new System.Drawing.Point(12, 374);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 258);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // inv_usersTableAdapter
            // 
            this.inv_usersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add amount";
            // 
            // comboBoxID_Add
            // 
            this.comboBoxID_Add.DataSource = this.invproductsBindingSource;
            this.comboBoxID_Add.DisplayMember = "id";
            this.comboBoxID_Add.FormattingEnabled = true;
            this.comboBoxID_Add.Location = new System.Drawing.Point(12, 178);
            this.comboBoxID_Add.Name = "comboBoxID_Add";
            this.comboBoxID_Add.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID_Add.TabIndex = 10;
            this.comboBoxID_Add.ValueMember = "id";
            // 
            // comboBoxID_Remove
            // 
            this.comboBoxID_Remove.DataSource = this.invproductsBindingSource;
            this.comboBoxID_Remove.DisplayMember = "id";
            this.comboBoxID_Remove.FormattingEnabled = true;
            this.comboBoxID_Remove.Location = new System.Drawing.Point(12, 234);
            this.comboBoxID_Remove.Name = "comboBoxID_Remove";
            this.comboBoxID_Remove.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID_Remove.TabIndex = 16;
            this.comboBoxID_Remove.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Remove amount";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(580, 234);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(447, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // comboBox6
            // 
            this.comboBoxSerial_Remove.DataSource = this.invproductsBindingSource;
            this.comboBoxSerial_Remove.DisplayMember = "serialnum";
            this.comboBoxSerial_Remove.FormattingEnabled = true;
            this.comboBoxSerial_Remove.Location = new System.Drawing.Point(298, 234);
            this.comboBoxSerial_Remove.Name = "comboBox6";
            this.comboBoxSerial_Remove.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial_Remove.TabIndex = 12;
            this.comboBoxSerial_Remove.ValueMember = "serialnum";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.invproductsBindingSource;
            this.comboBox7.DisplayMember = "product";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(147, 234);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 11;
            this.comboBox7.ValueMember = "product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 644);
            this.Controls.Add(this.comboBoxID_Remove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxSerial_Remove);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBoxID_Add);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxSerial_Add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invproductsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSerial_Add;
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
        private System.Windows.Forms.ComboBox comboBoxID_Add;
        private System.Windows.Forms.ComboBox comboBoxID_Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxSerial_Remove;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}

