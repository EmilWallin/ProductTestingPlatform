using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_EmilWallin
{
    [Serializable]
    public class TestStandard
    {
        //Fields
        private int testIndex;  //ID

        //Test info
        private string testCode;
        private string testName;
        private string testDescription;



        //CONSTRUCTOR
        public TestStandard(int id, string testCode, string testName, string testDescription)
        {
            testIndex = id;
            this.testCode = testCode;
            this.testName = testName;
            this.testDescription = testDescription;
        }

        //PROPERTIES
        public string TestCode
        {
            get
            { return testCode; }
            set
            { testCode = value; }
        }
        public string TestName
        {
            get
            { return testName; }
            set
            { testName = value; }
        }
        public string TestDescription
        {
            get
            { return testDescription; }
            set
            { testDescription = value; }
        }
    }
}
