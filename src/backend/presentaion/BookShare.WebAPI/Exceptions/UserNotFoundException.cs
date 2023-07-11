namespace BookShare.WebAPI.Exceptions
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(string userEmail) : base($"User does not exist")
        {
        }
    }
}
