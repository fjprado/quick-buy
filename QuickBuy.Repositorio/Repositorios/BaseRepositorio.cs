using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly QuickBuyContexto _quickBuyContexto;
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            _quickBuyContexto = quickBuyContexto;
        }
        public void Adicionar(TEntity entity)
        {
            _quickBuyContexto.Set<TEntity>().Add(entity);
            _quickBuyContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _quickBuyContexto.Set<TEntity>().Update(entity);
            _quickBuyContexto.SaveChanges();
        }

        public void Dispose()
        {
            _quickBuyContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return _quickBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _quickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            _quickBuyContexto.Remove(entity);
            _quickBuyContexto.SaveChanges();
        }
    }
}
