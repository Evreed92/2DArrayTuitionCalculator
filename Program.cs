
/*              In-State   Out-State
 * underGrad    150         250
 * Grad         400         600 
 * 
 * int[,] TuitionArray = Rows X Columns
 * Row = student type
 * Column = I/O State
 */

int[,] tuitionArray = new int[2, 2]
{
    {150, 250},
    {400, 600}
};
string IOResponse;
int IOIndex = 0;
string IOType = "";
string StudyResponse;
int StudyIndex = 0;
string StudyType = "";

Console.WriteLine("In (I) or Out (O) of State Student?");
IOResponse = Console.ReadLine().ToUpper();

if(IOResponse == "I")
{
    IOIndex = 0;
    IOType = "In";
}else if(IOResponse == "O")
{
    IOIndex = 1;
    IOType = "Out";
}

Console.WriteLine("Type of Study: Undergrad (U) or Graduate (G).");
StudyResponse = Console.ReadLine().ToUpper();

if (StudyResponse == "U")
{
    StudyIndex = 0;
    StudyType = "Undergrad";
}
else if (StudyResponse == "G")
{
    StudyIndex = 1;
    StudyType = "Graduate";
}

int creditHours;
Console.WriteLine("Number of Credit Hours");
creditHours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"In/Out State:      {IOType}");
Console.WriteLine($"Type of Study:     {StudyType}");
Console.WriteLine($"Number of Hours:   {creditHours}");
Console.WriteLine($"Cost:              {tuitionArray[StudyIndex, IOIndex] * creditHours}");


