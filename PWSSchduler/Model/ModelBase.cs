using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace PWSSchduler.Model
{
    [Serializable]
    public class ModelBase : INotifyPropertyChanged, INotifyCollectionChanged, INotifyPropertyChanging,IDisposable
    {
        bool _isDirty;
        public bool isDirty { get=>_isDirty; set { _isDirty = value; this.OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangingEventHandler PropertyChanging;
        public ModelBase()
        {
            PropertyChanged += OnPropertyChanged;
        }

        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error on Method Property Changed{ex.Message}");
            }
        }

        protected virtual void OnPropertyChanging([CallerMemberName] string name=null) {
            if (name == null) return;
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(name));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string name = null) {
            if (name == null) return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected virtual void OnCollectionChanged([CallerMemberName] string name = null) {
            if (name == null) return;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            OnPropertyChanged(name);
        }
        ~ModelBase()
        {
            Dispose(false);
        }
        [XmlIgnore]
        private bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed) {
                if (disposing)
                {
                    Console.WriteLine("Disposing..");
                }
                _disposed = true;
            }
        }
    }
}
