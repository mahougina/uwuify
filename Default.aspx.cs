using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Net;
using Newtonsoft.Json;

public partial class _Default : System.Web.UI.Page {
    protected string host = "http://localhost:63536";

    protected void Page_Load(object sender, EventArgs e)  {
       HttpCookie cookie = Request.Cookies["cookie"];

        if (cookie != null)
            TextBox1.Text = cookie["input"];
    }

    protected void Button1_Click(object sender, EventArgs e) {
        //cookie time
        HttpCookie cookie = new HttpCookie("cookie");
        cookie["input"] = TextBox1.Text;
        cookie.Expires = DateTime.Now.AddMinutes(1);
        Response.Cookies.Add(cookie);

        if (TextBox1.Text == "") {
            TextBox2.Text = "pwease enter text ;w;";
        }
        else {
            string newUrl = host + "/Service.svc/uwuify?x=" + TextBox1.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(newUrl);
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();

            StreamReader streamReader = new StreamReader(data);
            string responseReader = streamReader.ReadToEnd();

            //display final text
            TextBox2.Text = responseReader;
        }
    }
}