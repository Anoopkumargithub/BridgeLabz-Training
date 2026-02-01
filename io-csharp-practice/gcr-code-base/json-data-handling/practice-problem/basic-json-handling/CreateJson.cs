using Newtonsoft.Json;

class CreateJson
{
    static void Main()
    {
     // create student object

     var student = new
     {
            Name = "Adam Carter",
            Age = 21,
            Subjects = new string[] { "Mathematics", "Physics", "Chemistry" }
     };

        // convert to JSON string
        string jsonString = JsonConvert.SerializeObject(student, Formatting.Indented);

        System.Console.WriteLine(jsonString);
    }
}