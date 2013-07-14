using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class Inquiry
    {
        [ScaffoldColumn(false)]
        public virtual int InquiryId { get; set; }

        public virtual string FullName { get; set; }
        public virtual string TopicSelected { get; set; }
        public virtual string MessageBody { get; set; }
    }
}
