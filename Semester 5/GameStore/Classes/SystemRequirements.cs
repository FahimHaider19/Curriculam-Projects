using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class SystemRequirements
    {
        string processor;
        string memory;
        string graphicsCard;
        string storage;
        string os;
        string languageRestriction;
        public string Processor
        {
            set { this.processor = value; }
            get { return this.processor; }
        }
        public string Memory
        {
            set { this.memory = value; }
            get { return this.memory; }
        }
        public string GraphicsCard
        {
            set { this.graphicsCard = value; }
            get { return this.graphicsCard; }
        }
        public string Storage
        {
            set { this.storage = value; }
            get { return this.storage; }
        }
        public string Os
        {
            set { this.os = value; }
            get { return this.os; }
        }
        public string LanguageRestriction
        {
            set { this.languageRestriction = value; }
            get { return this.languageRestriction; }
        }




    }
}
