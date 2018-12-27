namespace CustomCode.Core.EditorConfig
{
    public sealed class ExpressionBodiedMethods
    {
        // csharp_style_expression_bodied_methods = true:error
        public int Foo() => 42;

        // csharp_style_expression_bodied_methods = false:error
        public int Bar()
        {
            return 42;
        }
    }
}