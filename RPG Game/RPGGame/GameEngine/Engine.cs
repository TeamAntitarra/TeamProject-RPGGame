namespace RPGGame.GameEngine
{
    using RPGGame.Interfaces;
    using RPGGame.Humans;
    using RPGGame.Demons;
    using RPGGame.Items;
    using RPGGame.Items.Objects;
    using RPGGame.Items.Weapons;
    using System.Collections.Generic;

    public class Engine
    {
        private IUserInputInterface controler;
        private IPaintInterface painter;
        private Character player;
        private List<GameObject> items;

        public Engine(IUserInputInterface controler, IPaintInterface painter)
        {
            this.controler = controler;
            this.painter = painter;
            InitializeObject();
            SubscribeToUserInput(controler);
        }

        private void InitializeObject()
        { 
            Character templar = new Templar(200, 300, 95, 120);
            items = new List<GameObject>() 
            {
                templar,
                new LordTruikwor(800, 300, 140, 187),
                new Tree(650, 0, 330, 213),
                new Tree(0, 0, 330, 213),
                new Rock(330, 40, 120, 89),
                new Rock(0, 680, 120, 89),
                new Zombie(1000, 630, 45, 109),
                new Zombie(950, 610, 45, 109),
                new Zombie(900, 590, 45, 109)
            };

            //painter.AddObject(templar);
            foreach (var item in items)
	        {
		         painter.AddObject(item);
	        }
           
            this.player = templar;
        }

        public void Update()
        {
            //this.painter.RedrawObject(player);
            foreach (var item in items)
            {
                if (item is IMovable && !(item is Templar))
                {
                    //ProcessMovement(item as IMovable);
                    (item as IMovable).Move();
                }
                this.painter.RedrawObject(item);
            }
        }

        private void MovePlayerUp()
        {
            this.player.Direction = new Direction(0, -1);
            this.player.Move();
        }

        private void MovePlayerDown()
        {
            this.player.Direction = new Direction(0, 1);
            this.player.Move();
        }

        private void MovePlayerRight()
        {
            this.player.Direction = new Direction(1, 0);
            this.player.Move();
        }

        private void MovePlayerLeft()
        {
            this.player.Direction = new Direction(-1, 0);
            this.player.Move();
        }

        private void ProcessMovement(IMovable movableObject)
        {
             movableObject.Move();
        }

        private bool isCollision(IGameObject movableObject)
        {
            foreach (var item in items)
            {
                if (!item.Equals(movableObject))
                {
                    return (item.X < movableObject.X + movableObject.SizeX && item.X + item.SizeX > movableObject.X &&
                            item.Y < movableObject.Y + movableObject.SizeY && item.Y + item.SizeY > movableObject.Y);
                }
            }

            return false;
        }

        private void SubscribeToUserInput(IUserInputInterface userInteface)
        {
            userInteface.OnUpPressed += (sender, args) =>
            {
                this.MovePlayerUp();
            };
            userInteface.OnDownPressed += (sender, args) =>
            {
                this.MovePlayerDown();
            };
            userInteface.OnLeftPressed += (sender, args) =>
            {
                this.MovePlayerLeft();
            };
            userInteface.OnRightPressed += (sender, args) =>
            {
                this.MovePlayerRight();
            };
        }
    }
}
