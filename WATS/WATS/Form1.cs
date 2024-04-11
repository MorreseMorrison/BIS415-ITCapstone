using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        
    }
}
