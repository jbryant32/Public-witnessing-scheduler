using PWSSchduler.Model;
using PWSSchduler.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertItemViewCell : ContentView
    {
        //public bool isPrestene { get => (bool)GetValue(isPresteneProperty); set => SetValue(isPresteneProperty, value); }
        //public static readonly BindableProperty isPresteneProperty = BindableProperty.Create(nameof(isPrestene), typeof(bool), typeof(AlertItemViewCell), true);
        bool _isPrestene = true;
        public bool isPrestene { get => _isPrestene; set {_isPrestene = value; OnPropertyChanged(); } }
        public string TextContent { get => (string)GetValue(TextContentProperty); set => SetValue(TextContentProperty, value); }
        public static readonly BindableProperty TextContentProperty = BindableProperty.Create(nameof(TextContent), typeof(object), typeof(AlertItemViewCell), null);
        public ICommand ViewCellTappedCommand { get => (Command)GetValue(ViewCellTappedCommandProperty); set => SetValue(ViewCellTappedCommandProperty, value); }
        public static readonly BindableProperty ViewCellTappedCommandProperty = BindableProperty.Create(nameof(ViewCellTappedCommand), typeof(Command), typeof(AlertItemViewCell), null);
        public object ViewCellContext { get => (object)GetValue(ViewCellContextProperty); set => SetValue(ViewCellContextProperty, value); }
        public static readonly BindableProperty ViewCellContextProperty = BindableProperty.Create(nameof(ViewCellContext), typeof(object), typeof(AlertItemViewCell), null);
        public AlertItemViewCell()
        {
            InitializeComponent();
        }

      
    }
}