using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Games
    {
        public string OperationType {  get; set; }   
        public int Difficulty { get; set; }
        public int n1 { get; set; }    
        public int n2 { get; set; }
        public int answer { get; set; }
        public string winlose { get; set; }


        public Games (string operationType, int n1, int n2, int answer, string winlose)
        {
            OperationType = operationType;
            this.n1 = n1;
            this.n2 = n2;
            this.answer = answer;
            this.winlose = winlose;
        }

        
    }
}




