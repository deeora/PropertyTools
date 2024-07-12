namespace ExampleLibrary
{
    using System.ComponentModel;

    [PropertyGridExample]
    public class OptionEnableAttributeExample : Example
    {
        public enum TestEnumeration
        {
            Red,
            [PropertyTools.DataAnnotations.OptionEnable("EnableGreenColorOption")]
            Green,
            Blue
        }

        [Category("Option enable attribute")]
        [Description("Green color can be enabled or disabled by a 'Enable green color option'")]
        public TestEnumeration Color { get; set; }

        public bool EnableGreenColorOption{ get; set; }
    }
}