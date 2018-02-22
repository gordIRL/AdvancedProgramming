using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotTipster.HotTipsterWinForms
{
    public partial class StartWinForm : Form
    {
        public StartWinForm()
        {
            InitializeComponent();
            grpbCreateNewHorseBet.Enabled = false;
        }

        // Initialize list for Horsebets & for NewAdditions (unsaved changes)
        public static List<HorseBet> ListOfHorseBets = new List<HorseBet>();
        public static List<HorseBet> NewAdditionsToHorseBetList = new List<HorseBet>();        

        private void btnLoadDefaultData_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ImportDefaultData.ImportData";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();
            lstDefaultData.Items.Clear();

            try
            {
                // Load data into a tempory list
                List<HorseBet> tempHorsebetList = new List<HorseBet>(ImportDefaultData.ImportData());

                // Iterate through tempory list & add data to both lists 
                // for 1)Reports & 2) to enable saving to binary file
                foreach (var item in tempHorsebetList)
                {
                    ListOfHorseBets.Add(item);
                    NewAdditionsToHorseBetList.Add(item);
                }
                lblCurrentStatus.Text = "Default data loaded to memory.";
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 1 - ListOfHorseBets = ImportDefaultData.ImportData()";
            }
        }

        private void viewCurrentHorseBetList_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ViewCurrentHorseBetList";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();

            lstDefaultData.Items.Clear();
            try
            {
                // Alert user if HorseBet List is empty
                if (ListOfHorseBets.Count == 0)
                    lstDefaultData.Items.Add("HorseBet List Status: Empty");

                // Display list if it contains data
                foreach (var HorseBet in ListOfHorseBets)
                {
                    lstDefaultData.Items.Add(HorseBet);
                }
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 3 - View current HorseBet list (in memory)";
            }
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            lstDefaultData.Items.Clear();
            lblCurrentStatus.Text = "Display Cleared";
        }

        private void btnLoadHorseBetListFromBinaryFile_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "MyFileIO.ReadFromBinaryFile";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();
            lstDefaultData.Items.Clear();           

            try
            {
                // Read in ListOfHorseBets from Binary file
                ListOfHorseBets = MyFileIO.ReadFromBinaryFile();   
                if (ListOfHorseBets.Count == 0)
                {
                    lstDefaultData.Items.Add("Binary file is currently empty");
                }
                lstDefaultData.Items.Add("Binary File Loaded");
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 2 - Load HorseBet list from BinaryFile";
            }            
        }

        private void btnGetMostPopularRaceCourse_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ReportingMethods.GetMostPopularRaceCourse";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();
            try
            {
                lstDisplayReports.Items.Add(ReportingMethods.GetMostPopularRaceCourse(ListOfHorseBets));                
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 7 ) - Please load in default data before running report queries.";
            }           
        }

        private void btnWinLossBreakdownByYear_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ReportingMethods.GetAnnualResult";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();
            try
            {
                if (ListOfHorseBets.Count == 0)
                {
                    lblErrorMessage.Text = "Error Option 8 ) - Please load in default data before running report queries.";                    
                }

                // Create a list of type int to store the result of ListOfYears query
                List<int> ListOfYears = ReportingMethods.ListOfYears(ListOfHorseBets);

                // Iterate through ListOfYears & for each year & 
                // Call GetAnnualResult method on ListOfHorseBets & win/lose bool
                foreach (var bettingYear in ListOfYears)
                {
                    lstDisplayReports.Items.Add(ReportingMethods.GetAnnualResult(ListOfHorseBets, bettingYear, true));
                    lstDisplayReports.Items.Add(ReportingMethods.GetAnnualResult(ListOfHorseBets, bettingYear, false));
                }// end foreach                
            }// end try
            catch
            {
                lblErrorMessage.Text = "Error Option 8 ) - Please load in default data before running report queries.";
            }
        }

        private void btnDisplayBetsInDateOrder_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ReportingMethods.DisplayAllBetsInDateOrder";
            lstDisplayReports.Items.Clear();
            lblErrorMessage.Text = "";

            try
            {
                if (ListOfHorseBets.Count == 0)
                {
                    lblErrorMessage.Text = "Error Option 9 ) - Please load in default data before running report queries.";
                }

                // Get list of bets in date order & store in a new list 'BetsInDateOrder'
                List<HorseBet> BetsInDateOrder = ReportingMethods.DisplayAllBetsInDateOrder(ListOfHorseBets);

                lstDisplayReports.Items.Add("Bets in date order - oldest to newest:");
                lstDisplayReports.Items.Add("");
                // Display list
                foreach (var item in BetsInDateOrder)
                {
                    lstDisplayReports.Items.Add(item);
                }// end foreach               
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 9 - Please load in default data before running report queries.";
            }            
        }

        private void btnClearReportsDisplay_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            lblCurrentStatus.Text = "";
            lstDisplayReports.Items.Clear();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHighestAmountWonOrLostOnARace_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ReportingMethods.HighestAmountWonOrLostOnARace";
            lstDisplayReports.Items.Clear();
            lblErrorMessage.Text = "";

            try
            {
                if (ListOfHorseBets.Count == 0)
                {
                    lblErrorMessage.Text = "Error Option 10 ) - Please load in default data before running report queries.";
                }

                // Greatest amount won or lost on a race
                lstDisplayReports.Items.Add("Highest Amount Won Query:");
                lstDisplayReports.Items.Add(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, true)); // wins
                lstDisplayReports.Items.Add("");
                lstDisplayReports.Items.Add("Highest Amount Lost Query:");
                lstDisplayReports.Items.Add(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, false)); // loses                 
            }
            catch
            {
                lstDisplayReports.Items.Add("Error - Option 10 - Please load in default data before running report queries.");
            }
           
        }

        private void btnSuccessLevel_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "ReportingMethods.HotTipsterSuccessLevel";
            lstDisplayReports.Items.Clear();
            lblErrorMessage.Text = "";

            try
            {               
                lstDisplayReports.Items.Add(ReportingMethods.HotTipsterSuccessLevel(ListOfHorseBets));
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 11 - Please load in default data before running report queries.";
            }            
        }

        private void btnClearDataFromMemory_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "Clear all data from memory";
            lstDisplayReports.Items.Clear();
            lblErrorMessage.Text = "";
            try
            {               
                ListOfHorseBets.Clear();
                NewAdditionsToHorseBetList.Clear();
                lstDisplayReports.Items.Add("All data has been cleared from memory.");
                lstDefaultData.Items.Clear();
            }
            catch
            {
                lstDisplayReports.Items.Add("Error - Option 13 - Clear all data from memory");
            }            
        }  

        private void btnSubmitHorseBet_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "Create a new HorseBet";
            lstDefaultData.Items.Clear();
            lstDisplayReports.Items.Clear();
            lblErrorMessage.Text = "";          
            
            string tempRaceCourse = txtRaceCourse.Text;
            DateTime tempDate = (dateTimePicker1.Value);
            decimal.TryParse(txtAmountWonOrLost.Text, out decimal tempAmountWonOrLost);
            bool tempWinOrLose = true; 
            if (rdbWin.Checked)
                tempWinOrLose = true;
            else tempWinOrLose = false;

            HorseBet tempHorseBet = new HorseBet(tempRaceCourse, tempDate,
                        tempAmountWonOrLost, tempWinOrLose);

            // Add to ListOfHorseBets (for display purposes & to be included in Reports queries)
            ListOfHorseBets.Add(tempHorseBet);

            // Add to NewAdditionsToHorseBetList (to enable save updates & changes to binary file)
            NewAdditionsToHorseBetList.Add(tempHorseBet);

            lstDefaultData.Items.Add("New HorseBet created");
            lstDisplayReports.Items.Add(tempHorseBet);

            // clear user input textboxes
            txtAmountWonOrLost.Clear();
            txtRaceCourse.Clear();
            rdbLoss.Checked = true;
            rdbWin.Checked = false;
            dateTimePicker1.Refresh();

            txtAmountWonOrLost.Clear();
            txtRaceCourse.Clear();
            rdbWin.Checked = true;
            grpbCreateNewHorseBet.Enabled = false;
        }

        private void btnSaveChangesToBinaryFile_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            lblCurrentStatus.Text = " MyFileIO.WriteToBinaryFile";
            lstDisplayReports.Items.Clear();
            lstDefaultData.Items.Clear();

            try
            {
                if (NewAdditionsToHorseBetList.Count > 0)
                {
                    // Write out ListOfHorseBets To Binary file                    
                    MyFileIO.WriteToBinaryFile(NewAdditionsToHorseBetList);
                    lstDefaultData.Items.Add("NewAdditions have been written to BinaryFile");

                    // Clear NewAdditions list and alert user
                    NewAdditionsToHorseBetList.Clear();
                    lstDefaultData.Items.Add("NewAdditions is now empty.");
                }
                else
                {
                    lstDefaultData.Items.Add("There is no unsaved data to save.");
                }               
            }// end try
            catch
            {
                lstDisplayReports.Items.Add("Error - Option 6 - Save NewAdditionsToHorseBetList to BinaryFile - DATA NOT SAVED");
                lstDisplayReports.Items.Add("\nFile.Delete error “The process cannot access the file because it is being used by another process”");
                lstDisplayReports.Items.Add("Occurs after deleting the binary file & then trying to save to it again.");
            }
        }

        private void txtRaceCourse_Validating(object sender, CancelEventArgs e)
        {
            bool can = false;
            if (string.IsNullOrEmpty(txtRaceCourse.Text))
            {
                MessageBox.Show("Enter a racecourse name.");
                can = true;
                ep1.SetError(txtRaceCourse, "Enter a racecourse name.");
            }// end if
            e.Cancel = can;               
        }// end validating

        private void txtRaceCourse_Validated(object sender, EventArgs e)
        {
            ep1.Clear();
        }

        private void btnCreateHorseBet_Click(object sender, EventArgs e)
        {
            grpbCreateNewHorseBet.Enabled = true;
            txtRaceCourse.Focus();
        }

        private void txtAmountWonOrLost_Validating(object sender, CancelEventArgs e)
        {
            bool can = false;
            if (!decimal.TryParse(txtAmountWonOrLost.Text, out decimal tempAmount))
            {
                txtAmountWonOrLost.Focus();
                MessageBox.Show("Enter a number");
                can = true;
                //txtRaceCourse.Focus();
                ep1.SetError(txtAmountWonOrLost, "Enter a number");
                txtAmountWonOrLost.Clear();
            }// end if
            e.Cancel = can;
        }

        private void txtAmountWonOrLost_Validated(object sender, EventArgs e)
        {
            ep1.Clear();
        }

        private void btnDiscardHorseBet_Click(object sender, EventArgs e)
        {
            txtAmountWonOrLost.Clear();
            txtRaceCourse.Clear();
            rdbLoss.Checked = true;
            rdbWin.Checked = false;
            dateTimePicker1.Refresh();

            grpbCreateNewHorseBet.Enabled = false;
        }

        private void btnViewNewAdditionsListUnsavedChanges_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "NewAdditionsToHorseBetList";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();            

            try
            {               
                // Alert user if HorseBet List is empty
                if (NewAdditionsToHorseBetList.Count == 0)
                    lstDisplayReports.Items.Add("New Additions HorseBet List Status: Empty");
                else
                {
                    lstDisplayReports.Items.Add("Unsaved Changes:");
                    lstDisplayReports.Items.Add("");
                    // Display list if it contains data
                    foreach (var HorseBet in NewAdditionsToHorseBetList)
                    {
                        lstDisplayReports.Items.Add(HorseBet);
                    }
                }               
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 5 - View New Additions to HorseBet list (unsaved changes)";
            }
        }

        private void btnDeleteBinaryFile_Click(object sender, EventArgs e)
        {
            lblCurrentStatus.Text = "MyFileIO.DeleteBinaryFile";
            lblErrorMessage.Text = "";
            lstDisplayReports.Items.Clear();
            lstDefaultData.Items.Clear();
            try
            {
                MyFileIO.DeleteBinaryFile();
                lblErrorMessage.Text = "Binary file has been deleted.";                
            }
            catch
            {
                lblErrorMessage.Text = "Error - Option 12 - MyFileIO.DeleteBinaryFile()";
            }
        }
    }
}
