using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.Entities;
using TicketCore.Domain.Interfaces;
using TicketCore.Infrastructure.Context;

namespace TicketCore.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CriarUsuario(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
