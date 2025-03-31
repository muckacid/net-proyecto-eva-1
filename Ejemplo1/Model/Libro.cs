using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.Model
{
    class Libro
    {
        //private int id;
        //public void setId(int id)
        //{
        //    this.id = id;
        //}

        public Libro()
        {
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Isbn { get; set; }
        
    }
}
