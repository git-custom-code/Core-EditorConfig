namespace CustomCode.Core.EditorConfig
{
    public sealed class BeforeOpenSquareBrackets
    {
        public void ShowCase()
        {
            // csharp_space_before_open_square_brackets = true
            var foo = new int [42];

            // csharp_space_before_open_square_brackets = false
            foo = new int[42];
        }
    }
}