namespace MyMessenger.Domain.Shared.Constants
{
    public static class ExceptionMessages
    {
        public const string NullArgument = "Method argument was null";

        public const string EntityNotFound = "Entity not found";

        public const string EntityForbiddenEdit = "No rights to edit entity";
        public const string UnsuccessfulAuthorize = "Wrong login or password";
    }
}
