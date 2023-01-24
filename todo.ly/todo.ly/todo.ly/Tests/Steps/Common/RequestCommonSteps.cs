// <copyright file="RequestCommonSteps.cs" company="API Testing">
// Copyright (c) API Testing. All rights reserved.
// </copyright>
namespace Todo.Ly.Tests.Steps.Common
{
    using RestSharp;
    using TechTalk.SpecFlow;
    using Todo.Ly.Core;
    using Todo.Ly.Tests.Common;
    using Xunit;

    /// <summary>
    /// Common steps for make request.
    /// </summary>
    [Binding]
    public class RequestCommonSteps : AutomationTestBase
    {
        [When(@"the user send ([^""]*) request to ""([^""]*)""")]
        public void WhenTheUserSendPostRequestTo(string method, string url)
        {
            switch (method.ToUpper())
            {
                case "GET":
                    this.AutomationClient.Request = new RestRequest($"{ConfigParameters.BaseUrl}{url}", Method.Get);
                    break;
                case "POST":
                    this.AutomationClient.Request = new RestRequest($"{ConfigParameters.BaseUrl}{url}", Method.Post);
                    break;
            }
        }

        /// <summary>
        /// Method to add JSON to body request.
        /// </summary>
        /// <param name="body">JSON body to add into request.</param>
        [When(@"the user write in the body")]
        public void WhenTheUserWriteInTheBody(string body)
        {
            this.AutomationClient.Request.AddJsonBody(body);
        }

        /// <summary>
        /// Method to execute the request.
        /// </summary>
        [When(@"the user send the request")]
        public void WhenTheUserExecuteTheRequest()
        {
            this.AutomationClient.Result = this.AutomationClient.Client.Execute(this.AutomationClient.Request);
        }

        /// <summary>
        /// Validate that the status code is OK and the response is completed.
        /// </summary>
        [Then(@"the user should see that the request has been successfully completed")]
        public void ThenTheUserShouldSeeThatTheRequestHasBeenSuccessfullyCompleted()
        {
            Assert.Equal("OK", this.AutomationClient.Result.StatusCode.ToString());
            Assert.Equal("Completed", this.AutomationClient.Result.ResponseStatus.ToString());
        }
    }
}
