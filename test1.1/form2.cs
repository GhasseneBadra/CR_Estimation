using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test1._1
{
    public partial class form2 : DevExpress.XtraEditors.XtraForm
    {
        string requirementid;

        public form2(string x)
        {
            InitializeComponent();
            requirementid = x;


        }

        private void form2_Load(object sender, EventArgs e)
        {
            //var y = this._test1_1DataSet3.Scenario.Select("requirement_id = '2'");
            //var x =y.CopyToDataTable();
            // ScenarioDataTable tb = (ScenarioDataTable)x;







            // fill dataGridView manually with sql request


            var select = "SELECT * FROM Scenario WHERE requirement_id ='"+requirementid+"'";
            var c = new SqlConnection(@"Data Source=.;Initial Catalog=test1.1;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = ds.Tables[0];

            label2.Text = requirementid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=test1.1;Integrated Security=True");


            //boucle for lil insert

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {



                SqlCommand cmd = new SqlCommand
                    (@"INSERT INTO Scenario (scenario_id, requirement_id, scenario_description, new_tcs_very_simple, new_tcs_normal, new_tcs_complex, changed_tcs_very_simple, changed_tcs_normal, changed_tcs_complex, 
                           nb_tc_short, nb_tc_normal, nb_tc_very_long, new_tcs_effort_per_scenario, chanegd_tcs_effort_per_scenario, total_scenario_effort)VALUES('"
                        + dataGridView1.Rows[i].Cells[0].Value + "','"
                        + requirementid + "','"
                        + dataGridView1.Rows[i].Cells[2].Value + "','"
                        + dataGridView1.Rows[i].Cells[3].Value + "','"
                        + dataGridView1.Rows[i].Cells[4].Value + "','"
                        + dataGridView1.Rows[i].Cells[5].Value + "','"
                        + dataGridView1.Rows[i].Cells[6].Value + "','"
                        + dataGridView1.Rows[i].Cells[7].Value + "','"
                        + dataGridView1.Rows[i].Cells[8].Value + "','"
                        + dataGridView1.Rows[i].Cells[9].Value + "','"
                        + dataGridView1.Rows[i].Cells[10].Value + "','"
                        + dataGridView1.Rows[i].Cells[11].Value + "','"
                        + dataGridView1.Rows[i].Cells[12].Value + "','"
                        + dataGridView1.Rows[i].Cells[13].Value + "','"
                        + dataGridView1.Rows[i].Cells[14].Value +
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

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                form2 f2 = new form2(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                f2.ShowDialog();
            }
        }

    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}