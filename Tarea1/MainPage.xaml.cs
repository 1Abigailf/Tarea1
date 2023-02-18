using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1
{
      public partial class MainPage : ContentPage
    {
        int numero1;
        int numero2;
        double operationr ;
    
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    

        private void btnsumar_Clicked(object sender, EventArgs e)
        {
            
           
            numero1 = int.Parse(txtn1.Text);
            numero2 = int.Parse(txtn2.Text);
            operationr = numero1 + numero2;
            lblesltado.Text = operationr + "";
        }

        private void btnrestar_Clicked(object sender,EventArgs e)
        {
            numero1 = int.Parse(txtn1.Text);
            numero2 = int.Parse(txtn2.Text);
            operationr = numero1 - numero2;
            lblesltado.Text = operationr + "";
        }

        private void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            numero1 = int.Parse(txtn1.Text);
            numero2 = int.Parse(txtn2.Text);
            operationr = numero1 * numero2;
            lblesltado.Text = operationr + "";
        }

        private void btndividir_Clicked(object sender, EventArgs e)
        {
            numero1 = int.Parse(txtn1.Text);
            numero2 = int.Parse(txtn2.Text);
            operationr = numero1 / numero2;
            lblesltado.Text = operationr + "";
        }
         

    }
}
