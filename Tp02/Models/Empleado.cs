using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp02.Models
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private int antiguedad;
        private const float sueldoBasico = 28080;
        private int edad;
        private double salario;
        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Empleado(string nombre, string apellido, string direccion, DateTime fechaNacimiento, DateTime fechaIngreso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIngreso = fechaIngreso;
            this.antiguedad = CalcularEdad(fechaIngreso);
            this.edad = CalcularEdad(fechaNacimiento);
            this.salario = CalcularSalario(antiguedad);
        }

        public int CalcularEdad(DateTime fecha)
        {
            int edad = (int)(((DateTime.Now - fecha).Days)/365.25);
            return edad;
        }

        public double CalcularSalario( int antiguedad)
        {
            double Salario;
            if (antiguedad > 20)
            {
                Salario = sueldoBasico + (sueldoBasico * 0.25)- (sueldoBasico* 0.15);
            }
            else
            {
                Salario = sueldoBasico + (sueldoBasico * (antiguedad/100) - (sueldoBasico * 0.15)) ;         
            }
            return Salario;
        }
    }
}
