using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_EmilWallin
{
    [Serializable]
    class InquiryAndReportManager
    {
        private List<InquiryAndReport> inquiryAndReportList;

        public InquiryAndReportManager()
        {
            inquiryAndReportList = new List<InquiryAndReport>();
        }

        //Adds an inquiry to the list (inquiry info is necessary)
        public void AddInquiry(string testCode, string inquiryNotes, string productName, int productCode)
        {
            if(inquiryAndReportList.Count == 0)             //As inquiry and reportlist.count == 0, the -1 in the code outside the if-statement doesn't work. Needed due to consistent IDs even though entries have been removed
            {
                inquiryAndReportList.Add(new InquiryAndReport(inquiryAndReportList.Count, testCode, inquiryNotes, productName, productCode));
                return;
            }

            inquiryAndReportList.Add(new InquiryAndReport(inquiryAndReportList[inquiryAndReportList.Count -1].ID + 1, testCode, inquiryNotes, productName, productCode));
        }

        //Adds report to index of inquiry
        public void AddReport(int index, Report newReport)
        {
            inquiryAndReportList[index].AddReport(newReport);
        }

        //Edits inquiry at index
        public void EditInquiry(int index, string testCode, Inquiry newInquiry, int productCode, string productName)
        {
            inquiryAndReportList[index] = new InquiryAndReport(index, testCode, newInquiry.InquiryNotes, productName, productCode);
        }

        //Returns a copy of the inquiry and report object from the list of inquiriesAndReports
        public InquiryAndReport GetData(int index)
        {
            return inquiryAndReportList[index];
        }

        //Edits report at index
        public void EditReport(int index, Report newReport)
        {
            inquiryAndReportList[index].AddReport(newReport);
        }

        //Removes entry at index. The IDs of the entries will stay although their List index will change. This will make referencing them in correspondence easier
        public void RemoveEntry(int index)
        {
            inquiryAndReportList.RemoveAt(index);
        }


        //Compiling a list of strings with compiled info on the incomplete inquiries
        public List<string> CompilePendingList(string filter)
        {
            List<string> nameList = new List<string>();

            for (int i = 0; i < inquiryAndReportList.Count; i++)
            {
                if (inquiryAndReportList[i].CompileString().Contains(filter) && inquiryAndReportList[i].IsCompleted == false)   //Checks for filter and incompletion
                {
                    nameList.Add(inquiryAndReportList[i].CompileString());
                }
            }

            return nameList;
        }

        //Compiling a list of strings with compiled info on the completed inquiries
        public List<string> CompileCompletedList(string filter)
        {
            List<string> nameList = new List<string>();

            for (int i = 0; i < inquiryAndReportList.Count; i++)
            {
                if (inquiryAndReportList[i].CompileString().Contains(filter) && inquiryAndReportList[i].IsCompleted == true)    //Checks for filter and completion
                {
                    nameList.Add(inquiryAndReportList[i].CompileString());
                }
            }

            return nameList;
        }


        //Returns ID of the inquiry
        public int GetID(int index, bool isCompleted)
        {
            int id = 0;
            if (isCompleted)
            {
                for (int i = 0; i < inquiryAndReportList.Count; i++)
                {
                    if (inquiryAndReportList[i].IsCompleted == true)    //Checks for completion and goes through each one
                    {
                        if(id == index)
                        {
                            return i;
                        }
                        else
                        { id++; }
                    }
                }
            } else
            {
                for (int i = 0; i < inquiryAndReportList.Count; i++)
                {
                    if (inquiryAndReportList[i].IsCompleted == false)   //Checks for incompletion and goes through each one
                    {
                        if (id == index)
                        {
                            return i;
                        }
                        else
                        { id++; }
                    }
                }
            }
            return -1;
        }
    }
}
