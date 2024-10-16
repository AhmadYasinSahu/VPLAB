
using System;
namespace programs
{
    public class WorkItem
    {
        private static int currentID;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Description = "Default description .";
            Title = "Default Tile.";


        }
        public WorkItem(string iD, string title, string description, TimeSpan jobLength)
        {
            ID = 0;
            Title = title;
            Description = description;
            this.jobLength = jobLength;
        }
        static WorkItem()
        {
            currentID = 0;
        }
        protected int GetNextID()
        {
            return ++currentID;
        }
        public void Update(string title, TimeSpan jobLength)
        {
            Title = title;
            this.jobLength = jobLength;
        }
        public override string ToString()
        {
            return String.Format(@"{0} - {1}", this.ID, this.Title);
        }

    }

    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }

        public ChangeRequest() { }

        public ChangeRequest(string title, string desc, TimeSpan jobLength, int originalID)
        {
            this.Title = title;
            this.ID = GetNextID();
            this.Description = desc;
            this.jobLength = jobLength;
        }
        public ChangeRequest(int originalItemID)
        {
            this.originalItemID = originalItemID;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            WorkItem WorkItem = new WorkItem("Fix Bugs","Fix all Bugs in my code"," Note the Bugs",new TimeSpan(2,4,0,0));

            ChangeRequest ChangeRequest = new ChangeRequest("Change base class design", "Add members to class",new TimeSpan(4,0,0),1);

            Console.WriteLine(WorkItem.ToString);


            ChangeRequest.Update("Change the design of Class",new TimeSpan(4,0,0));
            Console.WriteLine(ChangeRequest.ToString);
            Console.WriteLine(" Press any kew to exist...");
            Console.ReadKey();
        }
    }
}
