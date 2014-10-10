namespace RPGGame.Interfaces
{
    // This means that the character can move
    public interface IMovable : IGameObject
    {
        int MovementSpeed { get; set; }

        Direction Direction { get; set; }

        void Move();
    }
}
