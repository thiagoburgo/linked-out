using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Content
    {
        private Profile owner;
        public Content(Profile owner)
        {
            this.Owner = owner;
        }
        public List<Comment> Comments { get; set; }
        public Profile Owner
        {
            get { return this.owner; }
            set
            {
                if (value != null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentNullException("Um conteudo deve ter um dono!");
                }
            }
        }

        public List<UserHangLoose> HangLooses { get; set; }
    }
}
