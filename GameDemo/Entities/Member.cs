using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Member:IMember
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string TcNo { get; set; }
    }
}
