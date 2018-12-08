using System;
using System.Collections.Generic;
using System.Text;

namespace FumeLab.Fume.Core
{
    public interface IQuery<TQuery>
    {
        TQuery Value { get; }
    }
}
