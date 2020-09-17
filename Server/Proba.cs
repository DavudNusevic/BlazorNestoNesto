using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNestoNesto.Server
{
    public class Proba : Hub
    {
        public void Foo(string poruka, int br)
        {
            for (int i = 0; i < br; i++)
            {
                Console.WriteLine($"Klijent kaze: {poruka}");
            }
        }
    }
}
