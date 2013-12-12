using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class G2415_T4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            gvOppilaat.DataSourceID = "SqlDataSource1";
            oppilasCount.Text = gvOppilaat.Rows.Count.ToString();

            lblError.Visible = true;
            lblError.Text = "Kaikki Toimii";
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            throw;
        }
    }
    protected void getStudents(object sender, EventArgs e)
    {
        try
        {
            lblError.Visible = false;
            gvOppilaat.DataSourceID = "SqlDataSource1";
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            throw;
        }
    }

    protected void getLasnat(object sender, EventArgs e)
    {
        try
        {
            lblError.Visible = false;
            gvOppilaat.DataSourceID = "SqlDataSource2";
            ddlJaksot.Visible = true;
            ddlOppilaat.Visible = true;
        }
            catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            throw;
        }
    }
    protected void ddlJaksot_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblError.Visible = false;
            gvOppilaat.DataSourceID = "SqlDataSource3";
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            throw;
        }
    }
    protected void ddlOpiskelija_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblError.Visible = false;
            gvOppilaat.DataSourceID = "SqlDataSource6";
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            throw;
        }
    }
    protected void getOpinnot(object sender, EventArgs e)
    {
        lblError.Visible = true;
        lblError.Text = "In Development!";
    }
}