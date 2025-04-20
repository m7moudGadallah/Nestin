namespace Nestin.Core.Dtos.Accounts
{
    public record LoggedInUser
    {
        public string Id { get; init; }
        public string UserName { get; init; }
        public List<string> Roles { get; init; } = new List<string>();
    }
}