using LogForU.Core.Appendres.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.IO.Interfaces;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Appendres
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel = ReportLevel.Info)
        {
            Layout = layout;
            LogFile = logFile;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; private set; }

        public ILogFile LogFile { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public int MesegesAppended { get; private set; }

        public void AppendMessage(IMessage message)
        {
            string content = string.Format(Layout.Format, message.CreateTime, message.ReportLevel, message.Text);

            LogFile.WriteLine(content);

            File.AppendAllText(LogFile.FullPath, content + Environment.NewLine);

            MesegesAppended++;
        }
    }
}
