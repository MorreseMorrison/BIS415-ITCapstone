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

namespace WATS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //**(SECTION 1 - ASSET ASSIGNMENT SCREENS - START)**//
        //Note - This Section Contains Logic To Open The Two Asset Assignment Forms//

        //(1)Assign_Unassign_Office_Assets
        private void Assign_Unassign_Office_Assets_Button_Click(object sender, EventArgs e)
        {
            Assign_Unassign_Office_Assets FormLoader = new Assign_Unassign_Office_Assets();
            FormLoader.Show();

        }

        //(2)Assign_Unassign_Computer_Assets
        private void Assign_Unassign_Computer_Assets_Button_Click(object sender, EventArgs e)
        {
            Assign_Unassign_Computer_Assets FormLoader = new Assign_Unassign_Computer_Assets();
            FormLoader.Show();
        }
        //**(SECTION 1 - ASSET ASSIGNMENT SCREENS - END)**//




        //**(SECTION 2 - CREATION SCREENS - START)**//
        //Note - This Section Contains Logic To Open The Three Creation Forms//

        //(3)Create_Inactivate_Employees.cs
        private void button3_Click(object sender, EventArgs e)
        {
            Create_Inactivate_Employees FormLoader = new Create_Inactivate_Employees();
            FormLoader.Show();
        }

        //(4)Create_Inactivate_Offices.cs
        private void button4_Click(object sender, EventArgs e)
        {
            Create_Inactivate_Offices FormLoader = new Create_Inactivate_Offices();
            FormLoader.Show();
        }

        //(5)Create_Dispose_Assets.cs
        private void Create_Dispose_Assets_Click(object sender, EventArgs e)
        {
            Create_Dispose_Assets FormLoader = new Create_Dispose_Assets();
            FormLoader.Show();
        }

        //**(SECTION 2 - CREATION SCREENS - END)**//

        //**TEST DB*//
        private void Test_Database_Connection_Button_Click(object sender, EventArgs e)
        {
            //(Code Block 1 - START) - Establishing A Connection With The SQL Server Database
            //(Code Block 1.1) - SQL Connection String Intilization
            String SQLConnectionString;

            //(Code Block 1.2) - SQL Connection String Assigned Database Connection String Information
            //SQLConnectionString = "Data Source=MORRESEMORRDED3;Initial Catalog=BIS345;Integrated Security=True;MultipleActiveResultSets=True";

            SQLConnectionString = "Server=tcp:peircecollegecapstone.database.windows.net,1433; Database = wats; User ID = rese298; Password = password01!; Trusted_Connection = False; Encrypt = True";
            //(Code Block 1.3) - Create An Object Of Type SqlConnection Named "SQLConnectionObject", Fed SQLConnectionString As The Parameter
            SqlConnection SQLConnectionObject = new SqlConnection(SQLConnectionString);



            //#EXCEPTION 1 START//

            try
            {
                //(Code Block 1.4) - The Connection Method Is Utilized To Create Open The Connection With The SQL Server Database
                SQLConnectionObject.Open();
                MessageBox.Show("Database Connection Test Is Successful!");
                //(Code Block 1 - END)//
            }


            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Error With Connecting To The Database, Please Contact Your System Administrator Before Starting The Application Again");
                System.Windows.Forms.Application.Exit();

            }

            //#EXCEPTION 1 END//
        }


    }
}
