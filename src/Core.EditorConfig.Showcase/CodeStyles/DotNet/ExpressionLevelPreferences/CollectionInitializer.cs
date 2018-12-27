namespace CustomCode.Core.EditorConfig
{
    using System.Collections.Generic;

    public sealed class CollectionInitializer
    {
        public void ShowCase()
        {
            // dotnet_style_collection_initializer = true:error
            var foos = new List<int> { 42, 13 };

            // dotnet_style_collection_initializer = false:error
            var foo = new List<int>();
            foo.Add(42);
            foo.Add(13);
        }
    }
}