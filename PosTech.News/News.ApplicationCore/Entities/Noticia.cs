using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationCore.Entities
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }        
        public DateTime DataPublicacao { get; set; }
        public string Autor { get; set; }
    }
}
