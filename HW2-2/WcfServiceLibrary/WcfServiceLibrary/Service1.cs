using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Single,
        InstanceContextMode =InstanceContextMode.PerCall)]
    public class DuplexSrv : IDuplexSrv
    {
        private static List<IClientCallback> _callbackList = new List<IClientCallback>();
        private static int _registeredUsers =0;

        public DuplexSrv()
        {
        }

        public void Login(string userName)
        {
            IClientCallback registeredUser = OperationContext.Current.GetCallbackChannel<IClientCallback>();
            //_userLogins.Add(name);
            if(!_callbackList.Contains(registeredUser))
            {
                _callbackList.Add(registeredUser);
            }

            _callbackList.ForEach(
                delegate (IClientCallback callback)
                {
                    callback.NotifyUserLogin(userName);
                    _registeredUsers++;
                });
        }

        public void Logout(string userName)
        {
            IClientCallback registeredUser = OperationContext.Current.GetCallbackChannel<IClientCallback>();
            if(_callbackList.Contains(registeredUser))
            {
                _callbackList.Remove(registeredUser);
                _registeredUsers--;
            }
            _callbackList.ForEach(
                delegate (IClientCallback callback)
                { callback.NotifyUserLogout(userName); }
                );
        }

        public void SendText(string text)
        {
            _callbackList.ForEach(
                delegate(IClientCallback callback) 
                {
                    callback.NotifyUserOfMessage("", text);
                });
        }
    }

    //public class Texts
    //{
    //    public IClientCallback callback = null;

    //    public void SendTextToUsers(object data)
    //    {
    //        string text = (string)data;
    //        try
    //        {
    //            callback.TextForUsers(text);
    //        }
    //        catch (Exception ex)
    //        {
    //            File.AppendAllText(@"error.log", ex.Message);
    //        }
    //    }
    //}

}
