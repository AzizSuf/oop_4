using StressTest;
using System;

namespace Ex2
{
    class TestManager
    {
        private static Random rand = new Random();

        public static TestCaseResult GenerateResult()
        {
            TestCaseResult testCaseResult;
            
            string[] failurs = { "SomeFailure1", "SomeFailure2", "SomeFailure666", "SomeFailure777" };

            TestResult testRsult = (TestResult)rand.Next(0, 2);

            testCaseResult.Result = testRsult;
            testCaseResult.ReasonForFailure = "";

            if (testRsult == TestResult.Fail)
            {
                testCaseResult.ReasonForFailure = failurs[rand.Next(0, failurs.Length)];

            }

            return testCaseResult;
        }
    }
}
