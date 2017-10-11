using Android.App;
using Android.Widget;
using Android.OS;

namespace BMICalculator.Andriod
{
    [Activity (Label = "BMICalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button calculateButton;
        TextView resultTextView;
        EditText HeightEditText, WeightEditText;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            calculateButton = FindviewById<Button>(BMICalculator.Andriod.Resource.Id.CalculateButton);
            resultTextView = FindViewById<TextView>(BMICalculator.Andriod.Resource.Id.resultTextView);
            HeightEditText = FindViewById<EditText>(BMICalculator.Andriod.Resources.Id.HeightEditText);
            WeightEditText = FindViewById<EditText>(BMICalculator.Andriod.Resources.Id.WeightEditText);

            calculateButton.Click += CalculateButton_Click;
        }

        void CalculateButton_Click(object sender, System.EventArgs e)
        {
            float height = float.Parse(HeightEditText.Text);
            float weight = float.Parse(WeightEditText.Text);

            float bmi = (weight / (height * height));

            resultTextView.Text = bmi.ToString();
        }
    }
}

