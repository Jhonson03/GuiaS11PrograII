using Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.DAO
{
    public class CreateVer
    {
        RegistroContext db = new RegistroContext();

        public void CreateEstu(Estudiante Es)
        {
                Estudiante Estu = new Estudiante();

                Estu.Nombres = Es.Nombres;
                Estu.Apellidos = Es.Apellidos;
                Estu.Edad = Es.Edad;
                Estu.Sexo = Es.Sexo;

                db.Add(Estu);
                db.SaveChanges();
        }

        public List<Estudiante> ListaEstudiante()
        {
            return db.Estudiante.ToList();
        }
    }
}
