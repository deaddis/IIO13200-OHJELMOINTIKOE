using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class G2415_T3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string username;
        string pwd;
        string CurrentUser = "";
        string CurrentPwd = "";
        bool LoginStatus = false;
        username = Login1.UserName;
        pwd = Login1.Password;
        string hashattyPwd = JAMK.ICT.Security.SHA256Hash.getSHA256Hash(pwd);
        XmlDocument xmxdoc = new XmlDocument();
        xmxdoc.Load(ConfigurationManager.AppSettings["tunnukset"]);
        XmlNodeList xmlnodelist = xmxdoc.GetElementsByTagName("User");
        foreach (XmlNode xn in xmlnodelist)
        {
        XmlNodeList xmlnl = xn.ChildNodes;
        foreach (XmlNode xmln in xmlnl)
        {
        if (xmln.Name == "username")
        {
        if (xmln.InnerText == username)
        {
        CurrentUser = username;
        }
        }
        if (xmln.Name == "password")
        {
        if (xmln.InnerText == hashattyPwd)
        {
            CurrentPwd = hashattyPwd;
        }
        }
        }
        if ((CurrentUser != "") & (CurrentPwd != ""))
        {
        LoginStatus = true;
        }
        }
        if (LoginStatus == true)
        {
        MySession.Current.Property1 = username;
        Session.Timeout = 1;
        Response.Redirect("G2415_T3a.aspx");
        }
        else
        {
        Session["UserAuthentication"] = "";
        }
    } 
}
