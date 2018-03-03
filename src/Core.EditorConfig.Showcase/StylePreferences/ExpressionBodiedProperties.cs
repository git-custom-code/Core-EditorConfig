namespace CustomCode.Core.EditorConfig
{
    public sealed class ExpressionBodiedProperties
    {
        // csharp_style_expression_bodied_properties = true:error
        public int Foo => 42;

        // csharp_style_expression_bodied_properties = false:error
        public int Bar
        {
            get { return 42; }
        }
    }
}