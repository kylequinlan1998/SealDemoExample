using Microsoft.Research.SEAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoSeal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Ciphertext is correctly recognised however encryption parameters throws error.
            Ciphertext cipher;
            //Error gets thrown here.
            EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);
        }
    }
}
