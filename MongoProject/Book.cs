using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject
{
    class Book
    {
        public MongoDB.Bson.ObjectId id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Isbn { get; set; }
        public string Category { get; set; }
        
    }
}
