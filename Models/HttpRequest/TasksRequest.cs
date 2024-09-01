namespace Models.HttpRequest
{   
    public class TasksRequest
    {
        public long UserId {get; set;}
        public required string Title {get; set;}
        public required string Description {get; set;}
    }
}