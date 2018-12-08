using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Elements;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Tests.Pages
{
    public class FumeLabPage
    {
        //elements
        [Selector(Type = typeof(Css), Value = "a[class='button']")]
        public Clickable VisitGitHub { get; set; }
    }
}
