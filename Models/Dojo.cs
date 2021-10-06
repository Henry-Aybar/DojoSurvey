using System.ComponentModel.DataAnnotations;
using System;

namespace DojoSurvey.Models
{
    public class Dojo
    {
        // Name, DojoLocation, FavLang, Comment

        public string Name {get;set;}

        public string DojoLocation {get;set;}
  
        public string FavLang {get;set;}

        public string Comment {get;set;}

    }

}