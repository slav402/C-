using LogForU.Core.Appendres.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models.Interfaces;
using System;

namespace LogForU.Core.Appendres
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info) // това значи че ако не е подадена стойност на репорт левел неговата стойност остава дефолтната (репортЛевел.Инфо)
        {
            Layout = layout;
            ReportLevel = reportLevel;
        }
        
        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel {get; set;}

        public int MesegesAppended { get; private set; }

        public void AppendMessage(IMessage message)
        {
            Console.WriteLine(string.Format(Layout.Format, message.CreateTime, message.ReportLevel, message.Text));

            MesegesAppended++;
        }
    }                                                                                            
}
