using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService {
    public string getUwu(string input) {
        string uwu = "";

        uwu = input.Replace("l", "w").Replace("r", "w").Replace("o", "owo").Replace("u", "uwu");

        return uwu;
    }
}
