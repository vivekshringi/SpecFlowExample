using System;
using Example;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTest
{
    [Binding]
    public class CalculateSteps
    {
        
        
        
        private Calculator calculator = new Calculator();
        private int result
        {
            get; set;
        }

        [Given(@"Some precondition can be covered in background")]
        public void GivenSomePreconditionCanBeCoveredInBackground()
        {
            Console.Write("Presteps needs to be done");
        }
        [Given(@"I entered min value as (.*) into the calculator")]
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
                
        }
        [Given(@"I also entered max value as (.*) into the calculator")]
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press deduct")]
        public void WhenIPressDeduct()
        {
            result = calculator.deduct();
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }


        [When(@"I press multiple")]
        public void WhenIPressMultiple()
        {
            result = calculator.mul();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = calculator.div();
        }

        [When(@"I press mod")]
        public void WhenIPressMod()
        {
            result = calculator.mod();
        }

        [When(@"I press generate random number")]
        public void WhenIPressGenerateRandomNumber()
        {
            result = calculator.random();
        }
        [When(@"I press power")]
        public void WhenIPressPower()
        {
            result = calculator.power();
        }


        [Then(@"the result should be between (.*) and (.*)")]
        public void ThenTheResultShouldBeBetweenAnd(int Min, int Max)
        {
            Assert.IsTrue(result > Min && result < Max);
        }

    }
}
