﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NegativeSentiment : Sentiment
    {
        public NegativeSentiment(String Title, String Text)
        {
            this.Title = Title;
            this.Text = Text;
        }
        
    }
}
