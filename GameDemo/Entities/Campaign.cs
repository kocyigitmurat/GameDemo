using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Campaign:ICampaign
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
