namespace TimpTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            float Porcentag = (float)PorcentagemSlider.Value;
            float ValorTotal = (float.Parse(ValorTotalEntry.Text));
            
            float ValorGorgeta = ValorTotal * (Porcentag / 100);
            
            ValorGorjetaLabel.Text = ValorGorgeta.ToString();

            PorcentagemGorjetaLabel.Text = Porcentag.ToString() + '%';

            float ValorFinal = ValorTotal + ValorGorgeta;

            ValorTotalLabel.Text = ValorFinal.ToString();


        }

        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }
    }

}
