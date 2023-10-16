/*Nota: Todo ha sido echo como en la clase lo unico
que las separe en carpetas para un mejor orden*/

using Registro.DAO;
using Registro.Models;

Estudiante Estu = new Estudiante();
CreateVer db = new CreateVer();
bool Vali1 = true;

Console.WriteLine("Registro de estudiantes");

while (Vali1 == true)
{
    Console.Write("\n\tMenu  \n1- Agregar Estudiantes \n2- Ver lista de estudiantes \n3- Salir \n-> ");
    var menu = int.Parse(Console.ReadLine());

    bool Vali2 = true;

    switch (menu)
    {
        #region Agregar
        case 1:
            while (Vali2 == true)
            {
                Console.WriteLine("\n\tAgregar un nuevo estudiante");

                Console.Write("\nIngrese los nombres: ");
                Estu.Nombres = Console.ReadLine();
                Console.Write("Ingrese los apellidos: ");
                Estu.Apellidos = Console.ReadLine();
                Console.Write("Ingrese la edad: ");
                Estu.Edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el genero F = Femenino // M = Masculino: ");
                Estu.Sexo = Console.ReadLine().ToUpper();
                db.CreateEstu(Estu);

                Console.WriteLine($"\nLos datos de {Estu.Nombres} {Estu.Apellidos} han sido agregados con exito");
                bool Vali3 = false;
                do
                {
                    Console.Write("\nDesea seguir agregando otro estudiante S/N: ");
                    var menu3 = Console.ReadLine().ToLower().Trim();

                    switch (menu3)
                    {
                        case "s":
                            Vali1 = true;
                            Vali3 = true;
                            break;
                        case "n":
                            Vali2 = false;
                            Vali3 = true;
                            break;
                        default:
                            Console.WriteLine("\nError: Se ingresó una letra diferente de 's' o 'n'");
                            break;
                    }
                } while (!Vali3);
            }
            break;
        #endregion

        #region Ver
        case 2:
            var ListaEstudiante = db.ListaEstudiante();
            int IdWidth = 5;
            int NomWidth = 20;
            int ApelliWidth = 20;
            int EdadWidth = 6;
            int SexoWidth = 6;

            Console.WriteLine($"\n{"Id".PadRight(IdWidth)} {"Nombres".PadRight(NomWidth)} {"Apellidos".PadRight(ApelliWidth)} {"Edad".PadRight(EdadWidth)} {"Sexo".PadRight(SexoWidth)}");

            Console.WriteLine(new string('-', IdWidth + NomWidth + ApelliWidth + EdadWidth + SexoWidth + 8));

            foreach (var estudiante in ListaEstudiante)
            {
                Console.WriteLine($"{estudiante.Id.ToString().PadRight(IdWidth)} {estudiante.Nombres.PadRight(NomWidth)} {estudiante.Apellidos.PadRight(ApelliWidth)} {estudiante.Edad.ToString().PadRight(EdadWidth)} {estudiante.Sexo.PadRight(SexoWidth)}   |");
            }
            Console.WriteLine(new string('-', IdWidth + NomWidth + ApelliWidth + EdadWidth + SexoWidth + 8));

            break;
        #endregion

        #region Salir

        case 3:
            Vali1 = false;
            break;

        #endregion
    }
}

Console.WriteLine("\nCreado por: Jhonson Leiva 愛");