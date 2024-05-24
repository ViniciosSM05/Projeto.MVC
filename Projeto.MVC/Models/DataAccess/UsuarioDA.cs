﻿using Dapper;
using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.DataAccess.Base;

namespace Projeto.MVC.Models.DataAccess
{
    public class UsuarioDA(IConfiguration config) : BaseDA(config)
    {
        public IEnumerable<Usuario> GetAll()
        {
            using var conexao = GetConnection();
            return conexao.GetAll<Usuario>();    
        }

        public Usuario Add(Usuario usuario)
        {
            using var conexao = GetConnection();
            conexao.Execute(@"
                INSERT INTO usuario(id, nome, cpfcnpj, email, senha, celular, data_nascimento) 
                VALUES(@id, @nome, @cpfcnpj, @email, @senha, @celular, @data_nascimento)
            ", new {
                id = usuario.Id,
                nome = usuario.Nome,
                cpfcnpj = usuario.Cpfcnpj,
                uf = usuario.Cpfcnpj,
                email = usuario.Email,
                senha = usuario.Senha,
                celular = usuario.Celular,
                data_nascimento = usuario.Data_Nascimento
            });
            return usuario;  
        }

        public Usuario Update(Usuario usuario)
        {
            using var conexao = GetConnection();
            conexao.Execute(@"
                UPDATE usuario 
                    SET nome = @nome, 
                    cpfcnpj = @cpfcnpj,
                    email = @email,
                    senha = @senha,
                    celular = @celular,
                    data_nascimento = @data_nascimento
                WHERE id = @id", new
            {
                id = usuario.Id,
                nome = usuario.Nome,
                cpfcnpj = usuario.Cpfcnpj,
                uf = usuario.Cpfcnpj,
                email = usuario.Email,
                senha = usuario.Senha,
                celular = usuario.Celular,
                data_nascimento = usuario.Data_Nascimento
            });
            return usuario;
        }

        public int Delete(Guid id)
        {
            using var conexao = GetConnection();
            return conexao.Execute("DELETE FROM usuario WHERE id = @id", new { id });
        }
    }
}
