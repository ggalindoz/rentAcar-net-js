namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        private string name;
        private string email;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}