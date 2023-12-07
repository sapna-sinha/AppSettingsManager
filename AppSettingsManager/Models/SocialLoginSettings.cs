namespace AppSettingsManager.Models
{
    public class SocialLoginSettings
    {
        public bool SocialLoginEnable { get; set; }
        public KeyValueSettings FacebookSettings { get; set; }
        public KeyValueSettings GoogleSettings { get; set; }
    }

    public class KeyValueSettings
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
