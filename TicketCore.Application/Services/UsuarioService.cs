using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Application.Dtos;
using TicketCore.Application.Interfaces;
using TicketCore.Domain.Entities;
using TicketCore.Domain.Interfaces;

namespace TicketCore.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task CriarUsuario(UsuarioDto dto)
        {
            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email
            };

            usuario.SenhaHash = new PasswordHasher<Usuario>().HashPassword(usuario, dto.Senha);

            await _usuarioRepository.CriarUsuario(usuario);
        }
    }
}
