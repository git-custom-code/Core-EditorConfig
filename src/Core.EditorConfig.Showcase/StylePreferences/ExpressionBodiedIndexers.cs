namespace CustomCode.Core.EditorConfig
{
    public sealed class ExpressionBodiedIndexers
    {
        private class Foo
        {
            // csharp_style_expression_bodied_indexers = true:error
            public int this[int index]
            {
                get => _foo[index];
                set => _foo[index] = value;
            }

            private int[] _foo = new int[10];
        }

        private class Bar
        {
            // csharp_style_expression_bodied_indexerys = false:error
            public int this[int index]
            {
                get { return _bar[index]; }
                set { _bar[index] = value; }
            }

            private int[] _bar = new int[10];
        }
    }
}