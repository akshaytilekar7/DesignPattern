using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern
{
    public class Restaurant
    {
        public string Name { get; set; }
        public bool IsOpened { get; set; }

        public Restaurant(string name, bool isOpened)
        {
            Name = name;
            IsOpened = isOpened;
        }
    }

    public class OpenRestaurantsEnumerator : IEnumerator
    {
        private readonly List<Restaurant> _restaurants;
        private int _position = -1;

        public OpenRestaurantsEnumerator(List<Restaurant> restaurants)
        {
            _restaurants = restaurants;
        }

        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _restaurants.Count)
                    throw new InvalidOperationException();

                return _restaurants[_position];
            }
        }

        public bool MoveNext()
        {
            while (_position < _restaurants.Count)
            {
                _position++;
                if (_position < _restaurants.Count && _restaurants[_position].IsOpened)
                    return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }

    class Restaurants : IEnumerable
    {
        readonly public List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant("Pizza", true),
            new Restaurant("Hamburger", false),
            new Restaurant("Bread", true)
        };

        public IEnumerator GetEnumerator()
        {
            return new OpenRestaurantsEnumerator(restaurants);
        }

    }

    class Program
    {
        private static void ProtectWithTransaction(Action action)
        {
            action.Invoke();
        }

        private static int ProtectWithTransaction1(Func<int> action)
        {
            return action.Invoke();
        }

        private static void Add(int a, int b)
        {
        }

        private static int Add(int a)
        {
            return 5;
        }

        static void Main(string[] args)
        {

            ProtectWithTransaction(() => Add(1, 3));
            ProtectWithTransaction(() => Add(10));
            var x = ProtectWithTransaction1(() => Add(10));

            Restaurants restaurants = new Restaurants();

            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine(restaurant.Name);
            }

            //Output:
            //Pizza
            //Bread
        }
    }
}
