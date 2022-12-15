namespace PassGen
{
    public class PasswordOptions
    {
        public bool UpperCase { get; set; }
        public bool LowerCase { get; set; }
        public bool SpecialChars { get; set; }
        public bool Numbers { get; set; }

        public const string DefaultCharList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        public PasswordOptions() { }
    }
}
