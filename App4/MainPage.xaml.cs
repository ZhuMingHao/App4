using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private SimpleOrientationSensor simpleorientation;
        public MainPage()
        {
            this.InitializeComponent();
            simpleorientation = SimpleOrientationSensor.GetDefault();
            if (simpleorientation != null)
            {
                simpleorientation.OrientationChanged += new TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs>(OrientationChanged);
            }
        }

        private async void OrientationChanged(SimpleOrientationSensor sender, SimpleOrientationSensorOrientationChangedEventArgs args)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {

                SimpleOrientation orientation = args.Orientation;
                switch (orientation)
                {
                    case SimpleOrientation.NotRotated:

                        break;
                    case SimpleOrientation.Rotated90DegreesCounterclockwise:
                        myStoryBoard.Begin();
                        break;

                    case SimpleOrientation.Rotated180DegreesCounterclockwise:
                        myStoryBoard.Begin();
                        break;

                    case SimpleOrientation.Rotated270DegreesCounterclockwise:
                        myStoryBoard.Begin();
                        break;

                    case SimpleOrientation.Faceup:
                        break;

                    case SimpleOrientation.Facedown:
                        break;
                    default:

                        break;
                }

            });
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
