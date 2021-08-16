using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class RefundRequests
    {
        long refundRequestId;
        User user;
        Product product;

        public long RefundRequestId
        {
            set { this.refundRequestId = value; }
            get { return this.refundRequestId; }
        }
        public User User
        {
            set { this.user = value; }
            get { return this.user; }
        }
        public Product Product
        {
            set { this.product = value; }
            get { return this.product; }
        }

    }
}
