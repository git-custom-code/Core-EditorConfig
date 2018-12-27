namespace CustomCode.Core.EditorConfig
{
    public sealed class NewLineBeforeMembersObjectInitializers
    {
        private class Foo
        {
            public int A { get; set; }

            public int B { get; set; }
        }

        public void ShowCase()
        {
            // csharp_new_line_before_members_in_object_initializers = true
            var foo = new Foo
                {
                    A = 42,
                    B = 13
                };

            // csharp_new_line_before_members_in_object_initializers = false
            foo = new Foo
                {
                    A = 42, B = 13
                };
        }
    }
}