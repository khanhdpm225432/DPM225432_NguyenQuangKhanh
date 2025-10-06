using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225512_VoKhoaNguyen_RealWorld17_Mediator
{
    public class Beatle : Participant
    {
        // Constructor
        public Beatle(string name)
            : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class NonBeatle : Participant
    {
        // Constructor
        public NonBeatle(string name)
            : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}

