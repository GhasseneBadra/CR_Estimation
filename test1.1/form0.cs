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
    public partial class form0 : DevExpress.XtraEditors.XtraForm
    {

        public String x;
        
       

        public form0()
        {
            InitializeComponent();

            //add new columns with image to use later for click function

            dataGridView1.Columns.Add(new DataGridViewImageColumn() {

                Image = Properties.Resources.add,
                
               
                Name = "add",
                HeaderText = "add CR_Estimation"
            }); ;

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {

                Image = Properties.Resources.loupe,
                Name = "show_detail",
                HeaderText = "show CRM detail"
            }); ;



        }

        private void form0_Load(object sender, EventArgs e)
        {

            this.cRMTableAdapter.Fill(this._test1_1DataSet3.CRM);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            var senderGrid = (DataGridView)sender;

            // open new form 7asb il column ili nzelt 3lyh 

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "add")
            {
                Form1 f1 = new Form1(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                f1.ShowDialog();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "show_detail")
            {
                CRM_Detail_Form f4 = new CRM_Detail_Form(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                f4.ShowDialog();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=test1.1;Integrated Security=True");


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = dataGridView1.Rows[i].Cells[0].Value.ToString();



                SqlCommand cmd = new SqlCommand
                    (@"INSERT INTO CRM (crm_id, cr_description)VALUES('"
                        + dataGridView1.Rows[i].Cells[0].Value + "','"
                        + dataGridView1.Rows[i].Cells[1].Value +
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

        }
    }
}