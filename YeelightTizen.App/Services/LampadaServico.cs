using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeelightAPI;
using YeelightTizen.Interfaces;

namespace YeelightTizen.App.Services
{
    public class LampadaServico : ILampadaServico
    {
        protected Device Lampada;

        public LampadaServico()
        {

        }
        public async Task<Device> ObterDispositivo(string ip)
        {
            Lampada = new Device(ip);
            await Lampada.Connect();
            return Lampada;
        }
        public async Task<List<Device>> ObterDispositivos()
        {
            DeviceLocator.UseAllAvailableMulticastAddresses = true;
            List<Device> discoveredDevices = (await DeviceLocator.Discover()).ToList();
            return discoveredDevices;
        }
    }
}
