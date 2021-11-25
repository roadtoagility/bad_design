using System;
using System.Collections.Generic;
using System.Text;

namespace EntrevistaApp.Application.Abstraction
{
    public class CommandExecution
    {
        public static CommandExecution From()
        {
            return new CommandExecution();
        }
    }
}
