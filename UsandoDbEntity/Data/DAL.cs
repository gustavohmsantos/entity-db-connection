using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsandoDbEntity.Models;

namespace UsandoDbEntity.Data
{
    internal class DAL<T> where T : class
    {
        public readonly UsandoDbEntityContext context;

        public DAL(UsandoDbEntityContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> SelecionarTudo()
        {
            return context.Set<T>().ToList();
        }

        public void Inserir(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Atualizar(T obj)
        {
            context.Set<T>().Update(obj);
            context.SaveChanges();
        }
        public void Deletar(T obj)
        {
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }

        public T? BuscarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }


    }
}
