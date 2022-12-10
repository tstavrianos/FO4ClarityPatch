using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace FO4ClarityPatch
{
    public enum RunMode
    {
        Clarity3,
        Clarity4
    }
    public class Settings
    {
        [MaintainOrder] [SettingName("Version of Clarity")]
        public RunMode Mode { get; set; } = RunMode.Clarity4;
    }
}