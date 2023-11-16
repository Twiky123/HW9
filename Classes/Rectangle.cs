using System;

namespace labatym10
{
    class Rectangle : Point
    {
        #region Поля
        readonly double rectangleWidth;
        readonly double rectangleHeight;
        #endregion

        #region Методы
        public void CalculationOfArea()
        {
            Console.WriteLine($"Площадь прямоугольника равна {rectangleHeight * rectangleWidth}");
        }

        public override void FigureStatusSurvey()
        {
            if (figureVisible)
            {
                Console.WriteLine("Прямоугольник видим");
            }
            else
            {
                Console.WriteLine("Прямоугольник невидим");
            }
        }

        public override void DisplayingFigureData()
        {
            Console.WriteLine($"Прямоугольник {figureColor} цвета. Координаты по вертикали: {verticalCoordinate}\n" +
                              $"Координаты по горизонтали {horizontalCoordinate}. Видимость: {figureVisible}. Ширина: {rectangleWidth}. Высота: {rectangleHeight}");
        }
        #endregion

        #region Конструкторы
        public Rectangle(double rectangleWidth, double rectangleHeight, string figureColor, bool figureVisible) : base(figureColor, figureVisible)
        {
            this.rectangleHeight = rectangleHeight;
            this.rectangleWidth = rectangleWidth;
        }
        #endregion
    }
}