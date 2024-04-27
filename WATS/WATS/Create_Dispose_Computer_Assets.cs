using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WATS
{
    public partial class Create_Dispose_Computer_Assets : Form
    {

        SqlConnection con = new SqlConnection("Server=tcp:peircecollegecapstone.database.windows.net,1433; Database = wats; User ID = rese298; Password = password01!; Trusted_Connection = False; Encrypt = True");



        public Create_Dispose_Computer_Assets()
        {
            InitializeComponent();
        }

        private void Show_All_Assets_Button_Click(object sender, EventArgs e)
        {
            //**MAIN LOGIC**//
            //**START**//



            //(Code Block 1 - START) - Establishing A Connection With The SQL Server Database
            //(Code Block 1.1) - SQL Connection String Intilization
            String SQLConnectionString;


            //(Code Block 1.2) - SQL Connection String Assigned Database Connection String Information
            SQLConnectionString = "Server=tcp:peircecollegecapstone.database.windows.net,1433; Database = wats; User ID = rese298; Password = password01!; Trusted_Connection = False; Encrypt = True";


            //(Code Block 1.3) - Create An Object Of Type SqlConnection Named "SQLConnectionObject", Fed SQLConnectionString As The Parameter
            SqlConnection SQLConnectionObject = new SqlConnection(SQLConnectionString);


            //#EXCEPTION 1 START//
            try
            {

                //(Code Block 1.4) - The Connection Method Is Utilized To Create Open The Connection With The SQL Server Database
                SQLConnectionObject.Open();
                //(Code Block 1 - END)//

            }


            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Error With Connecting To The Database, Please Contact Your System Administrator Before Starting The Application Again");
                System.Windows.Forms.Application.Exit();

            }
            //#EXCEPTION 1 END//



            //**(Code Block 2 - START)**// - Executing The Desired Query & Displaying The Result Onto A Data Grid View
            //(Code Block 2.1). Inner Join Query Between Three Tables "BookTable", "CourseBookTable", "PeirceCollegeCourseCatalogTable
            //This Query Should Select All Books, Their Course Number, Title, ISBN And Course Name, Only Three Results Should Show
            string Sql_Query_1 = "SELECT * FROM [dbo].[Computer_Asset_Table]; ";


            //(Code Block 2.2) - Created Object Of Type SqlCommnd Named "DataBaseCommand", With The Parameters Sql_Query_1 & Executing Against Our SQLConnectionObject Variable
            SqlCommand DataBaseCommand = new SqlCommand(Sql_Query_1, SQLConnectionObject);


            //(Code Block 2.3) - Created Variable Adapter Of Type SqlDataAdapter, This Serves As A Bridge To Our SQL Server Database
            SqlDataAdapter Adapter;


            // Created Variable DataTable Of Type DataTable, This Serves As A Viewer For Our Query
            DataTable DataTable;


            //(Code Block 2.4) - Created New Object Of SqlDataAdapter, With Our Query & Our SQLConnectionObject As Parameters
            Adapter = new SqlDataAdapter(Sql_Query_1, SQLConnectionObject);


            // Created New Object Of Type DataTable
            DataTable = new DataTable();




            //#EXCEPTION 2 START//
            try
            {

                //(Code Block 2.5) - Utilized Fill To Execute Our Query Against Our DataBase Into Our DataTable Variable
                Adapter.Fill(DataTable);

            }

            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Error With Connecting To The Database, Please Contact Your System Administrator Before Starting The Application Again");
                System.Windows.Forms.Application.Exit();

            }
            //#EXCEPTION 2 END//





            //Filled Our DataGridView With The Results From Our Query Filled Into DataTable
            dataGridView1.DataSource = DataTable;


            //(Code Block 2.6) - Disposal Of Our DataBase Command Object As Well As Closing The Connection To Our SQL Server
            DataBaseCommand.Dispose();
            SQLConnectionObject.Close();


            //**(Code Block 2 - END)**//
            //**MAIN LOGIC END**//
        }


        private void Create_Asset_Button_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Computer_Asset_Table (Computer_Asset_Manufacturer  , Computer_Asset_Model_Type,  Computer_Asset_Model_Name   ,  Computer_Asset_Status,   Computer_Asset_Purchase_Date, Computer_Asset_NBV)" +
                    "values(' " + Computer_Asset_Manufacturer_Combo_Box.Text +  " ', ' " + Computer_Asset_Model_Type_Combo_Box.Text + " ', ' " + Computer_Asset_Model_Name_Text_Box.Text + " ', ' " + Computer_Asset_Status_Combo_Box.Text + " ', ' " + DateTime.Parse(Computer_Asset_Purchase_Date_Text_Box.Text) +  " ', ' " + int.Parse(Computer_Asset_NBV_Text_Box.Text) + " ')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Addedd");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void Dispose_Asset_Button_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Computer_Asset_Table SET Computer_Asset_Status = 'DISPOSED', Computer_Asset_Disposal_Date = getdate() WHERE Computer_Asset_ID=@Computer_Asset_ID", con);
                cmd.Parameters.AddWithValue("@Computer_Asset_ID", int.Parse(Computer_Asset_ID_Text_Box.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("DISPOSED!");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
    }
}
