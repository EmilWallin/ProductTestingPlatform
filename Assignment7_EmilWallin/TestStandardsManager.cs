using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment7_EmilWallin
{
    [Serializable]
    public class TestStandardsManager
    {


        private List<TestStandard> testStandardsList;

        public TestStandardsManager()
        {
            testStandardsList = new List<TestStandard>();
        }

        //Add new standard to the list of standards
        public void AddStandard(string testCode, string standardName, string testDescription)
        {
            testStandardsList.Add(new TestStandard(testStandardsList.Count(), testCode, standardName, testDescription));
        }



        //Get methods
        //Get list of testcodes
        public List<string> GetCodeList()
        {
            List<string> standards = new List<string>();

            for (int i = 0; i < testStandardsList.Count; i++)
            {
                standards.Add(testStandardsList[i].TestCode);
            }

            return standards;
        }

        //get test name of index
        public string GetTestName(int index)
        {
            return testStandardsList[index].TestName;
        }
        //Get test description of index
        public string GetTestDescription(int index)
        {
            return testStandardsList[index].TestDescription;
        }

    }
}
