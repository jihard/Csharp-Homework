using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
	    private const string Path = "../../midtermscores.txt";
	    private static void Main(string[] args)
	    {
		    var readText = File.ReadAllText(Path);
		    var inputs = readText.Split(' ');
		    List<string> GradeList = new List<string>();
		    string[] grade = { "00-09:", "10-19:","20-29:","30-39:",
		    "40-49:", "50-59:","60-69:","70-79:","80-89:", "90-99:","  100:"};
		    GradeList.AddRange(grade);
		    string items;
		    int num;
		    int points = 10;
		    for (int i = 0; i < inputs.Length; i++)
		    {
			    items = inputs[i];
			    num = Int32.Parse(items) / points;
			    grade[num] += "*";
		    }
		    for (int i = 0; i < GradeList.Count; i++)
		    {
			    string elements = grade[i];
			    Console.WriteLine(elements);
		    }
	    }
    }
}
