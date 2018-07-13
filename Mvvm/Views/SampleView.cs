// -------------------
// https://tocsworld.wordpress.com/2014/08/17/reactiveui-winforms%E3%82%92%E3%81%8B%E3%81%98%E3%82%8B/
// install-package reactiveui-winforms
// -------------------
namespace Mvvm.Views
{
    using System.Windows.Forms;
    using ReactiveUI;
    using Mvvm.ViewModels;
 
    public partial class SampleView : Form, IViewFor<SampleViewModel>
    {
        public SampleView(SampleViewModel viewModel)
        {
            InitializeComponent();
 
            ViewModel = viewModel;
            this.Bind(ViewModel, vm => vm.InputString1, v => v.input1TextBox.Text);
            //this.Bind(ViewModel, vm => vm.InputString2, v => v.input2TextBox.Text);
            //this.Bind(ViewModel, vm => vm.CurrentDateTime, v => v.currentDateTimePicker.Value);
            this.BindCommand(ViewModel, vm => vm.Initialize, v => v.executeButton);
            //this.closeButton.Click += (_, __) => this.Close();
        }
 
        public SampleViewModel ViewModel
        {
            get;set;
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = value as SampleViewModel; }
        }
    }
}