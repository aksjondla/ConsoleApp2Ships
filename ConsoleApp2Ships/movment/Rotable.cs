using ConsoleApp2Ships.Field;
using ConsoleApp2Ships.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2Ships.movment
{
    class Rotable : ICommand, IObserver
    {
        public List<IMovable> movables;
        public IField FieldServer;

        public Rotable(List<IMovable> movables_, IField _FieldServer)
        {
            movables = movables_;
            FieldServer = _FieldServer;
        }
        public void OnChanget()
        {
            Execute();
        }
        public void Execute()
        {
            foreach (var item in movables)
            {
                Position p = item.GetPosition();

                int newY, newX;
                Random rnd = new Random();

                bool positionIsValid = false;
                int attempts = 0;
                while (!positionIsValid && attempts < 4) // Предотвращаем бесконечный цикл
                {
                    switch (p.PositionAngle)
                    {
                        case 0: // Движение вверх
                            newX = p.PositionX;
                            newY = p.PositionY - 1;
                            break;
                        case 1: // Движение вниз
                            newX = p.PositionX;
                            newY = p.PositionY + 1;
                            break;
                        case 2: // Движение вправо
                            newX = p.PositionX + 1;
                            newY = p.PositionY;
                            break;
                        case 3: // Движение влево
                            newX = p.PositionX - 1;
                            newY = p.PositionY;
                            break;
                        default:
                            newX = p.PositionX;
                            newY = p.PositionY;
                            break;
                    }

                    // Проверяем, валидна ли новая позиция
                    if (newX >= 0 && newX < FieldServer.SpecificField_.GetLength(1) && newY >= 0 && newY < FieldServer.SpecificField_.GetLength(0))
                    {
                        positionIsValid = true;
                        item.SetPosition(new Position(newX, newY, p.PositionAngle));
                    }
                    else
                    {
                        // Выбираем новый угол
                        int oldAngle = p.PositionAngle;
                        while (p.PositionAngle == oldAngle)
                        {
                            p.PositionAngle = rnd.Next(0, 4);
                        }
                        attempts++;
                    }
                }
            }
        }
    }
}
