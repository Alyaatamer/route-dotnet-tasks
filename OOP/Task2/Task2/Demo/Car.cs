namespace Demo
{
    enum CarColors : byte
    {
        Red,
        Green, 
        Blue,
        Black,
        White
    }
    enum CarType : byte
    {
        Electricity,
        Gasoline
    }
    internal class Car
    {
        private string code; //read only 
        private string model; //get set
        private int year; // read only
        private CarType type; //get set
        private CarColors color; // get set

        //public Car()
        //{

        //}

        



        #region Prop

        public string Code { get { return code; } }

        public string Model { get { return model; }  set { model = value; } }

        public int Year { get { return year; } }

        public CarType Type { get { return type; } set { type = value; } }

        public CarColors Color { get { return color; } set { color = value; } }

        #endregion

        #region constructor overload
        public Car(string model, CarColors color, CarType type)
        {
            this.code = $"{year}-{model}-000";
            this.model = model;
            this.year = DateTime.Now.Year;
            Type = type;
            Color = color;
        }
        public Car(string model, CarColors color):this(model,color,CarType.Gasoline)
        {     
           
        }
        public Car(string model) :this(model, CarColors.White)
        {
                     
        }

        #endregion



        #region Tostring

        public override string ToString()
        {
            return $"code : {code} , model : {model} , year : {year} , type : {type} , color : {color}";
        }

        #endregion

        



    }
}
