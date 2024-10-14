namespace FuelSoluction{
    public partial class MainPage : ContentPage{
        int count = 0;

        public MainPage(){
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e){
            try{
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";
                double rendimentoEtanol = 0.7;
                if (etanol <= (gasolina * rendimentoEtanol)){
                    msg = "O etanol está compensando.";
                }
                else{
                    msg = "A gasolina está compensando.";
                }
                DisplayAlert("Calculado", msg, "OK");
            }
            catch(Exception ex){
                DisplayAlert("Ops", ex.Message,"Fechar");
            }
        }// fecha método
    }// fecha class

}// fecha namespace
