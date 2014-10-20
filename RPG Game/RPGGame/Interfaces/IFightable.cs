namespace RPGGame.Interfaces
{
    using RPGGame.Items;

    public interface IFightable : IGameObject
    {
        Weapon Weapon { get; set; }
    }
}
