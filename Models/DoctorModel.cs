using CRUD_Students2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_Students2
{
    public class DoctorModel
    {
        public DoctorModel()
        {
            
        }
        
public string Nombre {get; set;} 
public int Edad {get; set;} 
public string Sexo {get; set;} 
public Guid Id {get; set;} 

public Guid? CategoriaId { get; set; }

public CategoryModel? Categoria { get; set; }

public string? CategoriaName { get; set; }

public List<SelectListItem> ListCategoria { get; set; }

public Guid? EspecialidadId { get; set; }

public EspecialidadModel? Especialidad { get; set; }

public string? Especialidad1 { get; set; }

public List<SelectListItem> ListEspecialidad{ get; set; }


    }
}