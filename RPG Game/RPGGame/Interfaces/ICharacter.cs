namespace RPGGame.Interfaces
{
    public interface ICharacter : IGameObject
    {
        int CurrentHealthPoints { get; set; }

        int MaximumHealthPoints { get; set; }

        bool IsAlive { get; }

        int DefensePoints { get; set; }
    }
}
