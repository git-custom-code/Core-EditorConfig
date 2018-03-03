namespace CustomCode.Core.EditorConfig
{
    public sealed class PatternMatchingOverAsWithNullCheck
    {
        public void ShowCase()
        {
            var foo = "";

            // csharp_style_pattern_matching_over_as_with_null_check = true:error
            if (foo is string s)
            {
            }

            // csharp_style_pattern_matching_over_as_with_null_check = false:error
            var str = foo as string;
            if (str != null)
            {
            }
        }
    }
}