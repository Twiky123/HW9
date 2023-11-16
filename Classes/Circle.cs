using System;

namespace labatym10
{
    class Circle : Point
    {
        #region Поля
        readonly double circleRadius;
        #endregion

        #region Методы
        public void CalculationOfArea()
        {
            Console.WriteLine($"Площадь круга равна {Math.PI * Math.Pow(circleRadius, 2)}");
        }
        public override void FigureStatusSurvey()
        {
            if (figureVisible)
            {
                Console.WriteLine("Круг видим");
            }
            else
            {
                Console.WriteLine("Круг невидим");
            }
        }
        public override void DisplayingFigureData()
        {
            Console.WriteLine($"Круг {figureColor} цвета. Координаты по вертикали: {verticalCoordinate}. " +
                              $"Координаты по горизонтали {horizontalCoordinate}. Видимость: {figureVisible}. Радиус: {circleRadius}");
        }
        #endregion

        #region Конструкторы
        public Circle(double circleRadius, string figureColor, bool figureVisible) : base(figureColor, figureVisible)
        {
            this.circleRadius = circleRadius;
        }
        #endregion
    }
}