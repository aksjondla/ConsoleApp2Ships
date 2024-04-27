/*using ConsoleApp2Ships.Field;
using ConsoleApp2Ships.movment;
using ConsoleApp2Ships.Observer;
using System;
using System.Collections.Generic;

namespace ConsoleApp2Ships
{
    class AIMovment : IObserver
    {
        public List<IMovable> movables;
        public IField FieldServer;

        public AIMovment(List<IMovable> movables, IField _FieldServer)
        {
            this.movables = movables;
            FieldServer = _FieldServer;
        }

        public void OnChanget()
        {
            this.AIComand();
        }

        private void AIComand()
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

*//*                // Если не нашли валидную позицию, оставляем объект на месте или обрабатываем иначе
                if (!positionIsValid)
                {
                    //Console.WriteLine("Не удалось найти валидную позицию для объекта");
                    // Здесь можно выбрать, что делать дальше: оставить объект на месте или обработать по-другому
                }

                //var rotate = new Rotable(item);
                //rotate.Execute();

                //var move = new Move(item);
                if ((p.PositionY - 1) >= 0 && (p.PositionX + 1) < FieldServer.SpecificField_.GetLength(1) && (p.PositionY - 1) >= 0 && (p.PositionY + 1) < FieldServer.SpecificField_.GetLength(0))
                {
                    //move.Execute();
                }*//*
            }

        }
    }
}
*/