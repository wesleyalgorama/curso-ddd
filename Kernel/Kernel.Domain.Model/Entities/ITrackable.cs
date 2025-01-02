namespace Kernel.Domain.Model.Entities;

using Kernel.Domain.Model.ValueObjects;

public interface ITrackable : IAggregateRoot
{
    TrackableInfo TrackableInfo { get; set; }
}
