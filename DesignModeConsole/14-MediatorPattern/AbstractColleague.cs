﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.MP
{
    public abstract class AbstractColleague
    {
        protected AbstractMediator mediator;
        
        public AbstractColleague(AbstractMediator _mediator)
        {
            this.mediator = _mediator;
        }
    }
}
