using FrameworkHelpers.Common.Types;

namespace WebUserApi.Infrastructure
{
    public class WebUserApiConfig: IWebUserApiConfig
    {
        public ReleaseModes Mode { get; set; }
    }
}
