namespace CustomCode.Core.EditorConfig
{
    public sealed class BetwwenParentheses
    {
        public void ShowCase()
        {
            // csharp_space_between_parentheses = none
            var bar = 0m;
            var foo = (int)bar;

            while (foo < 42)
            {
                ++foo;
            }

            // csharp_space_between_parentheses = type_casts
            foo = ( int )bar;

            while (foo < 42)
            {
                ++foo;
            }

            // csharp_space_between_parentheses = type_casts,control_flow_statements
            foo = ( int )bar;

            while ( foo < 42 )
            {
                ++foo;
            }
        }
    }
}