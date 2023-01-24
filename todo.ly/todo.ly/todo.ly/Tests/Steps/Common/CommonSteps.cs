namespace Todo.Ly.Tests.Steps.Common
{
    using TechTalk.SpecFlow;
    using Todo.Ly.Core;

    [Binding]
    public class CommonSteps: AutomationTestBase
    {
        [Given(@"the user is authenticated")]
        public void GivenTheUserIsAuthenticated()
        {
            this.AutomationClient.UserAuthentication();
        }
    }
}
