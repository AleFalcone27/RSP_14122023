﻿using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class Paramedico : IServidorPublico
    {
        private static List<EEmergencia> emergenciasAtendibles;

        static Paramedico()
        {
            Paramedico.emergenciasAtendibles = new List<EEmergencia>() { EEmergencia.Accidentes_De_Trafico, EEmergencia.Desastres_Naturales, EEmergencia.Emergencias_Medicas };
        }

        public string Imagen { get { return $"./assets/{this.GetType().Name}.gif"; } }

        public void Atender(Emergencia emergencia)
        {
            if (!emergenciasAtendibles.Any(e => e.Equals(emergencia)))
            {
                throw new ServidorPublicoInvalidoException("El servidor publico no puede atender este tipo de emergencias");
            }
        }
    }
}
