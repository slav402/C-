using LogForU.Core.Enums;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models.Interfaces;

namespace LogForU.Core.Appendres.Interfaces
{
    public interface IAppender
    {
        public ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        int MesegesAppended { get; }

        void AppendMessage(IMessage message);
    }
}
