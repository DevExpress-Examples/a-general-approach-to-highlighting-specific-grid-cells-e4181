using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfApplication
{
    public class ViewModel
    {

        public ViewModel()
        {
            
        }

        // Fields...
        private object _DataSource;


        public object DataSource
        {
            get {  
                if (_DataSource == null)
                    _DataSource = DataHelper.GetDataSource(1020);
                return _DataSource;
            }
            set
            {
                _DataSource = value;

            }
        }
    }
}
