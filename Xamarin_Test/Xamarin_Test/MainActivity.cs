using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Xamarin_Test
{
    [Activity(Label = "Hallo Xamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public int AnzahlKlicks = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.ButtonKlickMich).Click += ButtonKlickMich_Click;
        }

        private void ButtonKlickMich_Click(object sender, EventArgs e)
        {
            EditText EditTextAnzahlKlicks = FindViewById<EditText>(Resource.Id.EditTextAnzahlKlicks);

            AnzahlKlicks++;
            EditTextAnzahlKlicks.Text = Convert.ToString(AnzahlKlicks);
        }
    }
}

