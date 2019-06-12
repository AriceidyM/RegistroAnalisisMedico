using RegistroAnalisisMedico.DAL;
using RegistroAnalisisMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.BLL
{
    public class TipoAnalisisBLL
    {
        public static bool Guardar(TiposAnalisis tipoAnalis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.TipoAnalis.Add(tipoAnalis) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Modificar(TiposAnalisis tipoAnalis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoAnalis).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                TiposAnalisis TiposAnalis = contexto.TipoAnalis.Find(id);

                if (TiposAnalis != null)
                {
                    contexto.Entry(TiposAnalis).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    contexto.Dispose();
                    paso = true;
                }


            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static TiposAnalisis Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TiposAnalisis TiposAnalis = new TiposAnalisis();
            try
            {
                TiposAnalis = contexto.TipoAnalis.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return TiposAnalis;
        }

        public static List<TiposAnalisis> GetList(Expression<Func<TiposAnalisis, bool>> expression)
        {
            List<TiposAnalisis> Articulos = new List<TiposAnalisis>();
            Contexto contexto = new Contexto();
            try
            {
                Articulos = contexto.TipoAnalis.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Articulos;
        }
    }
}
