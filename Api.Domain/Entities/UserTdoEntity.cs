namespace Api.Domain.Entities
{
    public class UserTdoEntity : BaseEntity
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}