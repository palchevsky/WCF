using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.


    [ServiceContract(CallbackContract =typeof(IClientCallback))]
    public interface IDuplexSrv
    {
        [OperationContract]
        void Login(string name);
        [OperationContract(IsOneWay =true)]
        void SendText(string text);
        [OperationContract]
        void Logout(string name);
    }

    public interface IClientCallback
    {
        [OperationContract(IsOneWay =true)]
        void NotifyUserLogin(string userName);

        [OperationContract(IsOneWay = true)]
        void NotifyUserOfMessage(string userName, string userMessage);

        [OperationContract(IsOneWay = true)]
        void NotifyUserLogout(string userName);
    }
}
