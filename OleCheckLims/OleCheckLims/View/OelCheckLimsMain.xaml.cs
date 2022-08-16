using System;
using System.Linq;
using System.Windows;
using OelCheckLims.LimsDbContext;
using OelCheckLims.Model;
using OelCheckLims.ViewModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace OelCheckLims
{
    /// <summary>
    /// Interaction logic for OelCheckLims.xaml
    /// </summary>
    public partial class OelCheckLimsMain : Window
    {
        ObservableCollection<Sample> SampleListInfo = new ObservableCollection<Sample>();
        private LimsContext Context { get; }
        Sample SampleInfo = new Sample();
        public OelCheckLimsMain()
        {
            InitializeComponent();
            this.DataContext = new BatchSampleViewModel(Context);
            DataGridSample.Visibility = Visibility.Hidden;
            gridSampleList.Visibility = Visibility.Hidden;
        }
        private void OnTreeViewSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                #region Get Selected Item from Tree View 

                SelectedItem.Content = e.NewValue;
                string selectedItem = ((OelCheckLims.TreeviewItem)(SelectedItem.Content)).Name;

                #endregion

                #region Display additional information like TestClass,ReceivedDate, Hint based on Sample  

                BatchSampleViewModel batchSampleViewModel = new BatchSampleViewModel(Context);
                foreach (var sampleid in batchSampleViewModel.Context.Samples)
                {
                    if (selectedItem == sampleid.SampleId.ToString())
                    {
                        var SampleList = new ObservableCollection<Sample>
                    {
                     new Sample { TestClass = sampleid.TestClass.ToString(), ReceivedDate = sampleid.ReceivedDate, Hint = sampleid.Hint},
                    };
                        gridSampleList.Visibility = Visibility.Hidden;
                        DataGridSample.Visibility = Visibility.Visible;
                        DataGridSample.ItemsSource = SampleList;
                    }
                }

                #endregion

                #region run linq query to get samples list based on batchs

                int batchid = Convert.ToInt32(selectedItem);
                var SamplesList = batchSampleViewModel.Context.Batchs.Where(r => r.BatchId == batchid)
                                      .Select(p => p.Samples).ToList();
                #endregion

                #region Clear List and clear children in Grid

                SampleListInfo.Clear();
                gridSampleList.Children.Clear();

                #endregion

                gridSampleList.Width = 400;
                gridSampleList.Height = 200;
                gridSampleList.HorizontalAlignment = HorizontalAlignment.Left;
                gridSampleList.VerticalAlignment = VerticalAlignment.Top;
                if (SamplesList.Count > 0)
                {
                    foreach (var sampleid in SamplesList[0])
                    {
                        SampleInfo = new Sample { SampleId = sampleid.SampleId, Col = sampleid.Col, Position = sampleid.Position, Row = sampleid.Row };

                        for (int i = 0; i <= 4; i++)
                        {
                            for (int j = 0; j <= 3; j++)
                            {
                                #region Linq Query to get row with column eg. (row,col)- (0,0) (1,1)

                                var RowColumnCount = SamplesList[0].Where(r => r.Row == i & r.Col == j)
                                    .Select(p => p.SampleId).ToList();

                                #endregion

                                if (RowColumnCount.Count > 0)
                                {
                                    TextBlock RowsSampleID = new TextBlock();
                                    RowsSampleID.Text = sampleid.SampleId.ToString();
                                    Grid.SetRow(RowsSampleID, sampleid.Row);
                                    Grid.SetColumn(RowsSampleID, sampleid.Col);
                                    gridSampleList.Children.Add(RowsSampleID);

                                }
                                else
                                {
                                    TextBlock RowsSampleID = new TextBlock();
                                    RowsSampleID.Text = "";
                                    Grid.SetRow(RowsSampleID, sampleid.Row);
                                    Grid.SetColumn(RowsSampleID, sampleid.Col);
                                    gridSampleList.Children.Add(RowsSampleID);
                                }
                            }

                        }

                        SampleListInfo.Add(SampleInfo);
                    }
                    DataGridSample.Visibility = Visibility.Hidden;
                    gridSampleList.Visibility = Visibility.Visible;
                    gridSampleList.DataContext = SampleListInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
