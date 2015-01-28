using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecDemo.Specs
{
    [Binding]
    public class DemoSteps
    {
        private Calculator calculator = new Calculator();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculator.AddNumber(p0);
        }

        [When(@"I press add")]
public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
public void ThenTheResultShouldBeOnTheScreen(int p0)
{
   Assert.AreEqual(p0,result);
}
    }

    internal class Calculator
    {
        List<int> numbers = new List<int>(); 
        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public int Add()
        {
            return numbers.Sum();
        }
    }
}
