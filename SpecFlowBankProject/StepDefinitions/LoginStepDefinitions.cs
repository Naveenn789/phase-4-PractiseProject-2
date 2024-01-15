using BankLib;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBankProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private string userName;
        private string password;
        private string loginResult;
        private readonly ScenarioContext scenarioContext;
        private readonly LoginUser loginuser;
        public LoginStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            loginuser = new BankLib.LoginUser();
        }
        [Given(@"a user with valid username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenAUserWithValidUsernameAndPassword(string p0, string p1)
        {
            userName = "Ram";
            password = "Ram123";
        }

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            loginResult = loginuser.UserLogin(userName, password);
        }

        [Then(@"the result should Login Success")]
        public void ThenTheResultShouldLoginSuccess()
        {
            Assert.AreEqual("Login Succesfull", loginResult);
        }

        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUsernameAndInvalidPassword(string p0, string p1)
        {
            userName = p0;
            password = p1;
        }
        [When(@"the Login method called")]
        public void WhenTheLoginMethodCalled()
        {
            loginResult = loginuser.UserLogin(userName, password);
        }

        [Then(@"the result should Login Failed")]
        public void ThenTheResultShouldLoginFailed()
        {
            Assert.AreEqual("Login UnSuccesfull", loginResult);
        }
    }
}
