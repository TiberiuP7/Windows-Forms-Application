using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariuriSportive.Model
{
        public class InvalidKickoffTimeException : Exception
        {
            public DateTime Kickoff { get; set; }

            public InvalidKickoffTimeException(DateTime kickoff)
            {
                Kickoff = kickoff;
            }

            public override string Message
            {
                get
                {
                    return "The Kickoff time " + Kickoff + " is invalid";
                }
            }
        }
}
