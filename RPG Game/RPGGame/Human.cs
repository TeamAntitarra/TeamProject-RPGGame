namespace RPGGame
{
  
    public class Human : Character
    {
        public Human(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
         
        }
    }
}
