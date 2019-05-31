using BibliotecaPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaContrato
{
    public class Contrato
    {
        public long numeroContrato { get; set; }
        public string creacion { get; set; }
        public string termino { get; set; }
        public string fechaHoraInicio { get; set; }
        public string fechaHoraTermino { get; set; }
        public string direccion { get; set; }
        public bool vigente { get; set; }
        public string tipo { get; set; }
        public string cliente { get; set; }
        public string observacion { get; set; }

        public Contrato()
        {
            this.Init();
        }

        public Contrato(long numeroContrato, string creacion, string termino, 
            string fechaHoraInicio, string fechaHoraTermino, string direccion,
            bool vigente, string tipo, string cliente,string obs )
        {
            this.numeroContrato = numeroContrato;
            this.creacion = creacion;
            this.termino = termino;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraTermino = fechaHoraTermino;
            this.direccion = direccion;
            this.vigente = vigente;
            this.tipo = tipo;
            this.cliente = cliente;
            this.observacion = obs;

        }

        public void Init()
        {
            numeroContrato = 0;
            creacion = string.Empty;
            termino = string.Empty;
            fechaHoraInicio = string.Empty;
            fechaHoraTermino = string.Empty;
            direccion = string.Empty;
            vigente = true;
            tipo = string.Empty;
            cliente = string.Empty;
            observacion = string.Empty;
        }

    }
}
