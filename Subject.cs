using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Data
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
