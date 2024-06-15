namespace CRUD_Students2.Entities
{
//     public class Doctor
//     {
//         public Doctor()
//         {
//              ListEspecialidad = new List<Especialidad>();
//         }
        
// public string Nombre {get; set;} 
// public int Edad {get; set;} 
// public string Sexo {get; set;} 
// public Guid Id {get; set;}  

// public Guid? EspecialidadId {get; set;}
// public Especialidad? Especialidad {get; set;}

//        public Categoria? Categoria{get; set;}
//          public List<Especialidad> ListEspecialidad { get; set; }
//     }
public class Doctor
    {
        public Doctor()
        {
            ListEspecialidad = new List<Especialidad>();
        }

        public string Nombre { get; set; } 
        public int Edad { get; set; } 
        public string Sexo { get; set; } 
        public Guid Id { get; set; }  

        public Guid? EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
public Guid? CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public List<Especialidad> ListEspecialidad { get; set; }
    }

}