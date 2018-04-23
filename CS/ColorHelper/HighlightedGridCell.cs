using System.Windows.Media;
using DevExpress.Xpf.Grid;

namespace WpfApplication {
    public class HighlightedGridCell {
        /// <summary>
        /// Initializes a new instance of the HighlightedGridCell class.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="color"></param>
        public HighlightedGridCell(object row, GridColumn column, Color color) {
            _Color = color;
            _Row = row;
            _Column = column;
        }
        // Fields...
        private Color _Color;
        private object _Row;
        private GridColumn _Column;

        public GridColumn Column {
            get { return _Column; }
            set {
                _Column = value;

            }
        }

        public object Row {
            get { return _Row; }
            set {
                _Row = value;
            }
        }

        public Color Color {
            get { return _Color; }
            set {
                _Color = value;

            }
        }

    }
}