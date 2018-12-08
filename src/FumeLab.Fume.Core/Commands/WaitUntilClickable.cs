using System;

namespace FumeLab.Fume.Core.Commands
{
    public class WaitUntilClickable : Command
    {
        public TimeSpan Timeout { get; set; }
    }
}
