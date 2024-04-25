using ConsoleApp2Ships.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Server
{
    class Server
    {
        public IField FieldServer {  get; set; }
        public Server(IField _field)
        {
            FieldServer = _field;
        }

        public void ServerRun()
        {
            
            var create = new CreateField(FieldServer);
            var show = new ShowField(FieldServer);
            while (true)
            {

                create.Create();
                show.Show();
                Thread.Sleep(1000);
            }
        }
    }
}
