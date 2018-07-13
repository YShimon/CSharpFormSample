using System;
using ReactiveUI;

namespace Mvvm.ViewModels
{
    public class SampleViewModel : ReactiveObject
    {
        private string inputString1;
        public string InputString1 {
            get { return inputString1; }
            set { this.RaiseAndSetIfChanged(ref inputString1, value); }
        }
 
        // 初期化コマンド
        public ReactiveCommand<object> Initialize { get; set; }

        public SampleViewModel()
        {
            // 初期化コマンドの作成
            Initialize = ReactiveCommand.Create(this.WhenAny(vm => vm.InputString1, str => true));
            Initialize.Subscribe(_ =>
            {
                InputString1 = "初期値1";
            });
        }
 
        public override string ToString()
        {
            return "1:" + InputString1 + Environment.NewLine;
        }
    }
}