using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSolution
{

    /*
     {
      "firstname": "Roger",
      "lastname": "Moore",
      "age": "89",
      "isAlive": false,
      "address": {
        "streeAddress": "1 Main Street",
        "city": "London",
        "postCode": "N1 3xx"
      },
      "phoneNumbers": [
        {"type": "home", "number": "+61 03 1234 5678"},
        {"type": "mobile", "number": "+61 0405 111 222"},
        {"type": "work", "number": "+61 0405 555 222"}
      ]
    }
    */
    class jsonPerson
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        public List<phoneNum> phoneNumbers { get; set; }


        public class addr
        {
            public string streeAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }

        public class phoneNum
        {
            public string type { get; set; }
            public string number { get; set; }
        }

    }
}
