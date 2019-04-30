using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class StopWatch
    {
        public TimeSpan StartTime { get; private set; }
        public TimeSpan StopTime { get; private set; }
        public TimeSpan SumTime { get; private set; }
        private bool _isRunning;

        public StopWatch()
        {
            UserInterface();
        }

        public void UserInterface()
        {
            string input;
            Console.WriteLine(@"Comandos: 
                start: Inicia el stopwatch
                split: Marca el tiempo actual
                reset: Reinicia el stopwatch
                pause: Pausa el stopwatch
                fuera: Cierra la aplicacion
                help: Muestra los comandos");

            input = Console.ReadLine().ToLower();

            while (!input.Equals("fuera"))
            {
                switch (input)
                {
                    case "start":
                        Start();
                        Console.WriteLine(SumTime);
                        break;
                    case "split":
                        Split();
                        Console.WriteLine("Tiempo transcurrido {0}", StopTime - StartTime);
                        break;
                    case "reset":
                        Reset();
                        break;
                    case "pause":
                        Pause();
                        Console.WriteLine("Tiempo transcurrido {0}", SumTime);
                        break;
                    case "help":
                        Console.WriteLine(@"Comandos: 
                            start: Inicia el stopwatch
                            split: Marca el tiempo actual
                            reset: Reinicia el stopwatch
                            pause: Pausa el stopwatch
                            fuera: cierra la aplicacion
                            help: muestra los comandos");
                        break;

                    default:
                        Console.WriteLine("Comando invalido");
                        break;

                }

                input = Console.ReadLine();

            }
        }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("El stopwatch ya esta corriendo.");
            _isRunning = true;
            StartTime = DateTime.Now.TimeOfDay;
        }

        public void Split()
        {

            if (!_isRunning)
                throw new InvalidOperationException("El stopwatch no esta corriendo.");
            StopTime = DateTime.Now.TimeOfDay;
        }


        public void Reset()
        {
            StartTime = TimeSpan.Zero;
            StopTime = TimeSpan.Zero;
            SumTime = TimeSpan.Zero;
            _isRunning = false;
        }

        public void Pause()
        {
            if (!_isRunning)
                throw new Exception("El stopwatch no esta corriendo.");
            _isRunning = false;
            StopTime = DateTime.Now.TimeOfDay;
            SumTime = StopTime - StartTime + SumTime;
        }
    }
}
