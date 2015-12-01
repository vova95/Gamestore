using GameStore.Models;
using GameStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameStore.Pages
{
    public partial class Authentication : System.Web.UI.Page
    {

        private Repository repository = new Repository();

        public User name;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public User findUser(string login) {
            return repository.Users.Where(u => u.login == login).FirstOrDefault();
        }

        public void checkUser(object sender, EventArgs e)
        {
            User currentUser = findUser(login.Text);
            if (currentUser.password.Equals(password.Text))
            {
                Session["user"] = currentUser;
                UserPassword.Text = ((User)Session["user"]).password;
            }
        }

    }
}