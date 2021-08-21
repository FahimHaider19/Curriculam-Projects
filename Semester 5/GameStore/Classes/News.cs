using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class News
    {
        long newsID;
        long productID;
        string title;
        string topic;
        string date;
        string description;

        public long NewsId
        {
            set { this.newsID = value; }
            get { return this.newsID; }
        }
        public long ProductId
        {
            set { this.productID = value; }
            get { return this.productID; }
        }
        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }
        public string Topic
        {
            set { this.topic = value; }
            get { return this.topic; }
        }
        public string Date
        {
            set { this.date = value; }
            get { return this.date; }
        }
        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }


    }
}
