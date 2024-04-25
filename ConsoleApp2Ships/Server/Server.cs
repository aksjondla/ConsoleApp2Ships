using ConsoleApp2Ships.Field;
using ConsoleApp2Ships.movment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

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
            var ship = new Ship(new Position(0, 0, 0));
            var ship1 = new Ship(new Position(0, 0, 0));
            var listobj = new List<IMovable>() { ship, ship1 };
            var showobj = new ShowObject(listobj , FieldServer);
            var Ai = new AIMovment(listobj, FieldServer);

            while (true)
            {
                Console.Clear();
                create.Create();
                Ai.AIComand();

                showobj = new ShowObject(listobj, FieldServer);
                showobj.ShowObj();

                show.Show();
                Thread.Sleep(1);
            }
        }
    }
}
