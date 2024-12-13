using AgendaApp.UI.Dtos;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace AgendaApp.UI.Services
{
    public class AuthService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly NavigationManager _navigationManager;

        public AuthService(ILocalStorageService localStorageService, NavigationManager navigationManager)
        {
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;
        }

        public async Task SignIn(AutenticarPessoaResponseDto dto)
        {
            await _localStorageService.SetItemAsync("usuario", dto);
            _navigationManager.NavigateTo("/consultar-tarefas", true);
        }
    }
}
