using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Dtos.Requests;
using AgendaApp.Domain.Dtos.Responses;

namespace AgendaApp.Domain.Interfaces.Services
{
    public interface IPessoaDomainService
    {
        CriarPessoaResponse Criar(CriarPessoaRequest request);

        AutenticarPessoaResponse Autenticar(AutenticarPessoaRequest request);
    }
}
