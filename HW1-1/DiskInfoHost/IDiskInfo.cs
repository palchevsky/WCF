using System.ServiceModel;

namespace DiskInfoHost
{
    [ServiceContract]
    public interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
