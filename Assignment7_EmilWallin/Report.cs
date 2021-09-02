using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_EmilWallin
{
    [Serializable]
    public struct Report
    {
        // Test Fields
        private string testNotes;

        //Result fields
        private int resultIndex;
        private string additionalComments;

        private DateTime dateCompleted;


        //Properties
        //GENERAL INFO
        public string TestNotes
        {
            get
            {
                return testNotes;
            }
            set
            {
                testNotes = value;
            }
        }

        //RESULTS
        public int Result
        {
            get
            {
                return resultIndex;
            }
            set
            {
                resultIndex = value;
            }
        }
        public string AdditionalComments
        {
            get
            {
                return additionalComments;
            }
            set
            {
                additionalComments = value;
            }
        }

        public DateTime DateCompleted
        {
            get
            {
                return dateCompleted;
            }
            set
            {
                dateCompleted = value;
            }
        }
    }
}
