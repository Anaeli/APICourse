namespace Todo.Ly.Tests.Steps.Items
{
    using Newtonsoft.Json;
    using RestSharp;
    using TechTalk.SpecFlow;
    using Todo.Ly.Core;
    using Todo.Ly.Tests.Common;
    using Todo.Ly.Tests.Model;
    using Xunit;

    [Binding]
    public class ItemSteps : AutomationTestBase
    {
        [Then(@"the user should see the correct response with Item information")]
        public void ThenTheUserShouldSeeResponse()
        {
            Item item = Item.Instance;
            item = JsonConvert.DeserializeObject<Item>(this.AutomationClient.Result.Content);
            Item.Instance.Id = item.Id;
            Assert.IsType<Item>(item);
            Assert.Equal(item.Content, Item.Instance.Content);
        }

        [When(@"the user send GET request to ""([^""]*)"" with ItemID")]
        public void WhenTheUserSendGetRequestToWithItemId(string url)
        {
            this.AutomationClient.Request =
                new RestRequest($"{ConfigParameters.BaseUrl}{url.Replace("[item_id]", Item.Instance.Id)}", Method.Get);

        }

        [When(@"the user write in the body with item information")]
        public void WhenTheUserWriteInTheBody(string body)
        {
            this.AutomationClient.Request.AddJsonBody(body);
            Item item = Item.Instance;
            item = JsonConvert.DeserializeObject<Item>(body);
            Item.Instance.Content = item.Content;
        }

        [AfterScenario]
        public void DeleteItem()
        {
            RestRequest request =
                new RestRequest($"{ConfigParameters.BaseUrl}items/{Item.Instance.Id}.json", Method.Delete);
            this.AutomationClient.Client.Execute(request);
        }
    }
}
