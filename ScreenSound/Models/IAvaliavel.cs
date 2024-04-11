using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models;
internal interface IAvaliavel
{
    public List<Avaliacao> Notas { get; }
    public double Media { get; }
    
    public void Add(Avaliacao nota);
}
