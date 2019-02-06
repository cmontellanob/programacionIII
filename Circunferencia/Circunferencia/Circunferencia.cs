using System;


namespace Circunferencia
{
    class Circunferencia
    {
        //Atributo privado
        private double _dblRadio;
        // Propiedad pública
        public double Radio
        {
            get
            {
                return _dblRadio;
            }
            set
            {
                _dblRadio = value;
                if (_dblRadio < 0)
                {
                    _dblRadio = 0;
                    throw new Exception("No se permite un valor negativo");
                    }
            }
        }
        // Método para calcular el área
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
        // Método para calcular el Perímetro
        public double CalcularPerimetro()
        {
            return Math.PI * Radio * 2;
        }
        // Delegado público
        public delegate double Operacion();
        // Método que recibe como parámetro el método que desea invocar(del tipo del delegado)
    public double Calcular(Operacion miOperacion)
        {
            double dblResultado = miOperacion();
            return dblResultado;
        }
    }

}

