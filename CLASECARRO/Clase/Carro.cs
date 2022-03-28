using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASECARRO.Clase
{
    internal class Carro
    {
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public String Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;


        public Carro(string _marca, int _modelo, string _color)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            this.velocidad_actual = 0;
        }





        public string Acelerar()
        {
            if(Encendido == 0)
            {
                return $"El carro esta apagado, no se puede acelerar";
            }
            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += 10;
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual=MAXVELOCIDAD;
                mensaje = $"Cuidado, vas a maxima velocidad, rapid y furioso";
            }
            Console.WriteLine(mensaje);
            return mensaje;

        }




        public string Acelerar(int acelerarkph)
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, no se puede acelerar";
            }
            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += acelerarkph;
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"Cuidado, vas a maxima velocidad, rapidO y furioso";
            }
            Console.WriteLine(mensaje);
            return mensaje;

        }



        public string GetVelocidadActual()
        {
            return $"Vamos a velocidad {velocidad_actual} KPH";
        }




        public string Desacelerar()
        {
            string mensaaje = "";
            if (velocidad_actual > 0)
            {
                velocidad_actual -= 8;
                mensaaje = $"Estas bajando la velocidad a: {velocidad_actual} KPH";
            }
            else
            {
                mensaaje = $"Ya estas  en la velocidad minima";
            }
            Console.WriteLine(mensaaje);
            return mensaaje;
        }





        public string VelRedAc()
        {
            return $"Redujiste la velocidad a: {velocidad_actual} KPH ";
        }

        public string frenar()
        {
            string men = "";
            if(velocidad_actual > 0)
            {
                velocidad_actual= velocidad_actual -velocidad_actual;
                men= $"Frenaste de golpe, ten cuidado!";
            }
            else
            {
                men=$"Esta parado, no es necesario frenar de un solo";
            }
            Console.WriteLine(men);
            return men;
        }

        public string Velfren()
        {
            return $"Paraste el carro ahora tu velocidad es de: {velocidad_actual} KPH";
        }




        public void Encender()
        {
            if(Encendido == 0)
            {
                Encendido = 1;
                Console.WriteLine("Brururururururn carro encendido");
                velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("ups el carro ya esta encendido");
            }
        }





        public void DameInformatcion()
        {
            Console.WriteLine("Soy un carro marca: " + Marca, "y mi modelo es: " + Modelo);
        }


        public string Bocinar()
        {
            return $"PIP PIP PIIIP PIIIIIIIIP, apurense";
        }




        public void Apagar()
        {
            if (Encendido == 1)
            {
                Encendido = 0;
                Console.WriteLine($"Apagaste el carro");
            }
            else
            {
                Console.WriteLine("Ups el carro ya esta apagado");
            }
        }

    }
}
