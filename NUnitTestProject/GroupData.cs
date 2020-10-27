using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject
{
    public class GroupData
    {
        public GroupData(string name,string decsriprion,string type)
        {
            this.name = name;
            this.type = type;
            this.decsriprion = decsriprion;
        }

        public string name { get; set; }
        public string decsriprion { get; set; }
        public string type { get; set; }

    }

}
