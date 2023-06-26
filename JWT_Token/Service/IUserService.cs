namespace JWT_Token.Service
{
    public interface IUserService
    {
        string Login(string userName, string password);
    }
}
