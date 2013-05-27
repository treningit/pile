using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humm
{
    class Humman
    {
        protected string Name;
        
        protected DateTime Birthday;

    
    public Humman ()
	{
	}
    public Humman(string N,DateTime B)
    {
        Name = N;
        Birthday = B;
    }
    public Humman(string N)
    {
        Name = N;
    }
    public string NAME { get { return Name; } set { Name = value; } }
    public DateTime BIRTHDAY { get { return Birthday; } set { Birthday = value; } }
    public virtual void Work()
    {
        Console.WriteLine("Delau Raboty!!!");
    }
    }
}
