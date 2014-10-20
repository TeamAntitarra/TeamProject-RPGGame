namespace RPGGame.GameEngine
{
    using RPGGame.Interfaces;
    using RPGGame.Humans;
    using RPGGame.Demons;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class Engine
    {
        private IUserInputInterface controler;
        private IPaintInterface painter;
        private Character player;

        public Engine(IUserInputInterface controler, IPaintInterface painter)
        {
            this.controler = controler;
            this.painter = painter;
            InitializeObject();
            SubscribeToUserInput(controler);
        }

        private void InitializeObject()
        {
            Character templar = new Templar(200, 300, 75, 110);
            Character lordTruikwor = new LordTruikwor(900, 300, 150, 210);
            painter.AddObject(templar);
            painter.AddObject(lordTruikwor);
            this.player = templar;
        }

        public void Update()
        {
            this.painter.RedrawObject(player);
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
