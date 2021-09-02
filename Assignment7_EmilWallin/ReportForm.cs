using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_EmilWallin
{
    public partial class ReportForm : Form
    {
        private Report workingReport;
        private int workingID;
        private InquiryAndReport workingInqAndRep;
        private TestStandardsManager workingTestManager;
        private bool isEditing;
        private bool hasBeenEdited;

        //Open clean report form
        public ReportForm(int ID, InquiryAndReport inqAndRep, TestStandardsManager testManager) : this(ID, true, inqAndRep, testManager)
        { }

        //Open/edit Form
        public ReportForm(int ID, bool isEdit, InquiryAndReport inqAndRep, TestStandardsManager testManager)
        {
            InitializeComponent();
            workingInqAndRep = inqAndRep;
            workingReport = workingInqAndRep.GetReport;
            workingTestManager = testManager;
            FillComboBox();

            
            workingID = ID;

            textBoxProductName.Text = workingInqAndRep.ProductName;
            textBoxProductCode.Text = workingInqAndRep.ProductCode.ToString();

            textBoxTestNotes.Text = workingReport.TestNotes;
            textBoxAdditionalComments.Text = workingReport.AdditionalComments;
            comboBoxResult.SelectedIndex = workingReport.Result;

            EditableForm(isEdit);
            hasBeenEdited = false;
        }


        //Filling combobox and removing underscores
        private void FillComboBox()
        {
            int numOfResults = Enum.GetNames(typeof(Results)).Length;

            for (int i = 0; i < numOfResults; i++)
            {
                string result = Enum.GetName(typeof(Results), i);
                result.Replace("_", " ");
                comboBoxResult.Items.Add(result);
            }
        }

        //OK Click method, closes the form
        private void btnOk_Click(object sender, EventArgs e)
        {
            workingReport.TestNotes = textBoxTestNotes.Text;
            workingReport.AdditionalComments = textBoxAdditionalComments.Text;
            workingReport.Result = comboBoxResult.SelectedIndex;
            Close();
        }

        //Cancel click method, checks with user before closing the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(isEditing && hasBeenEdited)
            {
                var result = MessageBox.Show("You are about to discard this report, or the changes to this report.\nIs that OK?", "Discard Changes?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    btnCancel.DialogResult = DialogResult.Cancel;
                    Close();
                }
            } else
            {
                Close();
            }
        }


        //Open inquiry click method, opens the inquiry the user is currently reporting on
        private void btnOpenInquiry_Click(object sender, EventArgs e)
        {
            InquiryForm inquiryForm = new InquiryForm(workingTestManager, workingInqAndRep.GetInquiry, workingInqAndRep.ProductCode, workingInqAndRep.ProductName, false);
            inquiryForm.ShowDialog();
        }

        //Activate or deactivate form components
        private void EditableForm(bool isEditable)
        {
            if (isEditable)
            {
                isEditing = true;

                btnOk.Enabled = true;
                comboBoxResult.Enabled = true;
                textBoxTestNotes.ReadOnly = false;
                textBoxAdditionalComments.ReadOnly = false;

                btnCancel.DialogResult = DialogResult.Cancel;
                btnCancel.Text = "Cancel";
            }
            else
            {
                isEditing = false;

                btnOk.Enabled = false;
                comboBoxResult.Enabled = false;
                textBoxTestNotes.ReadOnly = true;
                textBoxAdditionalComments.ReadOnly = true;

                btnCancel.DialogResult = DialogResult.None;
                btnCancel.Text = "Close";
            }
        }

        //Calls inputcheck method to check valid inputs
        private void textBoxTestNotes_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            InputCheck();
        }

        //Calls inputcheck method to check valid inputs
        private void comboBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            InputCheck();
        }

        //Calls inputcheck whenever the additional comments textbox is changed
        private void textBoxAdditionalComments_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            InputCheck();
        }


        //Checks inputs and enables or disables the OK-button depending on if the textbox for notes and the combobox have text/are valid
        private void InputCheck()
        {
            bool validTextBox = false;
            bool validComboBox = false;

            if (textBoxTestNotes.Text != string.Empty)
            {
                validTextBox = true;
            }
            else
            {
                validTextBox = false;
            }

            if (comboBoxResult.SelectedIndex >= 0)
            {
                validComboBox = true;
            }
            else
            {
                validComboBox = false;
            }

            if (validComboBox && validTextBox)
            {
                btnOk.Enabled = true;
            } else
            {
                btnOk.Enabled = false;
            }
        }

        //PROPERTIES
        public Report WorkingReport
        {
            get { return workingReport; }
            set { workingReport = value; }
        }


    }
}
