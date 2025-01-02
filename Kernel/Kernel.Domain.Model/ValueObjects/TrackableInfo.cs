namespace Kernel.Domain.Model.ValueObjects;

using System;

public class TrackableInfo : ValueObject<TrackableInfo>
{
    public string UserNameCreator { get; set; }
    public string UserNameLastChange { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? LastChangeDate { get; set; }

    public TrackableInfo()
    {
        CreationDate = DateTime.Now;
    }

    public TrackableInfo(string userName)
    {
        UserNameCreator = userName;
        CreationDate = DateTime.Now;
    }

    public void Changed(string userName)
    {
        UserNameLastChange = userName;
        LastChangeDate = DateTime.Now;
    }
}
