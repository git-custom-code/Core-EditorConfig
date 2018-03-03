namespace CustomCode.Core.EditorConfig
{
    public sealed class ExpressionBodiedAccessors
    {
        // csharp_style_expression_bodied_accessors = true:error
        public int Foo
        {
            get => _foo;
            set => _foo = value;
        }

        private int _foo;

        // csharp_style_expression_bodied_accessors = false:error
        public int Bar
        {
            get { return _bar; }
            set { _bar = value; }
        }

        private int _bar;
    }
}