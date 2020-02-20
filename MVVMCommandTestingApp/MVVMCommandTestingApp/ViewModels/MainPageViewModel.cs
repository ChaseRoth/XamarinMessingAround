using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Timers;

namespace MVVMCommandTestingApp.ViewModels
{
    public class MainPageViewModel : NotifyClass
    {
        public Timer RotationTimer { get; set; } = new Timer(30);
        public ICommand SliderValueChangedFinishedCMD { get; set; }
        public ICommand SliderValueChangingCMD { get; set; }

        private int rotation;
        public int Rotation { 
            get => rotation;
            set
            {
                rotation = value;
                NotifyPropertyChanged();
            } 
        }

        private double sliderValue;
        public double SliderValue { 
            get => sliderValue;
            set
            {
                sliderValue = value;
                NotifyPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            SliderValueChangedFinishedCMD = new Command(SliderMoveCompleted);
            SliderValueChangingCMD = new Command(SliderMoving);
            RotationTimer.Elapsed += delegate { Rotation += 10; };
            RotationTimer.Start();
        }

        private void SliderMoveCompleted()
        {
            Console.WriteLine();
        }

        private void SliderMoving()
        {
            Console.WriteLine();
        }
    }
}
