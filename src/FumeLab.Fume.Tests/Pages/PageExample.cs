using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Elements;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Tests.Pages
{
    public class PageExample
    {
        [Selector(Type = typeof(Id), Value = "button1")]
        public Clickable ClickMeButton { get; set; }

        [Selector(typeof(Name), "et_pb_contact_name_1")]
        public Input InputElement { get; set; }
    }
}
