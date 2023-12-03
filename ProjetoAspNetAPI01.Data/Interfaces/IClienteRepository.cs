using ProjetoAspNetAPI01.Data.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoAspNetAPI01.Data.Interfaces
{
    public interface IClienteRepository
    {
        void Inserir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(Cliente cliente);

        List<Cliente> Consultar();
        Cliente ObterPorId(Guid idCliente);
    }
}
