using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteersMiner
{
    public static class Helpers
    {
        public static IList<string> GetAges()
        {
            var list = new List<string>();
            list.Add("10-15 años");
            list.Add("15-18 años");
            list.Add("19-30 años");
            list.Add("31-49 años");
            list.Add("50+ años");
            return list;
        }

        public static IList<string> GetProvinces()
        {
            var list = new List<string>();
            list.Add("Bocas del Toro");
            list.Add("Coclé");
            list.Add("Colón");
            list.Add("Chiriquí");
            list.Add("Darién");
            list.Add("Herrera");
            list.Add("Los Santos");
            list.Add("Panamá");
            list.Add("Panamá Oeste");
            list.Add("Veraguas");
            return list;
        }

        public static IList<string> GetTimes()
        {
            var list = new List<string>();
            list.Add("Durante la semana");
            list.Add("Fines de semana");
            list.Add("Feriados");
            list.Add("Otro");
            return list;
        }

        public static IList<string> GetVolunteerType()
        {
            var list = new List<string>();
            list.Add("Participación en limpieza");
            list.Add("Caracterización y monitoreo de desechos");
            list.Add("Difusión de mensajes por redes");
            list.Add("Ayuda en organización de actividades");
            list.Add("Apoyo administrativo");
            list.Add("Participación en ferias");
            list.Add("Participación en eventos educativos");
            list.Add("Donación en efectivo o en especie");
            list.Add("Otro");
            return list;
        }

        public static IList<string> WhatDoYouDo()
        {
            var list = new List<string>();
            list.Add("Estudiante");
            list.Add("Profesional");
            return list;
        }
    }
}