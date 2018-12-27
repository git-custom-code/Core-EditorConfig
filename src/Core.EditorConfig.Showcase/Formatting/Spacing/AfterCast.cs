namespace CustomCode.Core.EditorConfig
{
    public sealed class AfterCast
    {
        public void ShowCase()
        {
            var bar = 42m;

            // csharp_space_after_cast = true
            var foo = (int) bar;

            // csharp_space_after_cast = false
            foo = (int)bar;
        }
    }
}