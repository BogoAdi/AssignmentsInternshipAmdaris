using DesignPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy
{
    internal class SportFieldThirdParty : ISportFieldProvider
    {

        public void ListSportFields()
        {
            throw new NotImplementedException();
        }

        public void GetField(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddSportField(SportField sportField)
        {
            throw new NotImplementedException();
        }
    }
}
