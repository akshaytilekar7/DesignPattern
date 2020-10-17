using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.CSharp
{
    public class BaseRestaurant
    {
        public string Name { get; set; }
        public bool IsOpened { get; set; }

        public BaseRestaurant(string name, bool isOpened)
        {
            Name = name;
            IsOpened = isOpened;
        }
    }

    public class OpenRestaurantsEnumerator : IEnumerator
    {
        private readonly List<BaseRestaurant> _restaurants;
        private int _position = -1;

        public OpenRestaurantsEnumerator(List<BaseRestaurant> restaurants)
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

    class RestaurantEnumerableForOpenFlag : IEnumerable
    {
        private readonly List<BaseRestaurant> restaurants;

        public RestaurantEnumerableForOpenFlag(List<BaseRestaurant> restaurants)
        {
            this.restaurants = restaurants;
        }

        public IEnumerator GetEnumerator()
        {
            return new OpenRestaurantsEnumerator(restaurants);
        }

    }

    class Program
    {
        public static void Main1(string[] args)
        {
            List<BaseRestaurant> restaurants = new List<BaseRestaurant>
            {
                new BaseRestaurant("Pizza", true),
                new BaseRestaurant("Hamburger", false),
                new BaseRestaurant("Bread", true)
            };

            RestaurantEnumerableForOpenFlag restaurantsFinal = new RestaurantEnumerableForOpenFlag(restaurants);

            foreach (BaseRestaurant restaurant in restaurantsFinal)
                Console.WriteLine(restaurant.Name);

            //Output: Pizza and Bread only 
        }
    }
}
