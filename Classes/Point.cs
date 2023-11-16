using System;

namespace labatym10
{
    class Point : Figure
    {
        #region Методы
        public override void FigureStatusSurvey()
        {
            if (figureVisible)
            {
                Console.WriteLine("Точка видима");
            }
            else
            {
                Console.WriteLine("Точка невидима");
            }
        }

        public override void DisplayingFigureData()
        {
            Console.WriteLine($"Точка {figureColor} цвета. Координаты по вертикали: {verticalCoordinate}. Координаты по горизонтали {horizontalCoordinate}. Видимость: {figureVisible}");
        }
        #endregion

        #region Конструкторы
        public Point(string figureColor, bool figureVisible)
        {
            this.figureColor = figureColor;
            this.figureVisible = figureVisible;
            horizontalCoordinate = 0;
            verticalCoordinate = 0;
        }
        #endregion
    }
}