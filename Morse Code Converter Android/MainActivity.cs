using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using static Android.Resource;

namespace Morse_Code_Converter_Android
{
    [Activity(Label = "Morse Code Converter ", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            TextView t1 = FindViewById<TextView>(Resource.Id.editText1);
            TextView t2 = FindViewById<TextView>(Resource.Id.editText2);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {
                Dictionary<char, string> mcode = new Dictionary<char, string>()
            {
                {'a' , ".-"},
                { 'b' , "-..."},
                { 'c' , "-.-."},
                {'d' , "-.."},
                { 'e' , "."},
                { 'f' , "..-."},
                {'g' , "--."},
                { 'h' , "...."},
                { 'i' , ".."},
                {'j' , ".---"},
                { 'k' , "-.-"},
                { 'l' , ".-.."},
                {'m' , "--"},
                { 'n' , "-."},
                { 'o' , "---"},
                {'p' , ".--."},
                { 'q' , "--.-"},
                { 'r' , ".-."},
                {'s' , ".-."},
                { 't' , "-"},
                { 'u' , "..-"},
                {'v' , "...-"},
                { 'w' , ".--"},
                { 'x' , "-..-"},
                {'y' , "-.--"},
                { 'z' , "--.."},
                {'0' , "-----"},
                { '1' , ".----"},
                { '2' , "..----"},
                { '3' , "...--"},
                {'4' , "....-"},
                { '5' , "....."},
                { '6' , "-...."},
                { '7' , "--..."},
                {'8' , "---.."},
                { '9' , "----."},
            };
                string userText = t1.Text;
                userText = userText.ToLower();
                for (int index = 0; index < userText.Length; index++)
                {
                    char x = userText[index];
                    if (mcode.ContainsKey(x))
                    {
                        t2.Text += (mcode[x]);
                    }
                }
            };
            

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

