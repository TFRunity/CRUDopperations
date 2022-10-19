using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SiteCtor.Models
{
    public class FirstSiteModel
    {
        //Айди
        public int Id { get; set; }
        //Имя
        public string Name { get; set; }
        //Описание
        public string Description { get; set; }
    }
}
