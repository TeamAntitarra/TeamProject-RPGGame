using System.Linq;

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
        private List<GameObject> objects;

        public Engine(IUserInputInterface controler, IPaintInterface painter)
        {
            this.controler = controler;
            this.painter = painter;
            this.objects = new List<GameObject>();
            InitializeObject();
            SubscribeToUserInput(controler);
        }

        private void InitializeObject()
        { 
            Character templar = new Templar(200, 300, 95, 120);
            
            objects.Add(templar);
            objects.Add(new LordTruikwor(800, 300, 140, 187));
            objects.Add(new Zombie(1000, 630, 45, 109));
            objects.Add(new Zombie(950, 610, 45, 109));
            objects.Add(new Zombie(900, 590, 45, 109));
            objects.Add(new Rock(0, 680, 120, 89));
            objects.Add(new Rock(330, 40, 120, 89));
            objects.Add(new Tree(0, 0, 330, 213));
            objects.Add(new Tree(650, 0, 330, 213));
    
            foreach (GameObject obj in objects)
	        {
		         painter.AddObject(obj);
	        }

            this.player = templar; 
        }
       
        public void Update()
        {
            this.ProcessGameObject();
            this.RedrawAll();
        }

        private void ProcessGameObject()
        {
            foreach (GameObject obj in objects)
            {
                if (obj is IMovable)
                {
                    ProcessMovement(obj as IMovable);
                }

                if (obj is Character)
                {
                    if (!((obj as Character).IsAlive))
                    {
                        this.painter.RemoveObject((obj as Character));
                        this.objects.Remove(obj as Character);
                    }
                }
            }
        }

        private void RedrawAll()
        {
            foreach (GameObject obj in this.objects)
            {
                this.painter.RedrawObject(obj);
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
<<<<<<< HEAD
            if (!(movableObject is Templar))
            {
                movableObject.Move();
            }
        }

        private bool isCollision(GameObject gameObject, GameObject gameObjectOther)
        {
            if ((gameObjectOther.X < gameObject.X + gameObject.SizeX) && (gameObjectOther.X + gameObjectOther.SizeX > gameObject.X) &&
                            (gameObjectOther.Y < gameObject.Y + gameObject.SizeY) && (gameObjectOther.Y + gameObjectOther.SizeY > gameObject.Y))
	        {
		        return true;
	        }
  
            return false;
=======
             movableObject.Move();
        }

        private bool isCollision(IGameObject movableObject)
        {
            return (from item in items where !item.Equals(movableObject) select (item.X < movableObject.X + movableObject.SizeX && item.X + item.SizeX > movableObject.X && item.Y < movableObject.Y + movableObject.SizeY && item.Y + item.SizeY > movableObject.Y)).FirstOrDefault();
>>>>>>> 5a700a74761e1a729bc1bd27570268b7b91deeea
        }

        private void SubscribeToUserInput(IUserInputInterface userInteface)
        {
            userInteface.OnUpPressed += (sender, args) => this.MovePlayerUp();
            userInteface.OnDownPressed += (sender, args) => this.MovePlayerDown();
            userInteface.OnLeftPressed += (sender, args) => this.MovePlayerLeft();
            userInteface.OnRightPressed += (sender, args) => this.MovePlayerRight();
        }
    }
}
