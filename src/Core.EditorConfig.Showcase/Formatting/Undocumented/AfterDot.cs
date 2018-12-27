namespace CustomCode.Core.EditorConfig
{
    public sealed class AfterDot
    {
        public void ShowCase()
        {
            var foo = "";

            // csharp_space_after_dot = true
            foo. ToString();

            // csharp_space_after_dot = false
            foo.ToString();
        }
    }
}