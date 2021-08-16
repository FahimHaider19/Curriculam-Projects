using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class News
    {
        long newsID;
        string title;
        string topic;
        string date;
        string description;

        public long NewsId
        {
            set { this.newsID = value; }
            get { return this.newsID; }
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
