using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    public class AvisosTrafico : IAvisos
    {
        private string fechaAviso;
        private string remitente;
        private string mensaje;

        public AvisosTrafico()
        {
            this.fechaAviso = "";
            this.remitente = "DGT - Dirección General de Tránisto";
            this.mensaje = "Sanción cometida.\nPague antes de 3 días y se beneficiará en una reducción en la sanción del 50%";
        }

        public AvisosTrafico(string fechaAviso, string remitente, string mensaje)
        {
            this.fechaAviso = fechaAviso;
            this.remitente = remitente;
            this.mensaje = mensaje;
        }

        public string GetFecha()
        {
            return fechaAviso;
        }

        public void MostrarAviso()
        {
            Console.WriteLine($"Nuevo aviso recibido el: {fechaAviso}." +
                $"\nEnviado por: {remitente}." +
                $"\nMensaje:\n{mensaje}.");
        }
    }
}
