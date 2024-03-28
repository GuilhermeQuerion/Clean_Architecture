using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain.Entities
{
    public class Tarefa
    {
        public Guid? Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
