namespace CustomCode.Core.EditorConfig
{
    public sealed class PreferSimpleDefaultExpression
    {
        // csharp_prefer_simple_default_expression = true
        // Note: requires c# 7.1
        private void Foo(int foo = default)
        { }

        // csharp_prefer_simple_default_expression = false
        private void Bar(int foo = default(int))
        { }
    }
}