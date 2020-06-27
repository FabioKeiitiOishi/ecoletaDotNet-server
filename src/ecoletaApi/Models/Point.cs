using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ecoletaApi.Models
{
  public class Point
  {
    [Key]
    public int Id { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    [MaxLength (60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
    [MinLength (3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
    public string Name { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    [EmailAddress (ErrorMessage = "Este campo deve estar em formato de e-mail")]
    public string Email { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    [Phone(ErrorMessage = "Este campo deve ter formato de telefone")]
    public string Whatsapp { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    public decimal Latitude { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    public decimal Longitude { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    public string City { get; set; }
    [Required (ErrorMessage = "Este campo é obrigatório")]
    public string UF { get; set; }
    public List<Item> Items { get; set; }
  }
}