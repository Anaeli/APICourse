namespace Todo.Ly.Core
{
    using RestSharp;
    using RestSharp.Authenticators;
    using Todo.Ly.Tests.Common;

    public class AutomationClient
    {
        public RestClient Client;
        public RestRequest Request;
        public RestResponse Result;

        private static AutomationClient instance;
        private AutomationClient()
        {
            this.Client = new RestClient(ConfigParameters.Server);
            this.Request = new RestRequest();
            this.Result = new RestResponse();
        }

        public static AutomationClient Instance => instance ??= new AutomationClient();

        public void UserAuthentication()
        {
            this.Client.Authenticator = new HttpBasicAuthenticator(ConfigParameters.User, ConfigParameters.Password);
        }
    }
}
