using System;
using MinimalApi.Dominio.Enuns;

namespace MinimalApi.DTOs;

public class AdministradorDTO
{
    public string Email { get; set; }
    public string Senha { get; set; }
    public Perfil? Perfil { get; set; }
}
