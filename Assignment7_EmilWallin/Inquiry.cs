using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_EmilWallin
{
    [Serializable]
    public struct Inquiry
    {
        // Inquiry fields
        private string inquiryNotes;
        private DateTime dateEntered;


        //Constructor

        public Inquiry(string notes, DateTime date)
        {
            inquiryNotes = notes;
            dateEntered = date;
        }

        //Properties
        //GENERAL INFO

        public string InquiryNotes
        {
            get
            {
                return inquiryNotes;
            }
            set
            {
                inquiryNotes = value;
            }
        }

        public DateTime DateEntered
        {
            get
            {
                return dateEntered;
            }
            set
            {
                dateEntered = value;
            }
        }
    }
}
