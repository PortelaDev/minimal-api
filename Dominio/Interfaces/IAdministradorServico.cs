using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace minimal_api.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador Login(LoginDTO loginDTO);
        Administrador Incluir(Administrador administrador);
        IEnumerable<Administrador> Todos(int? pagina);

        Administrador BuscarPorId(int id);
    }
}