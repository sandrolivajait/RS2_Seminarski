using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace ServiceLayer.Interfaces
{
    public interface INarudzbaService
    {
        void InsertNarudzba(Narudzba narudzba, List<StavkaNarudzbe> stavke);
  
    }
}
