using GameStore.Models;
using GameStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameStore.Pages.Admin
{
    public partial class Comments : System.Web.UI.Page
    {

        private Repository repository = new Repository();

        public IEnumerable<Comment> GetComments()
        {
            return repository.Comments.Reverse();
        }

        public void DeleteComment(int id)
        {
            Comment myComment = repository.Comments
                .Where(p => p.id == id).FirstOrDefault();
            if (myComment != null)
            {
                repository.deleteComment(myComment);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}