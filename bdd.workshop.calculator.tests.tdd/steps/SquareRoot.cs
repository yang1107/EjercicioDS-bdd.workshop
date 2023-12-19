using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.tdd.steps
{
    [Binding]
    public sealed class SquareRoot
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SquareRoot(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the number to calculate is (.*)")]
        public void GivenTheNumberIs(int Number)
        {
            _scenarioContext.Add("Number", Number);
        }


        [When(@"the square root is taken")]
        public void WhenTheSquareRootIsTaken()
        {
            var Number = _scenarioContext.Get<int>("Number");
            _scenarioContext.Add("Result", Operator.SquareRoot(Number));
        }

        [Then(@"the result will be (.*)")]
        public void ThenTheResultWillBe(int result)
        {
            Assert.True(result == _scenarioContext.Get<double>("Result"));
        }



    }
}
