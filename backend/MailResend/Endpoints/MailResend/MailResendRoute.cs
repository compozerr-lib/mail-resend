using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using MailResend.Services;

namespace MailResend.Endpoints.MailResend;

public static class MailResendRoute
{
    public static RouteHandlerBuilder AddMailResendRoute(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IMailResendService mailresendService) => new GetMailResendResponse($"Hello, {mailresendService.GetObfuscatedName(name)}!"));
    }
}