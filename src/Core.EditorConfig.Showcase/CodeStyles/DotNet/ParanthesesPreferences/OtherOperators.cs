namespace CustomCode.Core.EditorConfig
{
    public sealed class OtherOperators
    {
        public void Showcase()
        {
            var foo = typeof(OtherOperators);

            // dotnet_style_parentheses_in_other_operators = always_for_clarity
            var result = (foo.FullName).Length;

            // dotnet_style_parentheses_in_other_operators = never_if_unnecessary
            result = foo.FullName.Length;
        }
    }
}