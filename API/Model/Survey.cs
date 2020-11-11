using System.IO.Pipes;
using System.Xml.Schema;


namespace API.Model
{
    public class Survey
    {
        public int ID {get; set;}

        public double Lead1 {get; set;}

        public double Lead2 {get; set;}
        
        public double Lead3 {get; set;}

        public double Lead4 {get; set;}

        public double Lead5 {get; set;}

        public double Comm1 {get; set;}

        public double Comm2 {get; set;}
        
        public double Comm3 {get; set;}

        public double Comm4 {get; set;}

        public double Comm5 {get; set;}

        public double Tech1 {get; set;}

        public double Tech2 {get; set;}
        
        public double Tech3 {get; set;}

        public double Tech4 {get; set;}

        public double Tech5 {get; set;}

        public override string ToString()
        {
            return ID + " Overall Results " + (Lead1 + Lead2 + Lead3 + Lead4 + Lead5 + Comm1 + Comm2 + Comm3 + Comm4 + Comm5 + Tech1 + Tech2 + Tech3 + Tech4 + Tech5);
        }
    }
}