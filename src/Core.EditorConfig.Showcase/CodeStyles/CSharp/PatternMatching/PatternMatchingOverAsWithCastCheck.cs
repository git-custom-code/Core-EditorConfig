namespace CustomCode.Core.EditorConfig
{
    public sealed class PatternMatchingOverAsWithCastCheck
    {
        public void ShowCase()
        {
            var foo = 0;

            // csharp_style_pattern_matching_over_is_with_cast_check = true:error
            if (foo is int i)
            {
            }

            // csharp_style_pattern_matching_over_is_with_cast_check = false:error
            if (foo is int)
            {
                var @int = (int)foo;
            }
        }
    }
}