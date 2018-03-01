namespace CustomCode.Core.EditorConfig
{
    public sealed class BetwwenEmptySquareBrackets
    {
        public void ShowCase()
        {
            int[] foo;

            // csharp_space_between_empty_square_brackets = true
            foo = new[ ] { 42, 13 };

            // csharp_space_between_empty_square_brackets = false
            foo = new[] { 42, 13 };
        }
    }
}