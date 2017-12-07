using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_10352606_CA_01
{
    class CA_File_Unit
    {
        public string RNumber { get; set; }
        public string Name { get; set; }
        public string DateShort { get; set; }
        public string Time { get; set; }
        public string Offset { get; set; }
        public string DateLong { get; set; }
        public int NoOfLines { get; set; }

        public string ChangedPaths { get; set; }
        public string Comments { get; set; }

    } // end Class
} // end Namespace
