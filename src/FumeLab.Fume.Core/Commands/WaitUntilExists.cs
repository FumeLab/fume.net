using System;

namespace FumeLab.Fume.Core.Commands
{
    public class WaitUntilExists : Command
    {
        public TimeSpan Timeout { get; set; }
    }
}
