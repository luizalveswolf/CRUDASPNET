using CRUDASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDASPNetMVC.DAO
{
    public class UsuariosDAO
    {

        public void Adiciona(Usuario usuario)
        {
            using (var context = new EstoqueContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using(var context = new EstoqueContext())
            {
                return context.Usuarios.ToList();
            }
        }

        public Usuario BuscaPorId(int id)
        {
            using (var context = new EstoqueContext())
            {
                return context.Usuarios.Find(id);
            }
        }

        public void Atualiza(Usuario usuario)
        {
            using (var context = new EstoqueContext())
            {
                context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using(var context = new EstoqueContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }

    }
}