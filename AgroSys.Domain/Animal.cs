namespace AgroSys.Domain
{
    public class Animal
    {
        public required Guid ID { get; set; }
        public required string Name { get; set; }
        public required Guid CattleManID { get; set; }
    }
}
