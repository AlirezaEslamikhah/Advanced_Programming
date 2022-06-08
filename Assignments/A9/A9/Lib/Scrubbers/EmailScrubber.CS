using System.Text.RegularExpressions;

namespace Logger
{
    public class EmailScrubber: AbstractScrubber
    {
        private EmailScrubber() { }

        private static EmailScrubber _Instance;

        public static EmailScrubber Instance => _Instance ?? (_Instance = new EmailScrubber());

        protected override Regex PIIRegEx => new Regex(@"[A-Za-z_]+@([a-z]+\.)+[a-z]+");
            // Regex regex = new Regex(@"[A-Za-z_]+@([a-z]+\.)+[a-z]+");


        public override string Scrub(string content) => MaskPII(content, this.MaskLetters);
    }
}