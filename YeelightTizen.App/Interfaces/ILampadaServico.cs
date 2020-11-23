using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeelightAPI;

namespace YeelightTizen.Interfaces
{
    public interface ILampadaServico
    {
        Task<Device> ObterDispositivo(string ip);
        Task<IEnumerable<Device>> ObterDispositivos();
    }
}
