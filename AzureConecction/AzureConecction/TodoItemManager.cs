using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureConecction
{
    public partial class TodoItemManager
    {
        static TodoItemManager defaultInstance = new TodoItemManager();
        MobileServiceClient client;
        static IMobileServiceTable<PIN> todoTable;


        public TodoItemManager()
        {
            this.client = new MobileServiceClient("http://androidserversynergia.azurewebsites.net");
            todoTable = client.GetTable<PIN>();

        }

        public static TodoItemManager DefaultManager
        {
            get { return defaultInstance; }
            private set { defaultInstance = value; }
        }
        public MobileServiceClient CurrentClient
        {
            get { return client; }
        }
        public static async Task<ObservableCollection<PIN>> GetTodoItemsAsync()
        {

            try
            {
                // IEnumerable<PIN> items = await todoTable.Where(x => x.ID == 1).ToEnumerableAsync();
                IEnumerable<PIN> items = await todoTable.Where(x => x.ID == 1).Select(x => x).ToListAsync();
                return new ObservableCollection<PIN>(items);
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine(@"Invalid sync Operation:{0}", msioe.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Sync errors: {0}", ex.Message);
            }
            return null;
            /* IEnumerable<TodoItem> items = await todoTable.Where(todoItem => todoItem.ID > 0  ).ToEnumerableAsync();
            IEnumerable<TodoItem> items = await todoTable.Where(todoItem => todoItem.ID > 0).ToListAsync();
             return new ObservableCollection<TodoItem>(items); */

        }

        public static async Task<PIN> getPin() {
            var pines = await todoTable.Where(acct => acct.ID == 1).Select(acct => acct).ToListAsync();

            return pines[0];
        }

        public static async void Consulta()
        {

            List<PIN> pines = await todoTable.Where(todoPin => todoPin.ID > 0).ToListAsync();

            foreach (var pin2 in pines) {
                Debug.WriteLine("*******************************");
                Debug.WriteLine(pin2.ID);
            }


        }






    }
}
