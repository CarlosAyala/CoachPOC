using Coach.Module.Login.Model;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Module.Login.Service.Interface
{
    public interface ILogedDataService
    {
        bool isSaved();

        void setValues(LogedData Data);
        void setValue(string key, string value);

        [NotNull]
        LogedData getData();
        [NotNull]
        string getValue(string key);
    }
}
