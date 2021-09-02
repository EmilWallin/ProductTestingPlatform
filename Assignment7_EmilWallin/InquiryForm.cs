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
    public partial class InquiryForm : Form
    {
        private int productCode;
        private string productName;

        private Inquiry workingInquiry = new Inquiry();
        private string workNotes = string.Empty;
        private DateTime workDateTime = DateTime.Now;
        private bool isEditing;
        private bool hasBeenEdited;

        private string testCode;

        private TestStandardsManager testManager;
        private bool newStandard = false;

        //Clean form
        public InquiryForm(TestStandardsManager testManager) :this(testManager, new Inquiry("",DateTime.Now), 00000, "", true)
        {}

        //Constructor (edit calls directly)
        public InquiryForm(TestStandardsManager testManager, Inquiry inquiry, int productCode, string productName, bool isEdit)
        {
            InitializeComponent();

            this.testManager = testManager;
            workNotes = inquiry.InquiryNotes;
            workDateTime = inquiry.DateEntered;

            this.productCode = productCode;
            this.productName = productName;
            hasBeenEdited = false;
            FillTestComboBox();
            FillTextBoxes();

            EditableForm(isEdit);
        }

        //Fills combobox with testcodes
        private void FillTestComboBox()
        {
            comboBoxTestCode.DataSource = testManager.GetCodeList();
        }

        //If the combobox value changes the testDescription and name should change
        private void comboBoxTestCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTestTextBoxes(comboBoxTestCode.SelectedIndex);
            CheckInput();
        }

        //Fills the testtextboxes with the value based on the combobox
        private void FillTestTextBoxes(int index)
        {
            if(index > -1)
            {
                textBoxTestName.Text = testManager.GetTestName(index);
                textBoxTestDescription.Text = testManager.GetTestDescription(index);
            } else
            {
                textBoxTestName.Text = "";
                textBoxTestDescription.Text = "";
            }
        }

        //Fills textboxes when opening a new inquiry
        private void FillTextBoxes()
        {
            if(productCode != 0)
            {
                textBoxProductCode.Text = productCode.ToString();
            } else
            {
                textBoxProductCode.Text = "";
            }

            textBoxProductName.Text = productName;
            textBoxInquiryNotes.Text = workNotes;
        }

        //Checkbox for new standard
        private void checkBoxNewStandard_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNewStandard.Checked)
            {
                comboBoxTestCode.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxTestCode.SelectedIndex = -1;
                textBoxTestName.Text = "";
                textBoxTestDescription.Text = "";

                textBoxTestName.ReadOnly = false;
                textBoxTestDescription.ReadOnly = false;

                newStandard = true;

            } else
            {
                var result = MessageBox.Show("Discard new test standard?", "Discard Standard", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    comboBoxTestCode.DropDownStyle = ComboBoxStyle.DropDownList;
                    textBoxTestName.Text = "";
                    textBoxTestDescription.Text = "";

                    textBoxTestName.ReadOnly = true;
                    textBoxTestDescription.ReadOnly = true;

                    newStandard = false;
                } else
                { checkBoxNewStandard.Checked = true; }
            }
        }

        //OK button click method
        private void btnOk_Click(object sender, EventArgs e)
        {
            productName = textBoxProductName.Text;
            testCode = comboBoxTestCode.Text;
            workingInquiry.InquiryNotes = textBoxInquiryNotes.Text;

            if (newStandard)
            {
                testManager.AddStandard(comboBoxTestCode.Text, textBoxTestName.Text, textBoxTestDescription.Text);
            } 

            Close();
        }

        //Cancel button click method
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isEditing && hasBeenEdited)
            {
                var result = MessageBox.Show("You are about to discard this inquiry, or the changes made to this inquiry.\nIs that OK?", "Discard Changes?", MessageBoxButtons.YesNo);

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

        //Activate or deactivate form components
        private void EditableForm(bool isEditable)
        {
            if(isEditable)
            {
                isEditing = true;


                checkBoxNewStandard.Enabled = true;
                textBoxProductCode.ReadOnly = false;
                textBoxProductName.ReadOnly = false;
                comboBoxTestCode.Enabled = true;
                textBoxInquiryNotes.ReadOnly = false;

                btnCancel.Text = "Cancel";
            } 
            else
            {
                isEditing = false;

                checkBoxNewStandard.Enabled = false;
                textBoxProductCode.ReadOnly = true;
                textBoxProductName.ReadOnly = true;
                comboBoxTestCode.Enabled = false;
                textBoxInquiryNotes.ReadOnly = true;

                btnCancel.Text = "Close";
            }
        }

        //TextBoxes Changed, calls checkinput method to check for valid inputs
        #region Input Checks from changes to values
        private void textBoxProductCode_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            CheckInput(); 
        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            CheckInput(); 
        }

        private void textBoxInquiryNotes_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            CheckInput(); 
        }

        private void textBoxTestName_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            CheckInput();
        }
        private void textBoxTestDescription_TextChanged(object sender, EventArgs e)
        {
            hasBeenEdited = true;
            CheckInput();
        }
        #endregion

        //Checks for valid inputs
        private void CheckInput()
        {
            bool validProductCode;
            bool validProductName;
            bool validNotes;
            bool validTestCode = false;
            bool validTestName = false;
            bool validTestDesc = false;
            
            if(textBoxProductCode.Text != string.Empty)
            {
                bool valid = int.TryParse(textBoxProductCode.Text, out productCode);

                if (valid)
                {
                    labelNumbersOnly.Visible = false;
                    validProductCode = true;
                }
                else
                {
                    labelNumbersOnly.Visible = true;
                    validProductCode = false;
                }

                
            } else
            {
                validProductCode = false;
            }

            if (textBoxProductName.Text != string.Empty)
            {
                validProductName = true;
            } else
            {
                validProductName = false;
            }

            if(textBoxInquiryNotes.Text != string.Empty)
            {
                validNotes = true;
            } else
            {
                validNotes = false;
            }

            if(newStandard || comboBoxTestCode.SelectedIndex > -1)
            {
                validTestCode = true;
            } else
            {
                validTestCode = false;
            }

            if (textBoxTestName.Text != string.Empty)
            {
                validTestName = true;
            }
            else
            {
                validTestName = false;
            }

            if (textBoxTestDescription.Text != string.Empty)
            {
                validTestDesc = true;
            }
            else
            {
                validTestDesc = false;
            }


            if (validProductCode && validProductName && validNotes && validTestCode && validTestName && validTestDesc && isEditing)
            {
                btnOk.Enabled = true;
            } else
            {
                btnOk.Enabled = false;
            }
        }

        public Inquiry WorkingInquiry
        {
            get { return workingInquiry; }
            set { workingInquiry = value; }
        }

        public int ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        public string InqProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }

        public TestStandardsManager NewTestManager
        {
            get { return testManager; }
            set { testManager = value; }
        }


    }
}
