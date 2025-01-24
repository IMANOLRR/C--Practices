public abstract class MienbroDeLaComunidad
{
    public int ID { get; set; }
    public string Name{ get; set; }

    public abstract void ShowInfo();
}

public class Estudiantes : MienbroDeLaComunidad 
{
    public string Career { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Estudiante: {Name}, ID: {ID}, Carrera: {Career}");
    }      
}

public class ExAlumnos : MienbroDeLaComunidad 
{
    public int Graduation { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Ex Alumno: {Name}, ID: {ID}, Carrera: {Graduation}");
    }
}

public abstract class Empleados : MienbroDeLaComunidad 
{
    public double Salary { get; set; }

}

public class Administrativo : Empleados 
{
    public string Area { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Administrativo {Name}, Id: {ID}, Area: {Area}, Salario: {Salary}");
    }
}

public class Docente : Empleados
{
    public string Departament { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Docente: {Name}, Id: {ID}, Area: {Departament}, Salario: {Salary}");
    }
}

public abstract class Administrador : Docente 
{
    public string Post { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Administrador: {Name}, Cargo {Post}, Departamento: {Departament} Salario: {Salary}");
    }
}

public class Maestro : Docente
{
    public string Subject { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Maestro: {Name}, ID: {ID} ,Materia: {Subject}, Departamento: {Departament} Salario: {Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<MienbroDeLaComunidad> Comunnity = new List<MienbroDeLaComunidad> 
        {
            new Estudiantes { Name = "Imanol", ID = 20240256, Career = "Desarrollo de Software" },
            new ExAlumnos {Name = "Richard", ID = 20200853, Graduation = 12/08/2022 },
            new Maestro {Name = "Starling", ID = 010101, Subject = "Proramacion", Departament = "Tecnologico", Salary = 123435},
            new Docente {Name = "Anabel", ID = 04582, Departament = "Contabilidad", Salary = 65000 },
        };

        foreach (var Mienbro in Comunnity) 
        {
            Mienbro.ShowInfo();
        }
    }
}