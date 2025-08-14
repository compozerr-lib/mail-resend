using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using MailResend.Services;

namespace MailResend;

public class MailResendFeature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IMailResendService, MailResendService>();
    }
}