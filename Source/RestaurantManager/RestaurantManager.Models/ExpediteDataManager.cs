using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            //OnPropertyChanged("OrderItems");
        }

        private List<MenuItem> _orderItems;
        public List<MenuItem> OrderItems
        {
            get
            {
                return _orderItems;
            }
            set
            {
                if (_orderItems != value)
                {
                    _orderItems = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
