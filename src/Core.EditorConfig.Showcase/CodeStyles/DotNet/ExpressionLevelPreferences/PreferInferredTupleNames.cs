namespace CustomCode.Core.EditorConfig
{
    public sealed class PreferInferredTupleNames
    {
        public void ShowCase()
        {
            var foo = 0;
            var bar = 0;

            // dotnet_style_prefer_inferred_tuple_names = true
            var tuple = (foo, bar);

            // dotnet_style_prefer_inferred_tuple_names = false
            tuple = (foo: foo, bar: bar);
        }
    }
}