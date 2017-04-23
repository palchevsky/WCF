using System.ServiceModel;
namespace DiskInfo
{
    [ServiceContract]
    public interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}