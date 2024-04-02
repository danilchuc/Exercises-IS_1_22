using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int EngIneState;

        public void Start()
        {
            Console.WriteLine("Start");
            EngIneState = StateStarted;



        }
        public void Stop()
        {
            Console.WriteLine("Stop");
            EngIneState = StateStopped;
        }

        public string GetState()
        {
            return EngIneState == StateStopped ? "STOPPED" : "STARTED";
        }

    }
}
    

