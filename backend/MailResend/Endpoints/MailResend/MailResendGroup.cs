using Carter;
using Microsoft.AspNetCore.Routing;

namespace MailResend.Endpoints.MailResend;

public class MailResendGroup : CarterModule
{
    public MailResendGroup() : base("mailresend")
    {
        WithTags(nameof(MailResend));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddMailResendRoute();
    }
}