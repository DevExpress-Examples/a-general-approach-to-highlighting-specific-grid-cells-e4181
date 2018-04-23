using System;
using System.Collections.ObjectModel;

namespace WpfApplication {
    public class DataHelper {
        public static object GetDataSource(int count) {
            ObservableCollection<GridItem> collection = new ObservableCollection<GridItem>();
            for (int i = 0; i < count; i++) {
                collection.Add(new GridItem(DateTime.Now.AddMinutes(count * i).AddDays((i - count / 2) * count), String.Format("Name{0}", i), 0));
            }
            return collection;
        }

    }

    public class GridItem {
        /// <summary>
        /// Initializes a new instance of the GridItem class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="iD"></param>
        public GridItem(DateTime date, string name, int iD) {
            _Date = date;
            _Name = name;
            _ID = iD;
        }
        public GridItem() {

        }

        // Fields...
        private DateTime _Date;
        private string _Name;
        private int _ID;

        public string Name {
            get { return _Name; }
            set {
                _Name = value;
            }
        }

        public int ID {
            get { return _ID; }
            set {
                _ID = value;
            }
        }

        public DateTime Date {
            get { return _Date; }
            set {
                _Date = value;

            }
        }
    }
}