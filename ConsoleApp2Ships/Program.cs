using ConsoleApp2Ships.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2Ships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new Server.Server(new Field.Field(10, 100));
            server.ServerRun();
        }
    }
}
