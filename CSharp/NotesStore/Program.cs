using System;

namespace NotesStore;

class Program
{
    static void Main(string[] args)
    {
        var notesStoreObj = new NotesStore();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var operationInfo = Console.ReadLine().Split(' ');
            try
            {
                if (operationInfo[0] == "AddNote")
                    notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                else if (operationInfo[0] == "GetNotes")
                {
                    var result = notesStoreObj.GetNotes(operationInfo[1]);
                    if (result.Count == 0)
                        Console.WriteLine("No Notes");
                    else
                        Console.WriteLine(string.Join(",", result));
                }
                else
                {
                    Console.WriteLine("Invalid Parameter");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

class NotesStore
{
    public List<Note>? Notes { get; set; }

    public void AddNote(string state, string name)
    {
        if (state == "active")
        {
            Notes = new List<Note>();

            if (name != string.Empty)
            {
                var note = new Note { Name = name, State = state };
                if (note != null)
                {
                    Notes.Add(note);
                }

            }
            else
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }
        else
        {
            throw new ArgumentException("Invalid state: ", state);
        }
        
    }

    public List<string> GetNotes(string state)
    {
        var notes = new List<Note>();
        var names = new List<string>();

        if (state != "completed" || state != "active" || state != "others")
            throw new ArgumentException("Invalid State ", state);

        if (Notes != null)
        {
            notes = Notes.Where(n => n.State == state).ToList();

            var name = "";

            if(notes != null)
            {
                foreach (var note in notes)
                {
                    name = note.Name;

                    if(name != null)
                    {
                        names.Add(name);
                    }                   
                }
            }
            else
            {
                return names;
            }            
        }        
        return names;
    }
}

public class Note
{
    public string? Name { get; set; }
    public string? State { get; set; }
}

