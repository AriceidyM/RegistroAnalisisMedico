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
    public class AnalisisBLL
    {
        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Analisis.Add(analisis) != null)
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

        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Analisis.Find(analisis.AnalisisId);
                foreach (var item in Anterior.Resultado)
                {
                    if (!analisis.Resultado.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(analisis).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

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
                Analisis analisis = contexto.Analisis.Find(id);

                if (analisis != null)
                {
                    contexto.Entry(analisis).State = EntityState.Deleted;
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

        public static Analisis Buscar(int id)
        {
            Contexto db = new Contexto();
            Analisis analisis = new Analisis();
            try
            {
                analisis = db.Analisis.Find(id);

                analisis.Resultado.Count();
            }
            catch
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }
            return analisis;
        }

        public static List<Analisis> GetList(Expression<Func<Analisis, bool>> expression)
        {
            List<Analisis> analisis = new List<Analisis>();
            Contexto contexto = new Contexto();
            try
            {
                analisis = contexto.Analisis.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return analisis;
        }
    }
}
