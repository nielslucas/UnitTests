using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    class TerminalMock
    {
        // Define string where the log message will be inserted
        private List<string> message = new List<string>();

        // Function to get the log message
        public List<string> getLogMessage()
        {
            // return the message
            return message;
        }

        // Save the message in the object
        public void ConsoleLog(string messsage)
        {
            message.Add(messsage);
        }
    }
}
