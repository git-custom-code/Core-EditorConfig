namespace CustomCode.Core.EditorConfig
{
    public sealed class BetweenSquareBrackets
    {
        public void ShowCase()
        {
            var foo = new int[50];

            // csharp_space_between_square_brackets = true
            foo[ 42 ] = 13;

            // csharp_space_between_square_brackets = false
            foo[42] = 13;
        }
    }
}