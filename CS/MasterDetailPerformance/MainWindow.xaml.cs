namespace MasterDetailPerformance {
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Data;
    using DevExpress.DocumentView;
    using DevExpress.Xpf.Grid;
    using DevExpress.Xpf.Printing;


    public partial class MainWindow {
        public List<Entitiy> Data {
            get;
            set;
        }
        public MainWindow() {
            this.InitializeComponent();
            InitData();
        }
        void InitData() {
            this.Data = new List<Entitiy>();
            for(int i = 0; i < 1000; i++) {
                this.Data.Add(
                    new Entitiy {
                        ID = i, Name = "Test Name #" + i.ToString()
                    });
            }
            this.DataContext = this;
        }
        private void PreviewButton_OnClick(object sender, RoutedEventArgs e) {
            this.PreviewDocument();
        }

        private void PreviewDocument() {
            var linkModel = new LinkPreviewModel(new PrintableControlLink((IPrintableControl)this.GridControl.View));
            linkModel.Link.CreateDocument(true);
            this.DocumentPreview.Model = linkModel;
        }
    }
}