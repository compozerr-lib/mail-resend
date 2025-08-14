using MailResend.Options;
using Microsoft.Extensions.Options;
using Resend;

namespace MailResend.Services;

public interface IResendService
{
    public Task EmailSendAsync(EmailMessage message, CancellationToken cancellationToken = default);
}

public class ResendService(
    IOptions<MailResendOptions> options) : IResendService
{
    private readonly IResend _resend = ResendClient.Create(options.Value.ApiKey);

    public Task EmailSendAsync(EmailMessage message, CancellationToken cancellationToken = default)
        => _resend.EmailSendAsync(message, cancellationToken);
}