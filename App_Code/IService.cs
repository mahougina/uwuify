using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	[WebGet(UriTemplate = "uwuify?x={input}", ResponseFormat = WebMessageFormat.Json)]
	string getUwu(string input);

	// TODO: Add your service operations here
}
