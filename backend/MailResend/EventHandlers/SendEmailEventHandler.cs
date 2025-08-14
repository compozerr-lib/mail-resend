using Core.Abstractions;
using Core.Extensions;
using Mail.Events;
using MailResend.Services;

namespace MailResend.EventHandlers;

public sealed class SendEmailEventHandler(IResendService resendService) : IEventHandler<SendEmailEvent>
{
    public Task Handle(SendEmailEvent notification, CancellationToken cancellationToken)
    {
        return resendService.EmailSendAsync(new Resend.EmailMessage
        {
            From = notification.Email.From.Address,
            To = [.. notification.Email.To.Select(to => to.Address)],
            Subject = notification.Email.Subject,
            HtmlBody = notification.Email.HtmlBody
        }, cancellationToken).LogExceptionAsError();
    }
}
