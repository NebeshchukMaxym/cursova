using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class StudentMark
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public Mark Mark { get; set; }
        public MarkType MarkType { get; set; }
    }
}
