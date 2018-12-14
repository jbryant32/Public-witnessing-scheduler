using PWSSchduler.Converters;
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
    public partial class AlertViewCell : ViewCell
    {


        ObjectToAlertItem _ObjectToAlertItem = new ObjectToAlertItem();
        public ObjectToAlertItem objectToAlertItemConverter { get => _ObjectToAlertItem; set => _ObjectToAlertItem = value; }
        public string TextContent { get => (string)GetValue(TextContentProperty); set => SetValue(TextContentProperty, value); }
        public static readonly BindableProperty TextContentProperty = BindableProperty.Create(nameof(TextContent), typeof(object), typeof(AlertViewCell), null);
        public ICommand ViewCellTappedCommand { get => (Command)GetValue(ViewCellTappedCommandProperty); set => SetValue(ViewCellTappedCommandProperty, value); }
        public static readonly BindableProperty ViewCellTappedCommandProperty = BindableProperty.Create(nameof(ViewCellTappedCommand), typeof(Command), typeof(AlertViewCell), null);
        public object ViewCellContext { get => (object)GetValue(ViewCellContextProperty); set => SetValue(ViewCellContextProperty, value); }
        public static readonly BindableProperty ViewCellContextProperty = BindableProperty.Create(nameof(ViewCellContext), typeof(object), typeof(AlertViewCell), null);

        public AlertViewCell()
        {
            InitializeComponent();
        }

        //Wrapper for Command ,Command not working properly when used inside a viewcell
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var Param = ViewCellContext;
            ViewCellTappedCommand.Execute(this.BindingContext);
        }
    }
}