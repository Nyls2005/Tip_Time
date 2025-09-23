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
            double Porcentag = (double)PorcentagemSlider.Value;
            double ValorTotal = (double.Parse(ValorTotalEntry.Text));

            double ValorGorgeta = ValorTotal * (Porcentag / 100);

            ValorGorjetaLabel.Text = ValorGorgeta.ToString("C");

            PorcentagemGorjetaLabel.Text = Porcentag.ToString("F") + '%';

            double ValorFinal = ValorTotal + ValorGorgeta;

            ValorTotalLabel.Text = "R$" + Math.Ceiling(ValorFinal);
        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {
            double Porcentag = (double)PorcentagemSlider.Value;
            double ValorTotal = (double.Parse(ValorTotalEntry.Text));

            double ValorGorgeta = ValorTotal * (Porcentag / 100);

            ValorGorjetaLabel.Text = ValorGorgeta.ToString("C");

            PorcentagemGorjetaLabel.Text = Porcentag.ToString("F") + '%';

            double ValorFinal = ValorTotal + ValorGorgeta;

            ValorTotalLabel.Text = "R$" + Math.Floor(ValorFinal);
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
                try
                {

                    double Porcentag = (double)PorcentagemSlider.Value;
                    double ValorTotal = (double.Parse(ValorTotalEntry.Text));

                    double ValorGorgeta = ValorTotal * (Porcentag / 100);

                    ValorGorjetaLabel.Text = ValorGorgeta.ToString("C");

                    PorcentagemGorjetaLabel.Text = Porcentag.ToString("F") + '%';

                    double ValorFinal = ValorTotal + ValorGorgeta;

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
