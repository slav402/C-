using LogForU.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Models.Interfaces
{
    public interface IMessage
    {
        string CreateTime { get; }

        string Text { get; }

        ReportLevel ReportLevel { get; }
    }
}
