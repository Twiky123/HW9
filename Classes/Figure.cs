namespace labatym10
{

    abstract class Figure : IFigure
    {
        #region Поля
        protected double horizontalCoordinate;
        protected double verticalCoordinate;
        protected string figureColor;
        protected bool figureVisible;
        #endregion

        #region Свойства
        public (double, double) FigureCoordinates
        {
            get
            {
                return (horizontalCoordinate, verticalCoordinate);
            }
        }
        public string FigureColor
        {
            get
            {
                return figureColor;
            }
        }
        #endregion

        #region Методы
        public void MovementHorizontally()
        {
            horizontalCoordinate++;
        }

        public void MovementVertically()
        {
            verticalCoordinate++;
        }

        public void ChangingColorOfFigure(string newColor)
        {
            figureColor = newColor;
        }

        public abstract void FigureStatusSurvey();

        public abstract void DisplayingFigureData();
        #endregion
    }
}