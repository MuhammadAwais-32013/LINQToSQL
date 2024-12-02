using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQTOSQL
{
    public partial class LinQToSql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
            }
        }

        protected void Btninsert_Click(object sender, EventArgs e)
        {
            InventoryDB db= new InventoryDB();
            User user = new User()
            {
                Name = "Mouse",
                Description = "LogicTech  m15",
                Price = "570"
            };

            db.Users.Add(user);
            db.SaveChanges();
            LoadGridView();

        }

       private void LoadGridView() // load Function
        {
            InventoryDB db=new InventoryDB();

            GVUser.DataSource=db.Users.ToList();
            GVUser.DataBind();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            InventoryDB db= new InventoryDB();
            //User user = db.Users.SingleOrDefault(x=>x.ID==1);// Because ID is unique so singleordefualt
            var user = db.Users.SingleOrDefault(x => x.ID == 1);
            user.Name = "Projector";
            user.Description = "Vivitek";
            user.Price = "1000";
            db.SaveChanges();
            LoadGridView();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            InventoryDB db = new InventoryDB();
            //User user = db.Users.SingleOrDefault(x=>x.ID==1);// Because ID is unique so singleordefualt
            var user = db.Users.SingleOrDefault(x => x.ID == 1);
            db.Users.Remove(user);
            db.SaveChanges();
            LoadGridView();
        }
    }
}