using ClientApp.Data;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Pages
{
    public partial class Login
    {

        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        string login;
        string password;
        ClientSOAP clientSOAP = new();
        private void Cancel()
        {
            MudDialog.Cancel();
        }

        void Log_in()
        {
            clientSOAP.login = login;
            clientSOAP.password_hash = password;
            var result = soap.Login(clientSOAP);
            if (result != null)
            {
                localStorage.SetItemAsync("login", result);
                navigationManager.NavigateTo("/", true);
            }
            else Snackbar.Add("Неверный логин или пароль", Severity.Error);
        }
        bool isShow;
        InputType PasswordInput = InputType.Password;
        string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;

        void ButtonTestclick()
        {
            if (isShow)
            {
                isShow = false;
                PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                PasswordInput = InputType.Password;
            }
            else
            {
                isShow = true;
                PasswordInputIcon = Icons.Material.Filled.Visibility;
                PasswordInput = InputType.Text;
            }
        }
    }
}
