using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class G2415_T3a : System.Web.UI.Page
{
    private DataSet ds;
    private DataTable dt;
    private DataView dataViewAll;
    private List<string> columns;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (MySession.Current.Property1 == "default value")
            Response.Redirect("~/G2415_T3.aspx");

        columns = new List<string>();
        columns.Add("kayttaja");
        columns.Add("paiva");
        columns.Add("tunnit");
        columns.Add("minuutit");

        ds = new DataSet();
        ds.ReadXml(ConfigurationManager.AppSettings["kirjanpito"]);

        dt = ds.Tables[0];

        dataViewAll = dt.DefaultView;

        tunnit.DataSource = dataViewAll.ToTable(false, columns.ToArray());

        tunnit.DataBind();

        txtboxKayttaja.Text = MySession.Current.Property1;
        txtboxDate.Text = DateTime.Now.ToShortDateString();
    }
    protected void btnLisaa(object sender, EventArgs e)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(ConfigurationManager.AppSettings["kirjanpito"]);
        

        XmlNode node = doc.CreateElement("kirjaus");
        XmlElement kayttaja = doc.CreateElement("kayttaja");
        kayttaja.InnerText = txtboxKayttaja.Text; 
        XmlElement date = doc.CreateElement("paiva");
        date.InnerText = txtboxDate.Text;
        XmlElement tunnit = doc.CreateElement("tunnit");
        tunnit.InnerText = txtboxTunnit.Text;
        XmlElement minuutit = doc.CreateElement("minuutit");
        minuutit.InnerText = txtbotMinuutit.Text;
        node.AppendChild(kayttaja);
        node.AppendChild(date);
        node.AppendChild(tunnit);
        node.AppendChild(minuutit);
        
        
        //node.InnerText = "\n<kayttaja>"+txtboxKayttaja.Text+"</kayttaja>\n<paiva>"+txtboxDate.Text+"</paiva>\n<tunnit>"+txtboxTunnit.Text+"</tunnit>\n<minuutit>"+txtbotMinuutit.Text+"</minuutit>";
        doc.DocumentElement.AppendChild(node);
        doc.Save(ConfigurationManager.AppSettings["kirjanpito"]);

    }
}