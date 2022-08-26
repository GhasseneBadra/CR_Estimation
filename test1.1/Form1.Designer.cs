namespace test1._1
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this._test1_1DataSet = new test1._1._test1_1DataSet();
            this.cREstimationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cR_EstimationTableAdapter = new test1._1._test1_1DataSetTableAdapters.CR_EstimationTableAdapter();
            this.cREstimationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._test1_1DataSet1 = new test1._1._test1_1DataSet1();
            this.cR_EstimationTableAdapter1 = new test1._1._test1_1DataSet1TableAdapters.CR_EstimationTableAdapter();
            this.test11DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREstimationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementfromoriginalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objecttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_estimation_effort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREstimationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.test11DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._test1_1DataSet2 = new test1._1._test1_1DataSet3();
            this.scenarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cR_EstimationTableAdapter2 = new test1._1._test1_1DataSet3TableAdapters.CR_EstimationTableAdapter();
            this.scenarioTableAdapter = new test1._1._test1_1DataSet3TableAdapters.ScenarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test11DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test11DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scenarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1001, 484);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 28);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // _test1_1DataSet
            // 
            this._test1_1DataSet.DataSetName = "_test1_1DataSet";
            this._test1_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREstimationBindingSource
            // 
            this.cREstimationBindingSource.DataMember = "CR_Estimation";
            this.cREstimationBindingSource.DataSource = this._test1_1DataSet;
            // 
            // cR_EstimationTableAdapter
            // 
            this.cR_EstimationTableAdapter.ClearBeforeFill = true;
            // 
            // cREstimationBindingSource1
            // 
            this.cREstimationBindingSource1.DataMember = "CR_Estimation";
            this.cREstimationBindingSource1.DataSource = this._test1_1DataSet1;
            // 
            // _test1_1DataSet1
            // 
            this._test1_1DataSet1.DataSetName = "_test1_1DataSet1";
            this._test1_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cR_EstimationTableAdapter1
            // 
            this.cR_EstimationTableAdapter1.ClearBeforeFill = true;
            // 
            // test11DataSet1BindingSource
            // 
            this.test11DataSet1BindingSource.DataSource = this._test1_1DataSet1;
            this.test11DataSet1BindingSource.Position = 0;
            // 
            // cREstimationBindingSource2
            // 
            this.cREstimationBindingSource2.DataMember = "CR_Estimation";
            this.cREstimationBindingSource2.DataSource = this.test11DataSet1BindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crmidDataGridViewTextBoxColumn,
            this.requirementidDataGridViewTextBoxColumn,
            this.requirementfromoriginalidDataGridViewTextBoxColumn,
            this.objecttypeDataGridViewTextBoxColumn,
            this.total_estimation_effort});
            this.dataGridView1.DataSource = this.cREstimationBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(30, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(812, 431);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            // 
            // crmidDataGridViewTextBoxColumn
            // 
            this.crmidDataGridViewTextBoxColumn.DataPropertyName = "crm_id";
            this.crmidDataGridViewTextBoxColumn.HeaderText = "CRM ID";
            this.crmidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crmidDataGridViewTextBoxColumn.Name = "crmidDataGridViewTextBoxColumn";
            this.crmidDataGridViewTextBoxColumn.Width = 125;
            // 
            // requirementidDataGridViewTextBoxColumn
            // 
            this.requirementidDataGridViewTextBoxColumn.DataPropertyName = "requirement_id";
            this.requirementidDataGridViewTextBoxColumn.HeaderText = "Requirement ID";
            this.requirementidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requirementidDataGridViewTextBoxColumn.Name = "requirementidDataGridViewTextBoxColumn";
            this.requirementidDataGridViewTextBoxColumn.Width = 125;
            // 
            // requirementfromoriginalidDataGridViewTextBoxColumn
            // 
            this.requirementfromoriginalidDataGridViewTextBoxColumn.DataPropertyName = "requirement_from_original_id";
            this.requirementfromoriginalidDataGridViewTextBoxColumn.HeaderText = "Requirement From Original ID";
            this.requirementfromoriginalidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requirementfromoriginalidDataGridViewTextBoxColumn.Name = "requirementfromoriginalidDataGridViewTextBoxColumn";
            this.requirementfromoriginalidDataGridViewTextBoxColumn.Width = 125;
            // 
            // objecttypeDataGridViewTextBoxColumn
            // 
            this.objecttypeDataGridViewTextBoxColumn.DataPropertyName = "object_type";
            this.objecttypeDataGridViewTextBoxColumn.HeaderText = "Object Type";
            this.objecttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.objecttypeDataGridViewTextBoxColumn.Name = "objecttypeDataGridViewTextBoxColumn";
            this.objecttypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // total_estimation_effort
            // 
            this.total_estimation_effort.HeaderText = "total Estimation Effort";
            this.total_estimation_effort.MinimumWidth = 6;
            this.total_estimation_effort.Name = "total_estimation_effort";
            this.total_estimation_effort.Width = 125;
            // 
            // cREstimationBindingSource3
            // 
            this.cREstimationBindingSource3.DataMember = "CR_Estimation";
            this.cREstimationBindingSource3.DataSource = this.test11DataSet2BindingSource;
            // 
            // test11DataSet2BindingSource
            // 
            this.test11DataSet2BindingSource.DataSource = this._test1_1DataSet2;
            this.test11DataSet2BindingSource.Position = 0;
            // 
            // _test1_1DataSet2
            // 
            this._test1_1DataSet2.DataSetName = "_test1_1DataSet2";
            this._test1_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scenarioBindingSource
            // 
            this.scenarioBindingSource.DataMember = "Scenario";
            this.scenarioBindingSource.DataSource = this.test11DataSet2BindingSource;
            // 
            // cR_EstimationTableAdapter2
            // 
            this.cR_EstimationTableAdapter2.ClearBeforeFill = true;
            // 
            // scenarioTableAdapter
            // 
            this.scenarioTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test11DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREstimationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test11DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scenarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private _test1_1DataSet _test1_1DataSet;
        private System.Windows.Forms.BindingSource cREstimationBindingSource;
        private _test1_1DataSetTableAdapters.CR_EstimationTableAdapter cR_EstimationTableAdapter;
        private _test1_1DataSet1 _test1_1DataSet1;
        private System.Windows.Forms.BindingSource cREstimationBindingSource1;
        private _test1_1DataSet1TableAdapters.CR_EstimationTableAdapter cR_EstimationTableAdapter1;
        private System.Windows.Forms.BindingSource cREstimationBindingSource2;
        private System.Windows.Forms.BindingSource test11DataSet1BindingSource;
        private _test1_1DataSet3 _test1_1DataSet2;
        private System.Windows.Forms.BindingSource test11DataSet2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cREstimationBindingSource3;
        private _test1_1DataSet3TableAdapters.CR_EstimationTableAdapter cR_EstimationTableAdapter2;
        private System.Windows.Forms.BindingSource scenarioBindingSource;
        private _test1_1DataSet3TableAdapters.ScenarioTableAdapter scenarioTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementfromoriginalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objecttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_estimation_effort;
    }
}

