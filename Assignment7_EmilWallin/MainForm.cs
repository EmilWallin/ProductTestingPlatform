using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

//Project created by Emil Wallin on 2020-12-14

namespace Assignment7_EmilWallin
{
    public partial class testingForm : Form
    {
        private InquiryAndReportManager inquiryAndReportManager;
        private TestStandardsManager testManager;
        public testingForm()
        {
            InitializeComponent();
            InitializeManagers();
        }

        private void InitializeManagers()
        {
            inquiryAndReportManager = new InquiryAndReportManager();
            testManager = new TestStandardsManager();
            LoadSavedData();
            UpdateListBoxes();
        }



        //PENDING BUTTON METHODS
        //New inquiry
        private void btnNewInquiry_Click(object sender, EventArgs e)
        {
            InquiryForm inquiryForm = new InquiryForm(testManager);

            DialogResult result = inquiryForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                testManager = inquiryForm.NewTestManager;
                inquiryAndReportManager.AddInquiry(inquiryForm.TestCode, inquiryForm.WorkingInquiry.InquiryNotes, inquiryForm.InqProductName, inquiryForm.ProductCode);
            }
            testManager = inquiryForm.NewTestManager;

            UpdateListBoxes();
        }

        //Edit Existing Inquiry
        private void btnEditInquiry_Click(object sender, EventArgs e)
        {
            int inquiryID = ChosenPendingInt();
            if (inquiryID < 0)
            { return; }

            InquiryAndReport tempInqAndRep = inquiryAndReportManager.GetData(inquiryID);

            InquiryForm inquiryForm = new InquiryForm(testManager, tempInqAndRep.GetInquiry, tempInqAndRep.ProductCode, tempInqAndRep.ProductName, true);
            DialogResult result = inquiryForm.ShowDialog();


            if (result == DialogResult.OK)
            {
                inquiryAndReportManager.EditInquiry(inquiryID, inquiryForm.TestCode, inquiryForm.WorkingInquiry, inquiryForm.ProductCode, inquiryForm.InqProductName);
            }
            testManager = inquiryForm.NewTestManager;

            UpdateListBoxes();
        }

        //Open Inquiry
        private void btnOpenPendingInquiry_Click(object sender, EventArgs e)
        {
            int inquiryID = ChosenPendingInt();
            if (inquiryID < 0)
            { return; }

            InquiryAndReport tempInqAndRep = inquiryAndReportManager.GetData(inquiryID);

            InquiryForm inquiryForm = new InquiryForm(testManager, tempInqAndRep.GetInquiry, tempInqAndRep.ProductCode, tempInqAndRep.ProductName, false);
            inquiryForm.ShowDialog();
        }

        //Add Report to chosen inquiry
        private void btnAddReport_Click(object sender, EventArgs e)
        {
            int inquiryID = ChosenPendingInt();
            if(inquiryID < 0)
            { return; }

            InquiryAndReport tempInqAndRep = inquiryAndReportManager.GetData(inquiryID);

            ReportForm reportForm = new ReportForm(inquiryID, tempInqAndRep, testManager);
            DialogResult result = reportForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                inquiryAndReportManager.AddReport(inquiryID, reportForm.WorkingReport);
            }

