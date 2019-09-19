using FrameworkHelpers.Common.Types;

namespace WebUserApi.Infrastructure
{
    public interface IWebUserApiConfig
    {
        ReleaseModes Mode { get; set; }
    }
}
