//namespace Models.HttpResponse

    public class TasksResponse
    {
        public required long Id {get; set;}
        public required string Title {get; set;}
        public required string Description {get; set;}
        public DateTime CreationDate {get; set;}
        public DateTime? ConclusionDate {get; set;}
        public string Status {get; set;}
    }
