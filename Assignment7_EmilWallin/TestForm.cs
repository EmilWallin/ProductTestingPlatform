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
    public partial class TestForm : Form
    {
        //FIELDS
        private TestStandardsManager testManager;
        private bool newStandard;


        //CONSTRUCTOR
        public TestForm(TestStandardsManager testManager)
        {
            InitializeComponent();
            this.testManager = testManager;

            InitializeGUI();
        }

        //METHODS
        
        //Initializes the GUI
        private void InitializeGUI()
        {
            comboBoxTestCode.DataSource = testManager.GetCodeList();
        }

        //When the combobox changes it fills the other textboxes
        private void comboBoxTestCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTestTextBoxes(comboBoxTestCode.SelectedIndex);
        }

        //Fills the textboxes with info about the test standard
        private void FillTestTextBoxes(int index)
        {
            if (index > -1)
            {
                textBoxTestName.Text = testManager.GetTestName(index);
                textBoxTestDescription.Text = testManager.GetTestDescription(index);
            }
            else
            {
                textBoxTestName.Text = "";
                textBoxTestDescription.Text = "";
            }
        }

        //When checkbox is changed
        private void checkBoxNewStandard_CheckedChanged(object sender, EventArgs e)
        {
            NewStandardChanged();
        }
        
        //Confirm click method
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(CheckValidTextBoxes())
            {
                var result = MessageBox.Show("Do you want to enter this test standard into the register?", "Confirm new standard.", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    testManager.AddStandard(comboBoxTestCode.Text, textBoxTestName.Text, textBoxTestDescription.Text);
                    newStandard = false;
                    checkBoxNewStandard.Checked = false;
                    NewStandardChanged();
                    InitializeGUI();
                    comboBoxTestCode.SelectedIndex = testManager.GetCodeList().Count - 1;
                }
            }
        }

        //Close click method
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (newStandard)
            {
                if (!CheckIfEmpty())
                    return;
            }
            Close();
        }

        //Changes the textboxes based on the newStandard bool
        private void NewStandardChanged()
        {
            if (checkBoxNewStandard.Checked)
            {
                comboBoxTestCode.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxTestCode.SelectedIndex = -1;
                textBoxTestName.Text = "";
                textBoxTestDescription.Text = "";
                btnConfirm.Enabled = true;

                textBoxTestName.ReadOnly = false;
                textBoxTestDescription.ReadOnly = false;

                newStandard = true;
            }
            else
            {
                if (!CheckIfEmpty())
                    return;

                comboBoxTestCode.DropDownStyle = ComboBoxStyle.DropDownList;
                textBoxTestName.Text = "";
                textBoxTestDescription.Text = "";
                btnConfirm.Enabled = false;

                textBoxTestName.ReadOnly = true;
                textBoxTestDescription.ReadOnly = true;

                newStandard = false;
            }
        }

        //Method that checks if the text fields are empty or not, returns true if they are empty, and returns false if the user does not want to discard the entered text
        private bool CheckIfEmpty()
        {
            if (!newStandard)
                return true;
            if (comboBoxTestCode.Text != "" || textBoxTestName.Text != "" || textBoxTestDescription.Text != "")
            {
                var result = MessageBox.Show("Discard new test standard?", "Discard Standard", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return false;
                }
            }
            return true;
        }

        //Checks if the input in the text boxes is valid (not empty)
        private bool CheckValidTextBoxes()
        {
            if (comboBoxTestCode.Text != "" || textBoxTestName.Text != "" || textBoxTestDescription.Text != "")
            {
                return true;
            }
            return false;
        }

        //PROPERTIES
        public TestStandardsManager TestManager
        {
            get { return testManager; }
        }
    }
}
