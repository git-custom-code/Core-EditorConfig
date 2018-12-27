namespace CustomCode.Core.EditorConfig
{
    using System.Text;

    public sealed class ObjectInitializer
    {
        public void ShowCase()
        {
            // dotnet_style_object_initializer = true:error
            var foo = new StringBuilder();
            foo.Capacity = 100;

            // dotnet_style_object_initializer = false:error
            foo = new StringBuilder
                {
                    Capacity = 100
                };
        }
    }
}