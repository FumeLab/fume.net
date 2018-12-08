using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Elements;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Tests.Pages
{
    public class FumeLabPage
    {
        //elements
        [Selector(Type = typeof(CssSelector), Value = "a[class='button']")]
        public Clickable VisitGitHub { get; set; }
    }
}
