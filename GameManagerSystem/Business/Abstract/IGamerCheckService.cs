using GameManagerSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIsRealPerson(Gamer gamer);
    }
}
