using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OelCheckLims.Model
{
  public class Sample : NotifyProperty
    {
        private Batch _batch;

        private int _sampleId;

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SampleId
        {
            get => _sampleId;
            set
            {
                if (value == _sampleId) return;
                _sampleId = value;
                OnPropertyChanged();
            }
        }

        private string _testclass;
        public string TestClass
        {
            get => _testclass;
            set
            {
                if (value == _testclass) return;
                _testclass = value;
                OnPropertyChanged();
            }
        }

        private string _hint;
        public string Hint
        {
            get => _hint;
            set
            {
                if (value == _hint) return;
                _hint = value;
                OnPropertyChanged();
            }
        }

        private DateTime _receiveddate;
        public DateTime ReceivedDate
        {
            get => _receiveddate;
            set
            {
                if (value == _receiveddate) return;
                _receiveddate = value;
                OnPropertyChanged();
            }
        }
        private int _position;
        public int Position
        {
            get => _position;
            set
            {
                if (value == _position) return;
                _position = value;
                OnPropertyChanged();
            }
        }

        private int _col;
        public int Col
        {
            get => _col;
            set
            {
                if (value == _col) return;
                _col = value;
                OnPropertyChanged();
            }
        }
        private int _row;
        public int Row
        {
            get => _row;
            set
            {
                if (value == _row) return;
                _row = value;
                OnPropertyChanged();
            }
        }
        public virtual Batch Batch
        {
            get => _batch;
            set
            {
                if (Equals(value, _batch)) return;
                _batch = value;
                OnPropertyChanged();
            }
        }

    }
}
