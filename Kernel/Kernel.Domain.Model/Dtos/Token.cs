namespace Kernel.Domain.Model.Dtos;

using System;

public class Token
{
    public long Key { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public DateTime ExpiresIn { get; set; }

    public override string ToString() => $"#{Key}: {Name} ({Email}) - {ExpiresIn}";
}
