using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace test1._1
{
    public partial class CRM_Detail_Form : DevExpress.XtraEditors.XtraForm
    {
        string crm_ID;
        string crm_description;






        DataTable DataTable3 = new DataTable();
        private DataTable x;

        public class CRMEstimation
        {
            public _test1_1DataSet4.CRMRow Crm { get; set; }

            public _test1_1DataSet4.CR_EstimationRow Estimation { get; set; }


        }







        public CRM_Detail_Form(string x ,string y)
        {
            InitializeComponent();

            crm_ID = x;
            crm_description = y;

            label3.Text = crm_ID;
            label4.Text = crm_description;




           




            // var select = "SELECT cr_description FROM CRM WHERE crm_id ='" + crm_ID + "'";
            //var c = new SqlConnection(@"Data Source=.;Initial Catalog=test1.1;Integrated Security=True"); // Your Connection String here
            //var dataAdapter = new SqlDataAdapter(select, c);
            //var commandBuilder = new SqlCommandBuilder(dataAdapter);


            // MessageBox.Show(commandBuilder.ToString());

            string connString = @"Data Source=.;Initial Catalog=test1.1;Integrated Security=True";

                       string SQL = "SELECT crm_id, cr_description FROM CRM WHERE crm_id ='" + crm_ID + "'";




            // TODO : use requet SQL with boucle for to fill form's labels



            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(SQL, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                       label8.Text = reader[0] as string;
                        label10.Text = reader[1] as string;

                        break;
                    }
                }
                conn.Close();
            }

            // 



        }



        private void _Load(object sender, EventArgs e)
        {


        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private  void tablePanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void CRM_Detail_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_test1_1DataSet4.CRM' table. You can move, or remove it, as needed.
            this.cRMTableAdapter1.Fill(this._test1_1DataSet4.CRM);
            this.cRMTableAdapter2.Fill(this._test1_1DataSet4.CR_Estimation);
            this.cRMTableAdapter3.Fill(this._test1_1DataSet4.Scenario);






            // query to export needed data from databse to Excel 

                var abc = from CRM in _test1_1DataSet4.CRM.AsEnumerable()
                          join CR_Estimation in _test1_1DataSet4.CR_Estimation.AsEnumerable()
                          on CRM.Field<String>("crm_id") equals
                             CR_Estimation.Field<String>("crm_id")
                          join Scenario in _test1_1DataSet4.Scenario
                          on CR_Estimation.Field<String>("requirement_id") equals
                          Scenario.Field<String>("requirement_id")

                          where CRM.Field<String>("crm_id") == crm_ID
                          select new
                          {
                              CRM_ID = CRM.Field<String>("crm_id"),
                              cr_description = CRM.Field<String>("cr_description"),
                              requirement_id= CR_Estimation.Field<String>("requirement_id"),
                              requirement_from_original_id = CR_Estimation.Field<String>("requirement_from_original_id"),
                              object_type = CR_Estimation.Field<String>("object_type"),
                              total_estimation_effort= CR_Estimation.Field<Double?>("total_estimation_effort") ,
                              scenario_description = Scenario.Field<String>("scenario_description"),
                              new_tcs_very_simple = Scenario.Field<Double?>("new_tcs_very_simple"),
                              new_tcs_normal = Scenario.Field<Double?>("new_tcs_normal"),
                              new_tcs_complex = Scenario.Field<Double?>("new_tcs_complex"),
                              changed_tcs_very_simple = Scenario.Field<Double?>("changed_tcs_very_simple"),
                              changed_tcs_normal = Scenario.Field<Double?>("changed_tcs_normal"),
                              changed_tcs_complex = Scenario.Field<Double?>("changed_tcs_complex"),
                              nb_tc_short = Scenario.Field<Double?>("nb_tc_short"),
                              nb_tc_normal = Scenario.Field<Double?>("nb_tc_normal"),
                              nb_tc_very_long = Scenario.Field<Double?>("nb_tc_very_long"),
                              new_tcs_effort_per_scenario = Scenario.Field<Double?>("new_tcs_effort_per_scenario"),
                              chanegd_tcs_effort_per_scenario = Scenario.Field<Double?>("chanegd_tcs_effort_per_scenario"),
                              total_scenario_effort = Scenario.Field<Double?>("total_scenario_effort"),
                          };



                x = MoreLinq.MoreEnumerable.ToDataTable(abc);
 






        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



            //export dialog pick export location

            using (SaveFileDialog sfd=new SaveFileDialog() { Filter = "Excel workbook|*.xlsx"})
                if(sfd.ShowDialog()== DialogResult.OK) { 
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("All Effort Overview");


                        //design il table 1

                        IXLRange range = worksheet.Range(worksheet.Cell(2, 3).Address, worksheet.Cell(3, 4).Address);
                        range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                        range.Style.Border.InsideBorder = XLBorderStyleValues.Medium;





                        //design il table 2

                        IXLRange range2 = worksheet.Range(worksheet.Cell(5, 3).Address, worksheet.Cell(9, 4).Address);
                        range2.Style.Border.InsideBorder = XLBorderStyleValues.Medium;
                        range2.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;


                        range2.Style.Border.OutsideBorderColor = XLColor.FromHtml("#f4b083");
                        range2.Style.Border.InsideBorderColor = XLColor.FromHtml("#f4b083");
                        range2.Style.Font.FontColor = XLColor.FromHtml("#c86523");

                        worksheet.Cell(6,4).Style.Fill.SetBackgroundColor(XLColor.FromHtml("#FBE4D5"));
                        worksheet.Cell(8, 4).Style.Fill.SetBackgroundColor(XLColor.FromHtml("#FBE4D5"));




                        // design il tableau 3 

                        IXLRange range3 = worksheet.Range(worksheet.Cell(5, 6).Address, worksheet.Cell(13, 7).Address);
                        range3.Style.Border.InsideBorder = XLBorderStyleValues.Medium;
                        range3.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;


                        range3.Style.Border.OutsideBorderColor = XLColor.FromHtml("#A3B9E1");
                        range3.Style.Border.InsideBorderColor = XLColor.FromHtml("#A3B9E1");
                        range3.Style.Font.FontColor = XLColor.FromHtml("#305596");



                        worksheet.Cell(6, 7).Style.Fill.SetBackgroundColor(XLColor.FromHtml("#D9E2F3"));
                        worksheet.Cell(8, 7).Style.Fill.SetBackgroundColor(XLColor.FromHtml("#D9E2F3"));
                        worksheet.Cell(10, 7).Style.Fill.SetBackgroundColor(XLColor.FromHtml("#D9E2F3"));
                        worksheet.Cell(12, 7).Style.Fill.SetBackgroundColor(XLColor.FromHtml("#D9E2F3"));



                        // code insert valeur mt3 tableau 1

                        worksheet.Cell(2, 3).Value = "CRM ID";
                        worksheet.Cell(3,3).Value = "crm_description";
                        worksheet.Cell(2, 3).Style.Font.Bold = true;
                        worksheet.Cell(3, 3).Style.Font.Bold = true;

                        worksheet.Cell(2, 4).Value = crm_ID;
                        worksheet.Cell(3, 4).Value = crm_ID;



                        // code insert valeur mt3 tableau 2

                        worksheet.Cell(5, 3).Value = "Activity";
                        worksheet.Cell(5, 4).Value = " n°";
                        worksheet.Cell(5, 3).Style.Font.Bold = true;
                        worksheet.Cell(5, 4).Style.Font.Bold = true;

                        worksheet.Cell(6, 3).Value = "#Req changed";
                        worksheet.Cell(7, 3).Value = "#Req new";
                        worksheet.Cell(8, 3).Value = "#TC to be changed";
                        worksheet.Cell(9, 3).Value = "#TC new";

                        worksheet.Cell(6, 4).Value = crm_ID;
                        worksheet.Cell(7, 4).Value = crm_ID;
                        worksheet.Cell(8, 4).Value = crm_ID;
                        worksheet.Cell(9, 4).Value = crm_ID;






                        // code insert valeur mt3 tableau 3


                        worksheet.Cell(5, 6).Value = "Activity";
                        worksheet.Cell(5, 7).Value = "hours";
                        worksheet.Cell(5, 6).Style.Font.Bold = true;
                        worksheet.Cell(5, 7).Style.Font.Bold = true;


                        worksheet.Cell(6, 6).Value = "Spec review";
                        worksheet.Cell(7, 6).Value = "Refactoring of TCs ";
                        worksheet.Cell(8, 6).Value = "Implementation of new TCs";
                        worksheet.Cell(9, 6).Value = "Test case execution";
                        worksheet.Cell(10, 6).Value = "Test case review";
                        worksheet.Cell(11, 6).Value = "Infrastructure";
                        worksheet.Cell(12, 6).Value = "Total ";
                        worksheet.Cell(13, 6).Value = "Test case exec. 2nd loop";

                        worksheet.Cell(6, 7).Value = crm_ID;
                        worksheet.Cell(7, 7).Value = crm_ID;
                        worksheet.Cell(8, 7).Value = crm_ID;
                        worksheet.Cell(9, 7).Value = crm_ID;          
                        worksheet.Cell(10, 7).Value = crm_ID;        
                        worksheet.Cell(11, 7).Value = crm_ID;        
                        worksheet.Cell(12, 7).Value = crm_ID;    
                        worksheet.Cell(13, 7).Value = crm_ID;


                        // TODO : use requet SQL with boocle for lil insertion mt3 data mil database ( exemple ligne 50 -->70)





                        // usage mt3 query lil export tables lil excel 
                        workbook.Worksheets.Add(x, "Estimation Detail");
                        
                        
                workbook.SaveAs(sfd.FileName);

            }
                }
        }
    }
}