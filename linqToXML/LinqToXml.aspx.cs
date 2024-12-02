using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace linqToXML
{
    public partial class LinqToXml : System.Web.UI.Page
    {
        string filePath = "D:\\CS semester 6th\\VP\\Lab\\LinQTOSQL\\linqToXML\\Products.xml";
        XDocument Xdoc; // file 

        protected void Page_Load(object sender, EventArgs e)

        {
            Xdoc = XDocument.Load(filePath);
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        private  void LoadGrid()  // load Function
            {
               DataSet ds = new DataSet();
               ds.ReadXml(filePath);
            GVUser.DataSource = ds;
            GVUser.DataBind();
             
            }
        protected void Btninsert_Click(object sender, EventArgs e)
        {
            Xdoc.Element("Products").Add(
                new XElement("Product",
                new XAttribute("Id", 2),
                new XElement("Name", "Projector"),
                new XElement("Description", "viviket Tech"),
                new XElement("Price", "500000")

                )
                );
           
            Xdoc.Save(filePath);
            LoadGrid();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}