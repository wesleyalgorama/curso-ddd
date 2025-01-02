namespace Kernel.Domain.Model.Entities;

using Kernel.Domain.Model.ValueObjects;

public interface IActivable : IAggregateRoot
{
    ActiveInfo ActiveInfo { get; set; }
}
