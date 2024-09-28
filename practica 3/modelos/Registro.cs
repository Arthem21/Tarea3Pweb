using practica_3.Pages;
using System;
using System.ComponentModel.DataAnnotations;

public class Registro {
    
    public string ID {set; get;} =string.Empty;

    [Required(ErrorMessage= "El campo descripcion es requerido")]
    [MinLength (10, ErrorMessage= "El registro debe incluir por lo menos 10 caracteres") ]
    public string descripcion {set; get;}=" ";
    public DateOnly fecha {set;get;}
    public double costo {set;get;}= 0;
    [Required(ErrorMessage= "El campo costo es requerido")]
    public int muertos {set;get;}= 0;
    public int heridos {set;get;}= 0;
    public int vehiculos {set;get;}= 0;
    
  
}