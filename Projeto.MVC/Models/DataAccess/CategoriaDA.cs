﻿using Dapper;
using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.DataAccess.Base;

namespace Projeto.MVC.Models.DataAccess
{
    public class CategoriaDA(IConfiguration config) : BaseDA(config)
    {
        public IEnumerable<Categoria> GetAll()
        {
            using var conexao = GetConnection();
            return conexao.GetAll<Categoria>();    
        }

        public Categoria Add(Categoria categoria)
        {
            using var conexao = GetConnection();
            conexao.Execute("INSERT INTO categoria(id, nome) VALUES(@id, @nome)", new {
                id = categoria.Id,
                nome = categoria.Nome,
            });
            return categoria;  
        }

        public Categoria Update(Categoria categoria)
        {
            using var conexao = GetConnection();
            conexao.Execute("UPDATE categoria SET nome = @nome WHERE id = @id", new
            {
                id = categoria.Id,
                nome = categoria.Nome,
            });
            return categoria;
        }

        public int Delete(Guid id)
        {
            using var conexao = GetConnection();
            return conexao.Execute("DELETE FROM categoria WHERE id = @id", new { id });
        }
    }
}
