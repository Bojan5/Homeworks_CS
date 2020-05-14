using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.Entities
{
    public class Session
    {

        public Session()
        {
            counter += 1;
            SessionId = counter;
            WinningCombination = new int[7];
        }
        private int SessionId { get; set; }
        private int[] WinningCombination { get; set; }
        public int[] Tickets { get; set; }
    }
}
