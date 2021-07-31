using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Modulo8DesSoftware.Repositorio.Entidade;
using Modulo8DesSoftware.Repositorio.Interfaces;

namespace Modulo8DesSoftware.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio usuarioRepos;
        private IConfiguration _config;
        public UsuarioController(IUsuarioRepositorio usuarioRepository, IConfiguration Configuration)
        {
            usuarioRepos = usuarioRepository;
            _config = Configuration;
        }

        [HttpPost(nameof(GetToken))]
        public string GetToken(Usuario user)
        {
            var usuario = usuarioRepos.Consultar(user.User);
            if (CalculateMD5Hash(user.Senha) == usuario.Senha)
            {
                return GerarTokenJWT();
            }
            return string.Empty;
        }

        [HttpPost(nameof(InsertUser))]
        public void InsertUser(Usuario user)
        {
            user.Senha = CalculateMD5Hash(user.Senha);
            usuarioRepos.Adicionar(user);
        }

        private string CalculateMD5Hash(string input)
        {
            // Calcular o Hash
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Converter byte array para string hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private string GerarTokenJWT()
        {
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.UtcNow.AddSeconds(120);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer: issuer, audience: audience, expires: expiry, signingCredentials: credentials);
            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}