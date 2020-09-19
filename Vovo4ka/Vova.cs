using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vovo4ka
{
    public class Vova
    {
        public int Nomer { get; set; }

        public string who()
        {
            switch (Nomer)
            {
                case 1:
                case 3:
                    return "Стекло не разбилось";
                case 2:
                case 5:
                    return "Новое стекло вставлял папа Вовочки";
                case 4:
                case 6:
                case 7:
                    return "Милиционеры вставляли новое стекло";
                default:
                    return "Такого раза не было (пока что)";
            }
        }
    }
}
