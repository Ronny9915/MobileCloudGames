using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Item
    {
        [Key]
        public int CharID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Altura { get; set; }

        public int Dano { get; set; }

        

    }
}