            UpdateListBoxes();
        }

        //Delete Inquiry btn click method
        private void btnDeleteInquiry_Click(object sender, EventArgs e)
        {
            if(ChosenPendingInt() < 0)
            { return; }

            DialogResult result = MessageBox.Show("You are about to delete this inquiry.\nAre you sure?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if(result != DialogResult.Yes)
            { return; }

            inquiryAndReportManager.RemoveEntry(ChosenPendingInt());
            UpdateListBoxes();
        }



        //View test standards button
        private void btnViewTestStandards_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(testManager);
            testForm.ShowDialog();

            testManager = testForm.TestManager;
        }



        //COMPLETED BUTTON METHODS
        //Open completed report
        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            int inquiryID = ChosenCompletedInt();
            if (inquiryID < 0)
            { return; }

            InquiryAndReport tempInqAndRep = inquiryAndReportManager.GetData(inquiryID);

            ReportForm reportForm = new ReportForm(inquiryID, false, tempInqAndRep, testManager);
            DialogResult result = reportForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                inquiryAndReportManager.AddReport(inquiryID, reportForm.WorkingReport);
            }
        }

        //Open completed inquiry
        private void btnOpenCompletedInquiry_Click(object sender, EventArgs e)
        {
            int inquiryID = ChosenCompletedInt();
            if (inquiryID < 0)
            { return; }

            InquiryAndReport tempInqAndRep = inquiryAndReportManager.GetData(inquiryID);

            InquiryForm inquiryForm = new InquiryForm(testManager, tempInqAndRep.GetInquiry, tempInqAndRep.ProductCode, tempInqAndRep.ProductName, false);
            inquiryForm.ShowDialog();
        }

        //Edit completed report
        private void btnEditReport_Click(object sender, EventArgs e)
        {
            int inquiryID = ChosenCompletedInt();
            if (inquiryID < 0)
            { return; }

            InquiryAndReport tempInqAndRep = inquiryAndReportManager.GetData(inquiryID);

            ReportForm reportForm = new ReportForm(inquiryID, true, tempInqAndRep, testManager);
            DialogResult result = reportForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                inquiryAndReportManager.EditReport(inquiryID, reportForm.WorkingReport);
            }
            UpdateListBoxes();
        }



        //Gets the chosen value in the pending listbox
        private int ChosenPendingInt()
        {
            if (listBoxPending.SelectedIndex <= -1)
            {
                return -1;
            }

            return inquiryAndReportManager.GetID(listBoxPending.SelectedIndex, false);
        }

        //Gets the chosen value in the completed listbox
        private int ChosenCompletedInt()
        {
            if (listBoxPending.SelectedIndex <= -1)
            {
                return -1;
            }

            return inquiryAndReportManager.GetID(listBoxCompleted.SelectedIndex, true);
        }

        //Changes to the chosen index in the pending listbox
        private void listBoxPending_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPending.SelectedIndex > -1)
            {
                btnEditInquiry.Enabled = true;
                btnOpenPendingInquiry.Enabled = true;
                btnAddReport.Enabled = true;
            }
            else
            {
                btnEditInquiry.Enabled = false;
                btnOpenPendingInquiry.Enabled = false;
                btnAddReport.Enabled = false;
            }
        }
        //Updates listboxes with strings compiled in the inquiry and report manager
        private void UpdateListBoxes()
        {
            listBoxPending.DataSource = inquiryAndReportManager.CompilePendingList("");
            listBoxCompleted.DataSource = inquiryAndReportManager.CompileCompletedList("");
        }


        //Saving and loading using simple binary formatting

        //Save test standards clicked method
        private void saveTestStandardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTestStandards();
        }
        //Save Inquiries clicked method
        private void saveInquiriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInquiries();
        }


        //Loads both test and inquiriess
        private void LoadSavedData()
        {
            IFormatter formatter = new BinaryFormatter();

            if (File.Exists("TestStandards.Data"))
            {
                using (FileStream stream = File.OpenRead("TestStandards.Data"))
                {
                    testManager = (TestStandardsManager)formatter.Deserialize(stream);
                }
            }

            if (File.Exists("Inquiries.Data"))
            {
                using (FileStream stream = File.OpenRead("Inquiries.Data"))
                {
                    inquiryAndReportManager = (InquiryAndReportManager)formatter.Deserialize(stream);
                }
            }
        }

        //Save test standard method
        private void SaveTestStandards()
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("TestStandards.Data"))
            {
                formatter.Serialize(stream, testManager);
            }
        }
        //Save inquiries method
        private void SaveInquiries()
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("Inquiries.Data"))
            {
                formatter.Serialize(stream, inquiryAndReportManager);
            }
        }

        //When the form is closing, saves progress automatically
        private void testingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTestStandards();
            SaveInquiries();
        }

        //About menu item. Opens aboutbox
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }


    }
}
