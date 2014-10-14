namespace RPGGame.Interfaces
{
    using RPGGame.Items;
    // This means that the character can fight
    public interface IFightable : IGameObject
    {
        Weapon Weapon { get; set; }
    }
}
