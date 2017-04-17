using System.ServiceModel;

namespace DiskInfoLibrary
{
    [ServiceContract]
    public interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
