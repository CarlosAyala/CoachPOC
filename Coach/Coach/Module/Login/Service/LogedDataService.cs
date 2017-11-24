using Coach.Module.Login.Model;
using Coach.Module.Login.Service.Interface;
using Prism.AppModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Module.Login.Service
{
    class LogedDataService : ILogedDataService
    {

        protected IApplicationStore _sessionStateService;

        public LogedDataService(IApplicationStore sessionStateService)
        {
            _sessionStateService = sessionStateService;
        }

        public bool isSaved()
        {
            if (_sessionStateService.Properties.ContainsKey("SavedSession"))
            {
                return (bool)_sessionStateService.Properties["SavedSession"];
            }

            return false;
        }

        public LogedData getData()
        {
            LogedData Data = new LogedData
            {
                BackEndUrl = getValue("BackEndUrl"),
                WorkSite = getValue("WorkSite"),
                InternetTimeOut = getValue("InternetTimeOut"),
                SessionTimeOut = getValue("SessionTimeOut")
            };

            return Data;
        }

        public void setValues(LogedData Data)
        {
            _sessionStateService.Properties["SavedSession"] = true;
            _sessionStateService.Properties["BackEndUrl"] = Data.BackEndUrl;
            _sessionStateService.Properties["WorkSite"] = Data.WorkSite;
            _sessionStateService.Properties["InternetTimeOut"] = Data.InternetTimeOut;
            _sessionStateService.Properties["SessionTimeOut"] = Data.SessionTimeOut;
        }

        public void setValue(string key, string value)
        {
            _sessionStateService.Properties[key] = value;
        }

        public string getValue(string key)
        {
            if (_sessionStateService.Properties.ContainsKey(key))
            {
                return _sessionStateService.Properties[key].ToString();
            }
            return null;
        }
    }
}
