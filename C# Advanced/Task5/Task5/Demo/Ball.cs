using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class LocationEventArgs
    {
        public Location Location {  get; set; }
    }
    public class Ball
    {
        public int Id { get; set; }

        private Location location;

        public Ball(int id)
        {
            Id = id;
        }

        public Location Location
        {
            get { return location; } 
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    Console.WriteLine($"{location}");
                    OnBallChangedMethod();
                }
            }
        }

        public event EventHandler<LocationEventArgs> OnBallChanged;

        public virtual void OnBallChangedMethod()
        {
            OnBallChanged.Invoke(this, new LocationEventArgs { Location = location });
        }

    }
}
