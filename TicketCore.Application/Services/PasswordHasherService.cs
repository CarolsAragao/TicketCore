using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Application.Interfaces;
using TicketCore.Domain.Entities;

namespace TicketCore.Application.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {
        private readonly PasswordHasher<Usuario> _passwordHasher = new();
        public string HashPassword(Usuario usuario, string senha)
        {
            return _passwordHasher.HashPassword(usuario, senha);
        }

        public bool VerifyPassword(Usuario usuario, string senha, string senhaHash)
        {
            var result = _passwordHasher.VerifyHashedPassword(usuario, senhaHash, senha);

            return result == PasswordVerificationResult.Success
                || result == PasswordVerificationResult.SuccessRehashNeeded;
        }
    }
}
