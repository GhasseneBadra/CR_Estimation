namespace test1._1
{
    partial class form2
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
            this.scenarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenariodescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newtcsverysimpleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newtcsnormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newtcscomplexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedtcsverysimpleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedtcsnormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedtcscomplexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbtcshortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbtcnormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbtcverylongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newtcseffortperscenarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_scenario_effort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test11DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._test1_1DataSet3 = new test1._1._test1_1DataSet3();
            this.scenarioTableAdapter = new test1._1._test1_1DataSet3TableAdapters.ScenarioTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scenarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test11DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scenarioidDataGridViewTextBoxColumn,
            this.requirementidDataGridViewTextBoxColumn,
            this.scenariodescriptionDataGridViewTextBoxColumn,
            this.newtcsverysimpleDataGridViewTextBoxColumn,
            this.newtcsnormalDataGridViewTextBoxColumn,
            this.newtcscomplexDataGridViewTextBoxColumn,
            this.changedtcsverysimpleDataGridViewTextBoxColumn,
            this.changedtcsnormalDataGridViewTextBoxColumn,
            this.changedtcscomplexDataGridViewTextBoxColumn,
            this.nbtcshortDataGridViewTextBoxColumn,
            this.nbtcnormalDataGridViewTextBoxColumn,
            this.nbtcverylongDataGridViewTextBoxColumn,
            this.newtcseffortperscenarioDataGridViewTextBoxColumn,
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn,
            this.total_scenario_effort});
            this.dataGridView1.DataSource = this.scenarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // scenarioidDataGridViewTextBoxColumn
            // 
            this.scenarioidDataGridViewTextBoxColumn.DataPropertyName = "scenario_id";
            this.scenarioidDataGridViewTextBoxColumn.HeaderText = "Scenario ID";
            this.scenarioidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scenarioidDataGridViewTextBoxColumn.Name = "scenarioidDataGridViewTextBoxColumn";
            this.scenarioidDataGridViewTextBoxColumn.Width = 125;
            // 
            // requirementidDataGridViewTextBoxColumn
            // 
            this.requirementidDataGridViewTextBoxColumn.DataPropertyName = "requirement_id";
            this.requirementidDataGridViewTextBoxColumn.HeaderText = "Requirement ID";
            this.requirementidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requirementidDataGridViewTextBoxColumn.Name = "requirementidDataGridViewTextBoxColumn";
            this.requirementidDataGridViewTextBoxColumn.Width = 125;
            // 
            // scenariodescriptionDataGridViewTextBoxColumn
            // 
            this.scenariodescriptionDataGridViewTextBoxColumn.DataPropertyName = "scenario_description";
            this.scenariodescriptionDataGridViewTextBoxColumn.HeaderText = "Scenario Description";
            this.scenariodescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scenariodescriptionDataGridViewTextBoxColumn.Name = "scenariodescriptionDataGridViewTextBoxColumn";
            this.scenariodescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // newtcsverysimpleDataGridViewTextBoxColumn
            // 
            this.newtcsverysimpleDataGridViewTextBoxColumn.DataPropertyName = "new_tcs_very_simple";
            this.newtcsverysimpleDataGridViewTextBoxColumn.HeaderText = "New TCS very Simple";
            this.newtcsverysimpleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newtcsverysimpleDataGridViewTextBoxColumn.Name = "newtcsverysimpleDataGridViewTextBoxColumn";
            this.newtcsverysimpleDataGridViewTextBoxColumn.Width = 125;
            // 
            // newtcsnormalDataGridViewTextBoxColumn
            // 
            this.newtcsnormalDataGridViewTextBoxColumn.DataPropertyName = "new_tcs_normal";
            this.newtcsnormalDataGridViewTextBoxColumn.HeaderText = "New TCS Normal";
            this.newtcsnormalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newtcsnormalDataGridViewTextBoxColumn.Name = "newtcsnormalDataGridViewTextBoxColumn";
            this.newtcsnormalDataGridViewTextBoxColumn.Width = 125;
            // 
            // newtcscomplexDataGridViewTextBoxColumn
            // 
            this.newtcscomplexDataGridViewTextBoxColumn.DataPropertyName = "new_tcs_complex";
            this.newtcscomplexDataGridViewTextBoxColumn.HeaderText = "New TCS Complex";
            this.newtcscomplexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newtcscomplexDataGridViewTextBoxColumn.Name = "newtcscomplexDataGridViewTextBoxColumn";
            this.newtcscomplexDataGridViewTextBoxColumn.Width = 125;
            // 
            // changedtcsverysimpleDataGridViewTextBoxColumn
            // 
            this.changedtcsverysimpleDataGridViewTextBoxColumn.DataPropertyName = "changed_tcs_very_simple";
            this.changedtcsverysimpleDataGridViewTextBoxColumn.HeaderText = "Changed TCS Very Simple";
            this.changedtcsverysimpleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedtcsverysimpleDataGridViewTextBoxColumn.Name = "changedtcsverysimpleDataGridViewTextBoxColumn";
            this.changedtcsverysimpleDataGridViewTextBoxColumn.Width = 125;
            // 
            // changedtcsnormalDataGridViewTextBoxColumn
            // 
            this.changedtcsnormalDataGridViewTextBoxColumn.DataPropertyName = "changed_tcs_normal";
            this.changedtcsnormalDataGridViewTextBoxColumn.HeaderText = "Changed TCS Normal";
            this.changedtcsnormalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedtcsnormalDataGridViewTextBoxColumn.Name = "changedtcsnormalDataGridViewTextBoxColumn";
            this.changedtcsnormalDataGridViewTextBoxColumn.Width = 125;
            // 
            // changedtcscomplexDataGridViewTextBoxColumn
            // 
            this.changedtcscomplexDataGridViewTextBoxColumn.DataPropertyName = "changed_tcs_complex";
            this.changedtcscomplexDataGridViewTextBoxColumn.HeaderText = "Changed TCS Complex";
            this.changedtcscomplexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedtcscomplexDataGridViewTextBoxColumn.Name = "changedtcscomplexDataGridViewTextBoxColumn";
            this.changedtcscomplexDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbtcshortDataGridViewTextBoxColumn
            // 
            this.nbtcshortDataGridViewTextBoxColumn.DataPropertyName = "nb_tc_short";
            this.nbtcshortDataGridViewTextBoxColumn.HeaderText = "Nb TC Short";
            this.nbtcshortDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbtcshortDataGridViewTextBoxColumn.Name = "nbtcshortDataGridViewTextBoxColumn";
            this.nbtcshortDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbtcnormalDataGridViewTextBoxColumn
            // 
            this.nbtcnormalDataGridViewTextBoxColumn.DataPropertyName = "nb_tc_normal";
            this.nbtcnormalDataGridViewTextBoxColumn.HeaderText = "Nb TC Normal";
            this.nbtcnormalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbtcnormalDataGridViewTextBoxColumn.Name = "nbtcnormalDataGridViewTextBoxColumn";
            this.nbtcnormalDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbtcverylongDataGridViewTextBoxColumn
            // 
            this.nbtcverylongDataGridViewTextBoxColumn.DataPropertyName = "nb_tc_very_long";
            this.nbtcverylongDataGridViewTextBoxColumn.HeaderText = "Nb TC Very Long";
            this.nbtcverylongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbtcverylongDataGridViewTextBoxColumn.Name = "nbtcverylongDataGridViewTextBoxColumn";
            this.nbtcverylongDataGridViewTextBoxColumn.Width = 125;
            // 
            // newtcseffortperscenarioDataGridViewTextBoxColumn
            // 
            this.newtcseffortperscenarioDataGridViewTextBoxColumn.DataPropertyName = "new_tcs_effort_per_scenario";
            this.newtcseffortperscenarioDataGridViewTextBoxColumn.HeaderText = "New TCS Effort Per Scenario";
            this.newtcseffortperscenarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newtcseffortperscenarioDataGridViewTextBoxColumn.Name = "newtcseffortperscenarioDataGridViewTextBoxColumn";
            this.newtcseffortperscenarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // chanegdtcseffortperscenarioDataGridViewTextBoxColumn
            // 
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn.DataPropertyName = "chanegd_tcs_effort_per_scenario";
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn.HeaderText = "Changed TCS Effort Per Scenario";
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn.Name = "chanegdtcseffortperscenarioDataGridViewTextBoxColumn";
            this.chanegdtcseffortperscenarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // total_scenario_effort
            // 
            this.total_scenario_effort.HeaderText = "Total Scenario Effort";
            this.total_scenario_effort.MinimumWidth = 6;
            this.total_scenario_effort.Name = "total_scenario_effort";
            this.total_scenario_effort.Width = 125;
            // 
            // scenarioBindingSource
            // 
            this.scenarioBindingSource.DataMember = "Scenario";
            this.scenarioBindingSource.DataSource = this.test11DataSet3BindingSource;
            // 
            // test11DataSet3BindingSource
            // 
            this.test11DataSet3BindingSource.DataSource = this._test1_1DataSet3;
            this.test11DataSet3BindingSource.Position = 0;
            // 
            // _test1_1DataSet3
            // 
            this._test1_1DataSet3.DataSetName = "_test1_1DataSet3";
            this._test1_1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scenarioTableAdapter
            // 
            this.scenarioTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1194, 580);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 28);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requirement Id =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scenarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test11DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._test1_1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource test11DataSet3BindingSource;
        private _test1_1DataSet3 _test1_1DataSet3;
        private System.Windows.Forms.BindingSource scenarioBindingSource;
        private _test1_1DataSet3TableAdapters.ScenarioTableAdapter scenarioTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenariodescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newtcsverysimpleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newtcsnormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newtcscomplexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedtcsverysimpleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedtcsnormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedtcscomplexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbtcshortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbtcnormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbtcverylongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newtcseffortperscenarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanegdtcseffortperscenarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_scenario_effort;
    }
}