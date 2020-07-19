using DemoAuthJWT.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoAuthJWT.Helpers
{
    public class AuthHelper
    {
        public static string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            //chave secreta
            var key = Encoding.ASCII.GetBytes("ZGVtby1hcGktand0");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Name.ToString()),
                    new Claim(ClaimTypes.Role, RoleFactory(user.Type))
                }),
                Expires = DateTime.UtcNow.AddHours(10),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private static string RoleFactory(int roleNumber)
        {
            switch (roleNumber)
            {
                case 1:
                    return "Director";

                case 2:
                    return "Manager";

                case 3:
                    return "Colaborator";


                default:
                    throw new Exception();
            }
        }
    }
}
