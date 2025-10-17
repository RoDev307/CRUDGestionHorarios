using proyectoFinalDAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalDAE.Clases
{
    internal class Gestor
    {
        //Metodo para añadir docentes
        public void agregar(Docente docente)
        {
            using (var context = new SistemaHorariosItcaContext())
            {
                context.Add(docente);
                context.SaveChanges();
            }
        }
        public void actualizar(Docente docente)
        {
            using (var context = new SistemaHorariosItcaContext())
            {
                context.Update(docente);
                context.SaveChanges();
            }
        }
        //Metodo eliminar
        public void eliminar(Docente docente)
        {
            using (var context = new SistemaHorariosItcaContext())
            {
                context.Remove(docente);
                context.SaveChanges();
            }
        }
        public List<VwDocentesInformacion> listarDocentes()
        {
            using (var context = new SistemaHorariosItcaContext())
            {
                var lista = context.VwDocentesInformacions.ToList();
                return lista;
            }
        }
    }
}
