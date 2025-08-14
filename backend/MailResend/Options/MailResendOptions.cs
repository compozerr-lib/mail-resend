namespace MailResend.Options;

using System.ComponentModel.DataAnnotations;

public sealed class MailResendOptions
{
    [Required]
    public required string ApiKey { get; init; }
    
    [Required]
    public required string FromMail { get; init; }
}