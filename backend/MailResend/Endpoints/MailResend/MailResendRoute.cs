using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using MailResend.Services;
using Resend;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailResend.Endpoints.MailResend;

public static class MailResendRoute
{
    public static RouteHandlerBuilder AddMailResendRoute(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", async ([FromServices] IResendService resendService) =>
        {
            var result = await resendService.EmailSendAsync(new EmailMessage
            {
                From = new EmailAddress
                {
                    Email = "no-reply@compozerr.com",
                    DisplayName = "Compozerr"
                },
                To = ["info@example.com"],
                Subject = "Hello from Compozerr",
                HtmlBody = "<p>Hello, world!</p>"
            });

            return Results.Ok(result);
        });
    }
}