using GameStore.Models;
using GameStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameStore.Pages
{
    public partial class Comments : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Comment> GetComments()
        {
            return repository.Comments.Reverse();
        }

        
        public void InsertComment()
        {
            Comment myComment = new Comment();
            if (TryUpdateModel(myComment,
                new FormValueProvider(ModelBindingExecutionContext)))
            {
                repository.addComment(myComment);
            }
        }
    }
}