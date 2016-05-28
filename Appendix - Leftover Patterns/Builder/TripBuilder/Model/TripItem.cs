using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBuilder.Model
{
    public class TripItem : AbstractBuilder
    {
        public List<TripItem> Children { get; private set; } = new List<TripItem>();
        
        public string Type { get; private set; }
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public decimal Cost { get; private set; }
        public int Number { get; private set; }

        public TripItem(string type, string name, string owner, decimal cost, int number)
        {
            Type = type;
            Name = name;
            Owner = owner;
            Cost = cost;
            Number = Number;
        }

        public override TripItem AddHotel(string name)
        {
            return AddItem(HOTEL, name, "", 0, 0);
        }

        public override TripItem AddReservation(string reservationHolder, decimal cost, int number)
        {
            return AddItem(RESERVATION, "", reservationHolder, cost, number);
        }

        public override TripItem AddSpecialEvent(string name)
        {
            return AddItem(SPECIAL_EVENT, name, "", 0, 0);
        }

        public override TripItem AddTickets(string name)
        {
            return AddItem(TICKETS, name, "", 0, 0);
        }

        public override TripItem AddItemChild(TripItem tripItem)
        {
            Children.Add(tripItem);

            return tripItem;
        }

        public void Print(int leftPadTab = 0)
        {
            int firstTab = leftPadTab * 2;
            int secondTab = firstTab + 1;
            if (!string.IsNullOrEmpty(Type))
            {
                Console.WriteLine(new string(' ', firstTab) + "=== {0} ===", Type);
            }
            if (!string.IsNullOrEmpty(Name))
            { Console.WriteLine(new string(' ', secondTab) + "Name: {0}", Name);
            }
            if (!string.IsNullOrEmpty(Owner))
            { Console.WriteLine(new string(' ', secondTab) + "Owner: {0}", Owner);
            }
            if (Cost != 0)
            { Console.WriteLine(new string(' ', secondTab) + "Price: {0}", Cost);
            }
            if (Number != 0)
            { Console.WriteLine(new string(' ', secondTab) + "Guests: {0}", Number);
            }

            ++leftPadTab;
            foreach (TripItem item in Children)
            {
                item.Print(leftPadTab);
            }
        }

        private TripItem AddItem(string type, string name, string owner, decimal cost, int number)
        {
            if (TripItemsContain(type, name))
            {
                return GetTripItem(type, name);
            }
            else
            {
                TripItem item = new TripItem(type, name, owner, cost, number);
                Children.Add(item);
                return item;
            }
        }

        private bool TripItemsContain(string type, string name)
        {
            foreach (TripItem item in Children)
            {
                if (string.Compare(item.Type, type) == 0 &&
                    string.Compare(item.Name, name) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private TripItem GetTripItem(string type, string name)
        {
            foreach (TripItem item in Children)
            {
                if (string.Compare(item.Type, type) == 0 &&
                    string.Compare(item.Name, name) == 0)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
