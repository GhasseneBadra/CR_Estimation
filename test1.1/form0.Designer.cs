namespace test1._1
{
    partial class form0
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cRMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._test1_1DataSet3 = new test1._1._test1_1DataSet3();
            this.cRMTableAdapter = new test1._1._test1_1DataSet3TableAdapters.CRMTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.crmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crmidDataGridViewTextBoxColumn,
            this.crdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cRMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cRMBindingSource
            // 
            this.cRMBindingSource.DataMember = "CRM";
            this.cRMBindingSource.DataSource = this._test1_1DataSet3;
            // 
            // _test1_1DataSet3
            // 
            this._test1_1DataSet3.DataSetName = "_test1_1DataSet3";
            this._test1_1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRMTableAdapter
            // 
            this.cRMTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(840, 368);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // crmidDataGridViewTextBoxColumn
            // 
            this.crmidDataGridViewTextBoxColumn.DataPropertyName = "crm_id";
            this.crmidDataGridViewTextBoxColumn.HeaderText = "crm_id";
            this.crmidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crmidDataGridViewTextBoxColumn.Name = "crmidDataGridViewTextBoxColumn";
            this.crmidDataGridViewTextBoxColumn.Width = 125;
            // 
            // crdescriptionDataGridViewTextBoxColumn
            // 
            this.crdescriptionDataGridViewTextBoxColumn.DataPropertyName = "cr_description";
            this.crdescriptionDataGridViewTextBoxColumn.HeaderText = "cr_description";
            this.crdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crdescriptionDataGridViewTextBoxColumn.Name = "crdescriptionDataGridViewTextBoxColumn";
            this.crdescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 456);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form0";
            this.Text = "form0";
            this.Load += new System.EventHandler(this.form0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _test1_1DataSet3 _test1_1DataSet3;
        private System.Windows.Forms.BindingSource cRMBindingSource;
        private _test1_1DataSet3TableAdapters.CRMTableAdapter cRMTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crdescriptionDataGridViewTextBoxColumn;
    }
}