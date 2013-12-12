using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class G2415_T2 : System.Web.UI.Page
{
    private DataSet ds;
    private DataTable dt;
    private DataView dataViewAll;
    private List<string> columns;

    protected void Page_Load(object sender, EventArgs e)
    {
        columns = new List<string>();
        columns.Add("etunimi");
        columns.Add("sukunimi");
        columns.Add("numero");
        columns.Add("tyosuhde");
        columns.Add("palkka");

        ds = new DataSet();
        ds.ReadXml(ConfigurationManager.AppSettings["Tyontekijat"]);

        dt = ds.Tables[0];

        dataViewAll = dt.DefaultView;

        GridView1.DataSource = dataViewAll.ToTable(false, columns.ToArray());

        GridView1.DataBind();

        int sum = 0;
        for (int i = 0; i < GridView1.Rows.Count; ++i)
        {
            sum += Convert.ToInt32(GridView1.Rows[i].Cells[4].Text);
        }
        label1.Text = sum.ToString();



        /*
        int sum = 0;
        int total = 0;

        
        foreach (var GridViewRow in GridView1.Rows)
	{
		 sum = CD GridView1.(
	}
        lblTotal.Text = Total.ToString
        */
    }
}