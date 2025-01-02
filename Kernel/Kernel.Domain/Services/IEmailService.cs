namespace Kernel.Domain.Services;

using Kernel.Domain.Model.Dtos;
using Kernel.Domain.Model.Settings;

public interface IEmailService
{
    void Send(EmailMessage message, SmtpSettings settings = null);
}
