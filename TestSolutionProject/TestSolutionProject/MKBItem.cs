using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutionProject
{
    public class MKBItem
    {
        private String Id {  get; set; }
        private String code { get; set; }
        private String name { get; set; }
        public MKBItem(String Id, String code, String name) { 
            this.code = code;
            this.name = name;
            this.Id = Id;
        }
        public String getCode()
        {
            return code;
        }
        public String getId()
        {
            return Id;
        }
        public String getName()
        {
            return name;
        }

    }
}
