namespace CustomCode.Core.EditorConfig
{
    using System;

    public sealed class ConditionalDelegateCall
    {
        public void ShowCase()
        {
            // csharp_style_conditional_delegate_call = true:error
            OnFoo?.Invoke();

            // csharp_style_conditional_delegate_call = false:error
            if (OnFoo != null)
            {
                OnFoo();
            }
        }

        private event Action OnFoo;
    }
}