using System;
using Example;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTest
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforeExecution()
        {
            Console.Write("Before execution");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.Write("Before Feature");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.Write("After Feature");
        }

        [Before]
        public static void Before()
        {
            Console.Write("Before");
        }

        [After]
        public static void After()
        {
            Console.Write("After");
        }

        [AfterTestRun]
        public static void AfterExecution()
        {
            Console.Write("After execution");
        }


        [BeforeScenarioBlock]
        public static void BeforeScenarioBlock()
        {
            Console.Write("Before Scenario Block");
        }

        [AfterScenarioBlock]
        public static void AfterScenarioBlock()
        {
            Console.Write("After Scenario Block");
        }

        [BeforeStep(Order =100)]
        public static void BeforeStep100()
        {
            Console.Write("Before Step 100");
        }

        [AfterStep(Order = 100)]
        public static void AfterStep100()
        {
            Console.Write("After Step 100");
        }

        [BeforeStep(Order =0)]
        public static void BeforeStep0()
        {
            Console.Write("Before Step 0");
        }

        [AfterStep(Order=0)]
        public static void AfterStep0()
        {
            Console.Write("After Step 0");
        }

        [BeforeStep("@single")]
        public static void BeforeStepSingle()
        {
            Console.Write("Before Step");
        }

        [AfterStep("@single")]
        public static void AfterStepSingle()
        {
            Console.Write("After Step");
        }
    }
}
