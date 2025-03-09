using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPmod4
{
    class DoorMachine
    {
        // Enum untuk mendefinisikan status pintu
        public enum State { Terkunci, Terbuka }

        // Variabel untuk menyimpan status pintu saat ini
        private State currentState;

        // Konstruktor: Pintu awalnya terkunci
        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        // Method untuk membuka pintu
        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        // Method untuk mengunci pintu
        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}
