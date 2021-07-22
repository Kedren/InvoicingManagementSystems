using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class Category
    {
        private string cateID;

        public string CateID
        {
            get { return cateID; }
            set { cateID = value; }
        }
        private string cateName;

        public string CateName
        {
            get { return cateName; }
            set { cateName = value; }
        }
        public Category()
        {

        }

        public Category(string cateID,string cateName)
        {
            this.cateID = cateID;
            this.cateName = cateName;
        }


    }
}
