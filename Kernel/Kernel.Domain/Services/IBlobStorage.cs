namespace Kernel.Domain.Services;

using System.IO;
using System.Threading.Tasks;

public interface IBlobStorage
{
    Task CreateContainer(string containerName);
    Task DeleteContainer(string containerName);
    Task Upload(string containerName, string fileName, Stream uploadFileStream, bool overwrite = true);
    string GetBlobUrl(string containerName, string fileName);
    Task DeleteBlob(string containerName, string fileName);
}
