namespace Project_Work.Models
{
    public class UserResource
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserData { get; set; }
        public int ResourceId { get; set; }
        public InternetResource Resource { get; set; }
        public string ResourceData { get; set; }

        public UserResource()
        {

        }
        public UserResource(User User, InternetResource Resource)
        {
            this.User = User;
            this.Resource = Resource;
            UserData = User.FirstName + " " + User.LastName;
            ResourceData = Resource.Name + ": " + Resource.URL;
        }
    }
}
