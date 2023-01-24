namespace Todo.Ly.Tests.Common
{
    public static class ConfigParameters
    {
        public static string Protocol = "https://";

        /// <summary>
        /// Gets host name value.
        /// </summary>
        public static string Server
        {
            get
            {
                return $"{Protocol}todo.ly";
            }
        }

        /// <summary>
        /// Gets host name value.
        /// </summary>
        public static string User
        {
            get
            {
                return "....";
            }
        }

        /// <summary>
        /// Gets host name value.
        /// </summary>
        public static string Password
        {
            get
            {
                return ".....";
            }
        }

        /// <summary>
        /// Gets host name value.
        /// </summary>
        public static string BaseUrl
        {
            get
            {
                return $"{Server}/api/";
            }
        }

    }
}
