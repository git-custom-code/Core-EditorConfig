namespace CustomCode.Core.EditorConfig
{
    public sealed class BeforeComma
    {
        public void ShowCase()
        {
            // csharp_space_before_comma = true
            var foo = new[] { 1 , 2 , 3 };

            // csharp_space_before_comma = false
            foo = new[] { 1, 2, 3 };
        }
    }
}