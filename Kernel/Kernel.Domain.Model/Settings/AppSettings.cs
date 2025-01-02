namespace Kernel.Domain.Model.Settings;

using Kernel.Domain.Model.Enums;

public class AppSettings
{
    public Context Context { get; set; }
    public NoSqlDbSettings NoSqlDbSettings { get; set; }
    public StorageSettings StorageSettings { get; set; }
    public SmtpSettings SmtpSettings { get; set; }
    public TokenSettings TokenSettings { get; set; }
}
