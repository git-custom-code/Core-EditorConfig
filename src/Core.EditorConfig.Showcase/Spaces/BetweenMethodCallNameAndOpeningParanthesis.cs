namespace CustomCode.Core.EditorConfig
{
    public sealed class BetweenMethodCallNameAndOpeningParanthesis
    {
        public void ShowCase()
        {
            object foo = null;

            // csharp_space_between_method_call_name_and_opening_parenthesis = true
            var result = foo.ToString ();

            // csharp_space_between_method_call_name_and_opening_parenthesis = false
            result = foo.ToString();
        }
    }
}