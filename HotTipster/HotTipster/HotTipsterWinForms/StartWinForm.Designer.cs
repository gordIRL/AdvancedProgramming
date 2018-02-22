namespace HotTipster.HotTipsterWinForms
{
    partial class StartWinForm
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
            this.btnLoadDefaultData = new System.Windows.Forms.Button();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lstDefaultData = new System.Windows.Forms.ListBox();
            this.btnviewCurrentHorseBetList = new System.Windows.Forms.Button();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.btnLoadHorseBetListFromBinaryFile = new System.Windows.Forms.Button();
            this.btnGetMostPopularRaceCourse = new System.Windows.Forms.Button();
            this.lstDisplayReports = new System.Windows.Forms.ListBox();
            this.btnWinLossBreakdownByYear = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnDisplayBetsInDateOrder = new System.Windows.Forms.Button();
            this.btnClearReportsDisplay = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.btnHighestAmountWonOrLostOnARace = new System.Windows.Forms.Button();
            this.btnSuccessLevel = new System.Windows.Forms.Button();
            this.btnClearDataFromMemory = new System.Windows.Forms.Button();
            this.grpbCreateNewHorseBet = new System.Windows.Forms.GroupBox();
            this.btnDiscardHorseBet = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitHorseBet = new System.Windows.Forms.Button();
            this.rdbLoss = new System.Windows.Forms.RadioButton();
            this.rdbWin = new System.Windows.Forms.RadioButton();
            this.txtAmountWonOrLost = new System.Windows.Forms.TextBox();
            this.lblAmountWonOrLost = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtRaceCourse = new System.Windows.Forms.TextBox();
            this.lblRaceCourse = new System.Windows.Forms.Label();
            this.btnSaveChangesToBinaryFile = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCreateHorseBet = new System.Windows.Forms.Button();
            this.btnViewNewAdditionsListUnsavedChanges = new System.Windows.Forms.Button();
            this.btnDeleteBinaryFile = new System.Windows.Forms.Button();
            this.grpbCreateNewHorseBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadDefaultData
            // 
            this.btnLoadDefaultData.Location = new System.Drawing.Point(16, 187);
            this.btnLoadDefaultData.Name = "btnLoadDefaultData";
            this.btnLoadDefaultData.Size = new System.Drawing.Size(75, 62);
            this.btnLoadDefaultData.TabIndex = 0;
            this.btnLoadDefaultData.Text = "Load Default Data";
            this.btnLoadDefaultData.UseVisualStyleBackColor = true;
            this.btnLoadDefaultData.Click += new System.EventHandler(this.btnLoadDefaultData_Click);
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(14, 9);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(40, 13);
            this.lblCurrentStatus.TabIndex = 30;
            this.lblCurrentStatus.Text = "Status:";
            // 
            // lstDefaultData
            // 
            this.lstDefaultData.FormattingEnabled = true;
            this.lstDefaultData.Location = new System.Drawing.Point(16, 34);
            this.lstDefaultData.Name = "lstDefaultData";
            this.lstDefaultData.Size = new System.Drawing.Size(395, 134);
            this.lstDefaultData.TabIndex = 31;
            // 
            // btnviewCurrentHorseBetList
            // 
            this.btnviewCurrentHorseBetList.Location = new System.Drawing.Point(237, 187);
            this.btnviewCurrentHorseBetList.Name = "btnviewCurrentHorseBetList";
            this.btnviewCurrentHorseBetList.Size = new System.Drawing.Size(75, 62);
            this.btnviewCurrentHorseBetList.TabIndex = 2;
            this.btnviewCurrentHorseBetList.Text = "View Current HorseBet List (in memory)";
            this.btnviewCurrentHorseBetList.UseVisualStyleBackColor = true;
            this.btnviewCurrentHorseBetList.Click += new System.EventHandler(this.viewCurrentHorseBetList_Click);
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(336, 187);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(75, 62);
            this.btnClearDisplay.TabIndex = 3;
            this.btnClearDisplay.Text = "Clear Display";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // btnLoadHorseBetListFromBinaryFile
            // 
            this.btnLoadHorseBetListFromBinaryFile.Location = new System.Drawing.Point(130, 187);
            this.btnLoadHorseBetListFromBinaryFile.Name = "btnLoadHorseBetListFromBinaryFile";
            this.btnLoadHorseBetListFromBinaryFile.Size = new System.Drawing.Size(75, 62);
            this.btnLoadHorseBetListFromBinaryFile.TabIndex = 1;
            this.btnLoadHorseBetListFromBinaryFile.Text = "Load From Binary File";
            this.btnLoadHorseBetListFromBinaryFile.UseVisualStyleBackColor = true;
            this.btnLoadHorseBetListFromBinaryFile.Click += new System.EventHandler(this.btnLoadHorseBetListFromBinaryFile_Click);
            // 
            // btnGetMostPopularRaceCourse
            // 
            this.btnGetMostPopularRaceCourse.Location = new System.Drawing.Point(457, 187);
            this.btnGetMostPopularRaceCourse.Name = "btnGetMostPopularRaceCourse";
            this.btnGetMostPopularRaceCourse.Size = new System.Drawing.Size(75, 62);
            this.btnGetMostPopularRaceCourse.TabIndex = 7;
            this.btnGetMostPopularRaceCourse.Text = "MostPopularRaceCourse";
            this.btnGetMostPopularRaceCourse.UseVisualStyleBackColor = true;
            this.btnGetMostPopularRaceCourse.Click += new System.EventHandler(this.btnGetMostPopularRaceCourse_Click);
            // 
            // lstDisplayReports
            // 
            this.lstDisplayReports.FormattingEnabled = true;
            this.lstDisplayReports.Location = new System.Drawing.Point(457, 34);
            this.lstDisplayReports.Name = "lstDisplayReports";
            this.lstDisplayReports.Size = new System.Drawing.Size(459, 134);
            this.lstDisplayReports.TabIndex = 33;
            // 
            // btnWinLossBreakdownByYear
            // 
            this.btnWinLossBreakdownByYear.Location = new System.Drawing.Point(552, 187);
            this.btnWinLossBreakdownByYear.Name = "btnWinLossBreakdownByYear";
            this.btnWinLossBreakdownByYear.Size = new System.Drawing.Size(75, 62);
            this.btnWinLossBreakdownByYear.TabIndex = 8;
            this.btnWinLossBreakdownByYear.Text = "Win / Loss Breakdown By Year";
            this.btnWinLossBreakdownByYear.UseVisualStyleBackColor = true;
            this.btnWinLossBreakdownByYear.Click += new System.EventHandler(this.btnWinLossBreakdownByYear_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(454, 9);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.lblErrorMessage.TabIndex = 32;
            this.lblErrorMessage.Text = "ErrorMessage:";
            // 
            // btnDisplayBetsInDateOrder
            // 
            this.btnDisplayBetsInDateOrder.Location = new System.Drawing.Point(646, 187);
            this.btnDisplayBetsInDateOrder.Name = "btnDisplayBetsInDateOrder";
            this.btnDisplayBetsInDateOrder.Size = new System.Drawing.Size(79, 62);
            this.btnDisplayBetsInDateOrder.TabIndex = 9;
            this.btnDisplayBetsInDateOrder.Text = "Display Bets In Date Order (oldest to newest)";
            this.btnDisplayBetsInDateOrder.UseVisualStyleBackColor = true;
            this.btnDisplayBetsInDateOrder.Click += new System.EventHandler(this.btnDisplayBetsInDateOrder_Click);
            // 
            // btnClearReportsDisplay
            // 
            this.btnClearReportsDisplay.Location = new System.Drawing.Point(646, 264);
            this.btnClearReportsDisplay.Name = "btnClearReportsDisplay";
            this.btnClearReportsDisplay.Size = new System.Drawing.Size(79, 62);
            this.btnClearReportsDisplay.TabIndex = 12;
            this.btnClearReportsDisplay.Text = "Clear Reports Display";
            this.btnClearReportsDisplay.UseVisualStyleBackColor = true;
            this.btnClearReportsDisplay.Click += new System.EventHandler(this.btnClearReportsDisplay_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(822, 264);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(94, 64);
            this.btnExitApplication.TabIndex = 14;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // btnHighestAmountWonOrLostOnARace
            // 
            this.btnHighestAmountWonOrLostOnARace.Location = new System.Drawing.Point(457, 264);
            this.btnHighestAmountWonOrLostOnARace.Name = "btnHighestAmountWonOrLostOnARace";
            this.btnHighestAmountWonOrLostOnARace.Size = new System.Drawing.Size(75, 62);
            this.btnHighestAmountWonOrLostOnARace.TabIndex = 10;
            this.btnHighestAmountWonOrLostOnARace.Text = "Highest Amount Won Or Lost";
            this.btnHighestAmountWonOrLostOnARace.UseVisualStyleBackColor = true;
            this.btnHighestAmountWonOrLostOnARace.Click += new System.EventHandler(this.btnHighestAmountWonOrLostOnARace_Click);
            // 
            // btnSuccessLevel
            // 
            this.btnSuccessLevel.Location = new System.Drawing.Point(552, 264);
            this.btnSuccessLevel.Name = "btnSuccessLevel";
            this.btnSuccessLevel.Size = new System.Drawing.Size(75, 62);
            this.btnSuccessLevel.TabIndex = 11;
            this.btnSuccessLevel.Text = "Success Level";
            this.btnSuccessLevel.UseVisualStyleBackColor = true;
            this.btnSuccessLevel.Click += new System.EventHandler(this.btnSuccessLevel_Click);
            // 
            // btnClearDataFromMemory
            // 
            this.btnClearDataFromMemory.Location = new System.Drawing.Point(17, 262);
            this.btnClearDataFromMemory.Name = "btnClearDataFromMemory";
            this.btnClearDataFromMemory.Size = new System.Drawing.Size(75, 62);
            this.btnClearDataFromMemory.TabIndex = 4;
            this.btnClearDataFromMemory.Text = "Clear Data from Memory";
            this.btnClearDataFromMemory.UseVisualStyleBackColor = true;
            this.btnClearDataFromMemory.Click += new System.EventHandler(this.btnClearDataFromMemory_Click);
            // 
            // grpbCreateNewHorseBet
            // 
            this.grpbCreateNewHorseBet.Controls.Add(this.btnDiscardHorseBet);
            this.grpbCreateNewHorseBet.Controls.Add(this.dateTimePicker1);
            this.grpbCreateNewHorseBet.Controls.Add(this.btnSubmitHorseBet);
            this.grpbCreateNewHorseBet.Controls.Add(this.rdbLoss);
            this.grpbCreateNewHorseBet.Controls.Add(this.rdbWin);
            this.grpbCreateNewHorseBet.Controls.Add(this.txtAmountWonOrLost);
            this.grpbCreateNewHorseBet.Controls.Add(this.lblAmountWonOrLost);
            this.grpbCreateNewHorseBet.Controls.Add(this.lblDate);
            this.grpbCreateNewHorseBet.Controls.Add(this.txtRaceCourse);
            this.grpbCreateNewHorseBet.Controls.Add(this.lblRaceCourse);
            this.grpbCreateNewHorseBet.Location = new System.Drawing.Point(103, 356);
            this.grpbCreateNewHorseBet.Name = "grpbCreateNewHorseBet";
            this.grpbCreateNewHorseBet.Size = new System.Drawing.Size(746, 100);
            this.grpbCreateNewHorseBet.TabIndex = 16;
            this.grpbCreateNewHorseBet.TabStop = false;
            this.grpbCreateNewHorseBet.Text = "Create New Horse Bet:";
            // 
            // btnDiscardHorseBet
            // 
            this.btnDiscardHorseBet.Location = new System.Drawing.Point(652, 60);
            this.btnDiscardHorseBet.Name = "btnDiscardHorseBet";
            this.btnDiscardHorseBet.Size = new System.Drawing.Size(88, 23);
            this.btnDiscardHorseBet.TabIndex = 22;
            this.btnDiscardHorseBet.Text = "Discard HorseBet";
            this.btnDiscardHorseBet.UseVisualStyleBackColor = true;
            this.btnDiscardHorseBet.Click += new System.EventHandler(this.btnDiscardHorseBet_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // btnSubmitHorseBet
            // 
            this.btnSubmitHorseBet.Location = new System.Drawing.Point(652, 21);
            this.btnSubmitHorseBet.Name = "btnSubmitHorseBet";
            this.btnSubmitHorseBet.Size = new System.Drawing.Size(88, 23);
            this.btnSubmitHorseBet.TabIndex = 21;
            this.btnSubmitHorseBet.Text = "Submit Horsebet";
            this.btnSubmitHorseBet.UseVisualStyleBackColor = true;
            this.btnSubmitHorseBet.Click += new System.EventHandler(this.btnSubmitHorseBet_Click);
            // 
            // rdbLoss
            // 
            this.rdbLoss.AutoSize = true;
            this.rdbLoss.Location = new System.Drawing.Point(434, 66);
            this.rdbLoss.Name = "rdbLoss";
            this.rdbLoss.Size = new System.Drawing.Size(53, 17);
            this.rdbLoss.TabIndex = 20;
            this.rdbLoss.Text = "LOSS";
            this.rdbLoss.UseVisualStyleBackColor = true;
            // 
            // rdbWin
            // 
            this.rdbWin.AutoSize = true;
            this.rdbWin.Checked = true;
            this.rdbWin.Location = new System.Drawing.Point(381, 66);
            this.rdbWin.Name = "rdbWin";
            this.rdbWin.Size = new System.Drawing.Size(47, 17);
            this.rdbWin.TabIndex = 19;
            this.rdbWin.TabStop = true;
            this.rdbWin.Text = "WIN";
            this.rdbWin.UseVisualStyleBackColor = true;
            // 
            // txtAmountWonOrLost
            // 
            this.txtAmountWonOrLost.Location = new System.Drawing.Point(522, 23);
            this.txtAmountWonOrLost.Name = "txtAmountWonOrLost";
            this.txtAmountWonOrLost.Size = new System.Drawing.Size(100, 20);
            this.txtAmountWonOrLost.TabIndex = 17;
            this.txtAmountWonOrLost.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountWonOrLost_Validating);
            this.txtAmountWonOrLost.Validated += new System.EventHandler(this.txtAmountWonOrLost_Validated);
            // 
            // lblAmountWonOrLost
            // 
            this.lblAmountWonOrLost.AutoSize = true;
            this.lblAmountWonOrLost.Location = new System.Drawing.Point(371, 26);
            this.lblAmountWonOrLost.Name = "lblAmountWonOrLost";
            this.lblAmountWonOrLost.Size = new System.Drawing.Size(97, 13);
            this.lblAmountWonOrLost.TabIndex = 3;
            this.lblAmountWonOrLost.Text = "AmountWonOrLost";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(43, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // txtRaceCourse
            // 
            this.txtRaceCourse.Location = new System.Drawing.Point(82, 26);
            this.txtRaceCourse.Name = "txtRaceCourse";
            this.txtRaceCourse.Size = new System.Drawing.Size(272, 20);
            this.txtRaceCourse.TabIndex = 16;
            this.txtRaceCourse.Validating += new System.ComponentModel.CancelEventHandler(this.txtRaceCourse_Validating);
            this.txtRaceCourse.Validated += new System.EventHandler(this.txtRaceCourse_Validated);
            // 
            // lblRaceCourse
            // 
            this.lblRaceCourse.AutoSize = true;
            this.lblRaceCourse.Location = new System.Drawing.Point(7, 29);
            this.lblRaceCourse.Name = "lblRaceCourse";
            this.lblRaceCourse.Size = new System.Drawing.Size(69, 13);
            this.lblRaceCourse.TabIndex = 0;
            this.lblRaceCourse.Text = "RaceCourse:";
            // 
            // btnSaveChangesToBinaryFile
            // 
            this.btnSaveChangesToBinaryFile.Location = new System.Drawing.Point(130, 262);
            this.btnSaveChangesToBinaryFile.Name = "btnSaveChangesToBinaryFile";
            this.btnSaveChangesToBinaryFile.Size = new System.Drawing.Size(75, 62);
            this.btnSaveChangesToBinaryFile.TabIndex = 5;
            this.btnSaveChangesToBinaryFile.Text = "Save Changes To Binary File";
            this.btnSaveChangesToBinaryFile.UseVisualStyleBackColor = true;
            this.btnSaveChangesToBinaryFile.Click += new System.EventHandler(this.btnSaveChangesToBinaryFile_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // btnCreateHorseBet
            // 
            this.btnCreateHorseBet.Location = new System.Drawing.Point(12, 356);
            this.btnCreateHorseBet.Name = "btnCreateHorseBet";
            this.btnCreateHorseBet.Size = new System.Drawing.Size(75, 100);
            this.btnCreateHorseBet.TabIndex = 15;
            this.btnCreateHorseBet.Text = "Create HorseBet";
            this.btnCreateHorseBet.UseVisualStyleBackColor = true;
            this.btnCreateHorseBet.Click += new System.EventHandler(this.btnCreateHorseBet_Click);
            // 
            // btnViewNewAdditionsListUnsavedChanges
            // 
            this.btnViewNewAdditionsListUnsavedChanges.Location = new System.Drawing.Point(237, 262);
            this.btnViewNewAdditionsListUnsavedChanges.Name = "btnViewNewAdditionsListUnsavedChanges";
            this.btnViewNewAdditionsListUnsavedChanges.Size = new System.Drawing.Size(174, 62);
            this.btnViewNewAdditionsListUnsavedChanges.TabIndex = 6;
            this.btnViewNewAdditionsListUnsavedChanges.Text = "View Unsaved Changes  ( to new Additions List )";
            this.btnViewNewAdditionsListUnsavedChanges.UseVisualStyleBackColor = true;
            this.btnViewNewAdditionsListUnsavedChanges.Click += new System.EventHandler(this.btnViewNewAdditionsListUnsavedChanges_Click);
            // 
            // btnDeleteBinaryFile
            // 
            this.btnDeleteBinaryFile.Location = new System.Drawing.Point(822, 187);
            this.btnDeleteBinaryFile.Name = "btnDeleteBinaryFile";
            this.btnDeleteBinaryFile.Size = new System.Drawing.Size(94, 62);
            this.btnDeleteBinaryFile.TabIndex = 13;
            this.btnDeleteBinaryFile.Text = "Delete Binary File";
            this.btnDeleteBinaryFile.UseVisualStyleBackColor = true;
            this.btnDeleteBinaryFile.Click += new System.EventHandler(this.btnDeleteBinaryFile_Click);
            // 
            // StartWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 486);
            this.Controls.Add(this.btnDeleteBinaryFile);
            this.Controls.Add(this.btnViewNewAdditionsListUnsavedChanges);
            this.Controls.Add(this.btnCreateHorseBet);
            this.Controls.Add(this.btnSaveChangesToBinaryFile);
            this.Controls.Add(this.grpbCreateNewHorseBet);
            this.Controls.Add(this.btnClearDataFromMemory);
            this.Controls.Add(this.btnSuccessLevel);
            this.Controls.Add(this.btnHighestAmountWonOrLostOnARace);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnClearReportsDisplay);
            this.Controls.Add(this.btnDisplayBetsInDateOrder);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnWinLossBreakdownByYear);
            this.Controls.Add(this.lstDisplayReports);
            this.Controls.Add(this.btnGetMostPopularRaceCourse);
            this.Controls.Add(this.btnLoadHorseBetListFromBinaryFile);
            this.Controls.Add(this.btnClearDisplay);
            this.Controls.Add(this.btnviewCurrentHorseBetList);
            this.Controls.Add(this.lstDefaultData);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.btnLoadDefaultData);
            this.Name = "StartWinForm";
            this.Text = "Hot Tipster";
            this.grpbCreateNewHorseBet.ResumeLayout(false);
            this.grpbCreateNewHorseBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDefaultData;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.ListBox lstDefaultData;
        private System.Windows.Forms.Button btnviewCurrentHorseBetList;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.Button btnLoadHorseBetListFromBinaryFile;
        private System.Windows.Forms.Button btnGetMostPopularRaceCourse;
        private System.Windows.Forms.ListBox lstDisplayReports;
        private System.Windows.Forms.Button btnWinLossBreakdownByYear;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnDisplayBetsInDateOrder;
        private System.Windows.Forms.Button btnClearReportsDisplay;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Button btnHighestAmountWonOrLostOnARace;
        private System.Windows.Forms.Button btnSuccessLevel;
        private System.Windows.Forms.Button btnClearDataFromMemory;
        private System.Windows.Forms.GroupBox grpbCreateNewHorseBet;
        private System.Windows.Forms.Button btnSubmitHorseBet;
        private System.Windows.Forms.RadioButton rdbLoss;
        private System.Windows.Forms.RadioButton rdbWin;
        private System.Windows.Forms.TextBox txtAmountWonOrLost;
        private System.Windows.Forms.Label lblAmountWonOrLost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtRaceCourse;
        private System.Windows.Forms.Label lblRaceCourse;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSaveChangesToBinaryFile;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Button btnCreateHorseBet;
        private System.Windows.Forms.Button btnDiscardHorseBet;
        private System.Windows.Forms.Button btnViewNewAdditionsListUnsavedChanges;
        private System.Windows.Forms.Button btnDeleteBinaryFile;
    }
}