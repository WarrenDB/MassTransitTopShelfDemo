using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Topshelf;

namespace MicroChirper
{
    class Program
    {

        static void Main()
        {
            HostFactory.New(x => x.Service<MicroChirpBot>());
        }
    }

    class MicroChirpBot : Topshelf.ServiceControl
    {
        private readonly System.Timers.Timer _timer;
        public MicroChirpBot()
        {
            _timer = new System.Timers.Timer(1000) {AutoReset = true};
            _timer.Elapsed += (sender, eventArgs) => NewEmission();
        }

        private void NewEmission() { throw new NotImplementedException(); }

        public bool Start(HostControl hostControl) { _timer.Start(); return true; }
        public bool Stop(HostControl hostControl) { _timer.Stop(); return true; }
    }
}
