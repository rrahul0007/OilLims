using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OelCheckLims.Model
{
  public  class Batch : NotifyProperty
    {
        private IList<Sample> _samples;
        private int _batchId;

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BatchId
        {
            get => _batchId;
            set
            {
                if (value == _batchId) return;
                _batchId = value;
                OnPropertyChanged();
            }
        }

        public virtual IList<Sample> Samples
        {
            get => _samples;
            set
            {
                if (Equals(value, _samples)) return;
                _samples = value;
                OnPropertyChanged();
            }
        }

        public Batch()
        {
            _samples = new List<Sample>();
        }
    }
}
