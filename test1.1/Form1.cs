using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace test1._1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Entities1 db = new Entities1();
        public String x;
        string crm_ID;

        public Form1(string x)
        {
            InitializeComponent();
            crm_ID = x;

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {

                Image = Properties.Resources.loupe,


                Name = "add",
                HeaderText = "Show Scenarios"
            }); ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            this.cR_EstimationTableAdapter2.Fill(this._test1_1DataSet2.CR_Estimation);

            // fill dataGridView manually with sql request


            var select = "SELECT * FROM CR_ESTIMATION WHERE crm_id =" + crm_ID;
            // Connection String here
            var c = new SqlConnection(@"Data Source=.;Initial Catalog=test1.1;Integrated Security=True");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = ds.Tables[0];


        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=test1.1;Integrated Security=True");

            // boucle for lil insertion mt3 data mil datagridview to database

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = dataGridView1.Rows[i].Cells[0].Value.ToString();

                Console.WriteLine(x);

                SqlCommand cmd = new SqlCommand
                    (@"INSERT INTO CR_ESTIMATION (crm_id, requirement_id, requirement_from_original_id, object_type, total_estimation_effort)VALUES('"
                        + crm_ID + "','"
                        + dataGridView1.Rows[i].Cells[1].Value + "','"
                        + dataGridView1.Rows[i].Cells[2].Value + "','"
                        + dataGridView1.Rows[i].Cells[3].Value + "','"
                        + dataGridView1.Rows[i].Cells[4].Value +
                        "')", con);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }

                con.Close();


            }


            /*db.CR_Estimation.Add(new CR_Estimation
             {

                 crm_id = int.Parse(crmidDataGridViewTextBoxColumn.c),
                 requirement_id = requirement_idTextEdit.Text,
                 requirement_from_original_id = requirement_from_original_idTextEdit.Text,
                 object_type = object_typeTextEdit.Text
             });

             db.SaveChanges();*/
        }
        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                form2 f2 = new form2(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                f2.ShowDialog();
            }
        }
    }




}
