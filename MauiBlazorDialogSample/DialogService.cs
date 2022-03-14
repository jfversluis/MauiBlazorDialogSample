namespace MauiBlazorDialogSample
{
    internal class DialogService : IDialogService
    {
        public async Task<bool> DisplayConfirm(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}
