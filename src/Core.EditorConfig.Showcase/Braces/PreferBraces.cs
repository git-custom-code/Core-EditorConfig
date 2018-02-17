namespace CustomCode.Core.EditorConfig
{
    public sealed class PreferBraces
    {
        public void ShowCase()
        {
            var foo = false;

            // csharp_prefer_braces = true:warning
            if (foo)
            {
                return;
            }

            // csharp_prefer_braces = false:warning
            if (foo)
                return;
        }
    }
}