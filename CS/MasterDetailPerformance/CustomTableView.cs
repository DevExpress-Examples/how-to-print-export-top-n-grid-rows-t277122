using System.Collections;
using System.Linq;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.Printing;

namespace MasterDetailPerformance {
    public class CustomTableView : TableView {
        protected override PrintingDataTreeBuilderBase CreatePrintingDataTreeBuilder(double totalHeaderWidth, ItemsGenerationStrategyBase itemsGenerationStrategy, MasterDetailPrintInfo masterDetailPrintInfo, BandsLayoutBase bandsLayout) {
            return base.CreatePrintingDataTreeBuilder(totalHeaderWidth, new ItemsGenerationTop10RowsStrategy(ViewInfo.GridView), masterDetailPrintInfo, bandsLayout);
        }
    }
    public class ItemsGenerationTop10RowsStrategy : ItemsGenerationServerStrategy {
        public ItemsGenerationTop10RowsStrategy(DataViewBase view) : base(view) { }
        public override bool RequireFullExpand { get { return true; } }

        private int _SelectedRecordsNumber = 10;

        public int SelectedRecordsNumber {
            get {
                return _SelectedRecordsNumber;
            }
            set {
                _SelectedRecordsNumber = value;
            }
        }
        protected override IList FetchAllFilteredAndSortedRows() {
            return ((IEnumerable)View.DataControl.ItemsSource)
                .Cast<object>()
                .Take(SelectedRecordsNumber)
                .ToList();
        }

        protected override IList GetAllFilteredAndSortedRows() {
            return FetchAllFilteredAndSortedRows();
        }
    }
}
