using System;

namespace FumeLab.Fume.Core.Commands
{
    public class WaitUntilVisible : Command
    {
        public TimeSpan Timeout { get; set; }
    }
}
