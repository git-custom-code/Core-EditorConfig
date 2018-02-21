namespace CustomCode.Core.EditorConfig
{
    public sealed class ObjectPropagation
    {
        private class Foo
        {
            public int Value { get; set; }
        }

        public void ShowCase()
        {
            // dotnet_style_object_initializer = true:error
            var foo = new Foo
                {
                    Value = 42
                };

            // dotnet_style_object_initializer = false:error
            foo = new Foo();
            foo.Value = 42;
        }
    }
}