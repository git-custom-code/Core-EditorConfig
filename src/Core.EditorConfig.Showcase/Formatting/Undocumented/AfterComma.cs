namespace CustomCode.Core.EditorConfig
{
    public sealed class AfterComma
    {
        public void ShowCase()
        {
            // csharp_space_after_comma = true
            var foo = new[] { 1, 2, 3 };

            // csharp_space_after_comma = false
            foo = new[] { 1,2,3 };
        }
    }
}