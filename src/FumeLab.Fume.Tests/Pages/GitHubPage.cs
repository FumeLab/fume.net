using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Elements;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Tests.Pages
{
    public class GitHubPage
    {
        //elements
        [Selector(Type = typeof(XPath), Value = "//input[@placeholder='Search GitHub']")]
        public Input SearchGitHub { get; set; }

        [Selector(Type = typeof(XPath), Value = "//a[@href='/FumeLab/fumelab.github.io']")]
        public Clickable FumeLabLink { get; set; }

        [Selector(Type = typeof(XPath), Value = "//div[contains(text(),'FumeLab')]")]
        public Clickable JumpToFume { get; set; }

        [Selector(Type = typeof(XPath), Value = "//a[@href='/FumeLab']")]
        public Clickable FumeLabBaseLink { get; set; }

        [Selector(Type = typeof(XPath), Value = "//a[@title='https://fumelab.github.io']")]
        public Clickable FumeSiteLink { get; set; }
    }
}
