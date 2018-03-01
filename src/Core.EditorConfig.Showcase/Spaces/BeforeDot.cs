namespace CustomCode.Core.EditorConfig
{
    public sealed class BeforeDot
    {
        public void ShowCase()
        {
            var foo = "";

            // csharp_space_before_dot = true
            foo .ToString();

            // csharp_space_before_dot = false
            foo.ToString();
        }
    }
}