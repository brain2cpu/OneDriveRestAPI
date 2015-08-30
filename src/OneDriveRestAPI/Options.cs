namespace OneDriveRestAPI
{
    public class Options
    {
        public string ClientId { get; set; }
        public string ClientSecret{ get; set; }


        public bool PrettyJson { get; set; } = false;
        public bool AutoRefreshTokens { get; set; } = true;

        public float? ReadRequestsPerSecond { get; set; } = 2;
        public float? WriteRequestsPerSecond { get; set; } = 2;

        public string CallbackUrl { get; set; } = RequestGenerator.EndUrl;


        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}