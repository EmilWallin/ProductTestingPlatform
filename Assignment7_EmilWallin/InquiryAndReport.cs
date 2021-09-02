using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_EmilWallin
{
    [Serializable]
    public class InquiryAndReport
    {
        //Collects inquiry and report in one single class
        private Inquiry inquiry;
        private Report report;

        private int id; //id of inquiry and report

        //Fields shared between boths inquiry and report
        private string productName;
        private int productCode;

        private string testCode;

        private bool isCompleted = false;

        //Constructor, with inquiry info
        public InquiryAndReport(int id, string testCode, string inquiryNotes, string productName, int productCode)
        {
            this.testCode = testCode;
            this.productName = productName;
            this.productCode = productCode;
            this.id = id;

            inquiry = new Inquiry(inquiryNotes, DateTime.Now);

            report = new Report();
        }

        //Add report to inquiry
        public void AddReport(Report newReport)         //Report input
        {
            this.AddReport(newReport.TestNotes, newReport.Result, newReport.AdditionalComments);
        }

        public void AddReport(string testNotes, int result, string additionalComments)
        {
            isCompleted = true;
            report.TestNotes = testNotes;
            report.Result = result;
            report.AdditionalComments = additionalComments;
            report.DateCompleted = DateTime.Now;
        }

        //Compile and return string of pending inquiries and reports
        public string CompileString()
        {
            string strCompiled = "";

            if (isCompleted)
            {
                strCompiled += string.Format("{0, -5: 000} Completed: {1, -12}", id, report.DateCompleted.ToShortDateString());
                strCompiled += string.Format("Prod:{0}, {1}. Test: {2}. [Result: {3}]", productCode.ToString(), productName, testCode, Enum.GetName(typeof(Results), report.Result));

            }else
            {
                strCompiled += string.Format("{0,-5: 000} Entered: {1, -12}", id, inquiry.DateEntered.ToShortDateString());
                strCompiled += string.Format("Prod:{0}, {1}. Test: {2}", productCode.ToString(), productName, testCode);

            }
            return strCompiled;
        }


        #region PROPERTIES
        //Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public bool IsCompleted
        {
            get { return isCompleted; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }


        #region Inquiry Properties

        public Inquiry GetInquiry
        {
            get { return inquiry; }
        }
        #endregion



        #region Report Properties
        //Report Properties

        public Report GetReport
        {
            get { return report; }
        }
        #endregion


        #endregion

    }
}
