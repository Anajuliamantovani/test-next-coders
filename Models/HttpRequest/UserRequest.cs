namespace Models.HttpRequest
{
    public class UserRequest
    {
        public long Id {get; set;}
        public required string Name {get; set;}
        public required string Email {get; set;}
    }
}