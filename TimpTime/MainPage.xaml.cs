namespace TimpTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        

        public MainPage()
        {
            InitializeComponent();
            PorcentagemSlider.Value = 15;
        }

        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {
            Math.Ceiling(Convert.ToDouble(ValorTotalLabel));
        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {
            Math.Floor(Convert.ToDouble(ValorTotalLabel));
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
                try
                {

                    float Porcentag = (float)PorcentagemSlider.Value;
                    float ValorTotal = (float.Parse(ValorTotalEntry.Text));

                    float ValorGorgeta = ValorTotal * (Porcentag / 100);

                    ValorGorjetaLabel.Text = ValorGorgeta.ToString("C");

                    PorcentagemGorjetaLabel.Text = Porcentag.ToString("F") + '%';

                    float ValorFinal = ValorTotal + ValorGorgeta;

                    ValorTotalLabel.Text = ValorFinal.ToString("C");

                    ErroLabel.Text = "";
                } 
                catch (Exception r)
                {
                    Console.WriteLine(r.ToString());
                    ErroLabel.Text = "Por favor, insira um valor válido.";
            }

            }


        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }
    }

}
