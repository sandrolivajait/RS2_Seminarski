using AutoMapper;
using Model.Models;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ServiceLayer.Classes
{
    public class AuthService : IAuthService
    {
        private readonly IRepository<Model.Database.Administrator> administratorRepository;
        private readonly IMapper mapper;

        public AuthService(IRepository<Model.Database.Administrator> administratorRepository, IMapper mapper)
        {
            this.administratorRepository = administratorRepository;
            this.mapper = mapper;
        }

        public Administrator AuthenticirajAdmin(string username, string password)
        {
            var user = administratorRepository.GetAllQueryable().FirstOrDefault(x => x.Email == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, password);

                if (hashedPass == user.LozinkaHash)
                {
                    return mapper.Map<Model.Models.Administrator>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
