using AzureConecction;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AzureConecction
{

 
    public partial class MainPage : ContentPage
    {     
       
        public MainPage()
        {
            InitializeComponent();
            // Datos();
            TodoItemManager.Consulta();

        }

 
      
      

        public async void Datos() {
            //var lista = await TodoItemManager.GetTodoItemsAsync();
            //var lista = await TodoItemManager.getPin();
          
           // Debug.WriteLine(lista);
          /*  foreach (var stock in lista) {
                Debug.WriteLine("La Latitud es de :"+stock.Latitud);
                Debug.WriteLine("La Longitud es de :"+stock.Longitud);
                Debug.WriteLine("La Etiqueta es:"+stock.Label);
                Debug.WriteLine("El nombre es "+stock.IdString);
                Debug.WriteLine("La Url es :"+stock.Url);
                Debug.WriteLine("La Direccion es :"+stock._Address);
            }*/
        }



    }

    
}
