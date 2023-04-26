
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace app_web_backend.Models
{
	[Table("Veículos")]
	public class Veiculo
	{
		[Key]
        public int Id { get; set; }

		[Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }

		[Required(ErrorMessage = "Obrigatório informar a placa!")]
		public string Placa { get; set;}
    }
}
