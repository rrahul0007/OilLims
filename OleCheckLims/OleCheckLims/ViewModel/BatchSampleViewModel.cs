using System;
using OelCheckLims.LimsDbContext;
using OelCheckLims.Model;
using System.Collections.ObjectModel;
using System.Linq;
namespace OelCheckLims.ViewModel
{
  public class BatchSampleViewModel
    {
        public ObservableCollection<TreeviewItem> Items { get; set; }
        public LimsContext Context { get; }
        public BatchSampleViewModel(LimsContext context)
        {
            Context = new LimsContext();
            FillBatchSample();
        }

        private void FillBatchSample()
        {
            try
            {
                var Batchs = new ObservableCollection<Batch>
                   {
                        new Batch {BatchId = 79016,},
                        new Batch {BatchId = 79017,},
                        new Batch {BatchId = 79019,},
                    };

                var Samples = new ObservableCollection<Sample>
                   {
                        #region Batch id - 79016
                         
                        new Sample {SampleId = 8005678, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "Abweichung im Testumfang beachten", Batch = Batchs[0],Position=0,Col=0,Row=0},
                       new Sample {SampleId = 8078942, TestClass = "12MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "Abweichung im Testumfang beachten", Batch = Batchs[0],Position=1,Col=1,Row=0},
                       new Sample {SampleId = 7571269, TestClass = "2MD", ReceivedDate = new DateTime(2021, 12, 1), Hint = "Original Probe 8990472", Batch = Batchs[0],Position=2,Col=2,Row=0},
                       new Sample {SampleId = 8006003, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=3,Col=3,Row=0},
                       new Sample {SampleId = 8006004, TestClass = "2MD", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=4,Col=0,Row=1},
                       new Sample {SampleId = 8006005, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=5,Col=1,Row=1},
                       new Sample {SampleId = 8006006, TestClass = "12MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=6,Col=2,Row=1},
                         new Sample {SampleId = 8006007, TestClass = "3MD", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=7,Col=3,Row=1},
                         new Sample {SampleId = 8006008, TestClass = "2MB", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=8,Col=0,Row=2},
                         new Sample {SampleId = 8006009, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=9,Col=1,Row=2},
                         new Sample {SampleId = 8006010, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=10,Col=2,Row=2},
                         new Sample {SampleId = 8006011, TestClass = "12MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=11,Col=3,Row=2},
                         new Sample {SampleId = 8006012, TestClass = "2MD", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=12,Col=0,Row=3},
                         new Sample {SampleId = 8006013, TestClass = "2MD", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=13,Col=1,Row=3},
                         new Sample {SampleId = 8006015, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=14,Col=2,Row=3},
                         new Sample {SampleId = 8006016, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=15,Col=3,Row=3},
                         new Sample {SampleId = 8006017, TestClass = "4MG", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=16,Col=0,Row=4},
                         new Sample {SampleId = 8006018, TestClass = "2HL", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=17,Col=1,Row=4},
                        new Sample {SampleId = 8006019, TestClass = "2HL", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=18,Col=2,Row=4},
                        new Sample {SampleId = 8006020, TestClass = "2HL", ReceivedDate = new DateTime(2021, 12, 1), Hint = "", Batch = Batchs[0],Position=19,Col=3,Row=4},
                        
                            #endregion

                          #region Batch id - 79017

                           new Sample {SampleId = 8005235, TestClass = "8HV", ReceivedDate = new DateTime(2021, 12, 2), Hint = "", Batch = Batchs[1],Position=0,Col=0,Row=0},
                           new Sample {SampleId = 8005236, TestClass = "12GW", ReceivedDate = new DateTime(2021, 12, 2), Hint = "", Batch = Batchs[1],Position=2,Col=2,Row=0},
                           new Sample {SampleId = 8005237, TestClass = "8GV", ReceivedDate = new DateTime(2021, 12, 2), Hint = "Abweichung im Testumfang beachten", Batch = Batchs[1],Position=3,Col=3,Row=0},
                           new Sample {SampleId = 8005238, TestClass = "8GW", ReceivedDate = new DateTime(2021, 12, 2), Hint = "", Batch = Batchs[1],Position=5,Col=1,Row=1},

                          #endregion

                           #region Batch id - 79019

                           new Sample {SampleId = 7001232, TestClass = "8GV", ReceivedDate = new DateTime(2021, 11, 26), Hint = "Abweichung im Testumfang beachten", Batch = Batchs[2],Position=0,Col=0,Row=0},
                         
                           #endregion
                    };

                #region Adding sample based on batch number in Tree view

                Items = new ObservableCollection<TreeviewItem>
                {
                    new TreeviewItem("79016")
                    {
                        new TreeviewItem("8005678"),
                        new TreeviewItem("8078942"),
                        new TreeviewItem("7571269"),
                        new TreeviewItem("8006003"),
                        new TreeviewItem("8006004"),
                        new TreeviewItem("8006005"),
                        new TreeviewItem("8006006"),
                        new TreeviewItem("8006007"),
                        new TreeviewItem("8006008"),
                        new TreeviewItem("8006009"),
                        new TreeviewItem("8006010"),
                        new TreeviewItem("8006011"),
                        new TreeviewItem("8006012"),
                        new TreeviewItem("8006013"),
                        new TreeviewItem("8006014"),
                        new TreeviewItem("8006015"),
                        new TreeviewItem("8006016"),
                        new TreeviewItem("8006017"),
                        new TreeviewItem("8006018"),
                        new TreeviewItem("8006019"),
                        new TreeviewItem("8006020"),
                    },
                        new TreeviewItem("79017")
                        {
                            new TreeviewItem("8005235"),
                            new TreeviewItem("8005236"),
                            new TreeviewItem("8005237"),
                            new TreeviewItem("8005238")
                        },
                        new TreeviewItem("79019")
                        {
                            new TreeviewItem("7001232"),
                        },
            };

                #endregion

                #region Adding batchs & samples and also save in LimsDB database 

                if (!Context.Batchs.Any())
                {
                    Context.Batchs.AddRange(Batchs);
                    Context.Samples.AddRange(Samples);
                    Context.SaveChanges();
                };

                #endregion

            }
            catch (Exception ex)
            {
                throw new Exception("Exception from another Thread", ex);
            }
        }
    }
}
