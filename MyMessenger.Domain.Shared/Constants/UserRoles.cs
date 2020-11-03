namespace MyMessenger.Domain.Shared.Constants
{
    public static class UserRoles
    {
        public const string User = "User";
        public const string Admin = "Admin";

        // use only for authorize attribute
        public const string All = "User,Admin";
    }
}
