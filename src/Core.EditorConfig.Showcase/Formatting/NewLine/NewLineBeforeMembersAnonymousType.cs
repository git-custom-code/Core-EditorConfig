namespace CustomCode.Core.EditorConfig
{
    public sealed class NewLineBeforeMembersAnonymousType
    {
        public void ShowCase()
        {
            // csharp_new_line_before_members_in_anonymous_types = true
            var foo = new
                {
                    A = 42,
                    B = 13
                };

            // csharp_new_line_before_members_in_anonymous_types = false
            foo = new
                {
                    A = 42, B = 13
                };
        }
    }
}