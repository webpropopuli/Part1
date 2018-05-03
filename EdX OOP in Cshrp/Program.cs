using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProj
{
    public class VendingMachine
    {
        public VendingMachine()
            {
            Console.WriteLine("New Machine created");
            this._location = "";
            this._capacity = 0;
            this._model = "";

            }

        public VendingMachine(int maxItems)
        {
            Console.WriteLine("New Machine created");
            this._capacity = maxItems;
        }

        private string _location;
        private int _capacity;
        private string _model;

        public void MakeCoffee()
        {

        }

        public void DispenseItem()
        {
            Console.WriteLine("Dispensing item now...");
            this._capacity--;
            return;
        }

        public int Capacity
        { get; set; }

        public void ShowStatus()
        {
            Console.WriteLine(
                "Machine " + this.Model + 
                " is located in " + this.Location + 
                "(Available: " + this._capacity +")");
        }

        public string Model
        {
            get { return _model; }
            set { if (value != null) _model = value; }
        }
        public string Location
        {
            get { return _location; }
            set { if (value != null)
                    _location = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine [] vm = new VendingMachine[3];

            vm[0] = new VendingMachine();
            vm[1] = new VendingMachine(300);
            vm[2] = new VendingMachine();

            vm[0].Location = "Lobby";
            vm[0].Model = "ChangeSiphon500";
            vm[0].Capacity = 100;

            vm[1].Location = "Kitchen 1";
            vm[1].Model = "JavaFlogger";

            for (int x=0; x < vm.Length; x++)
            {
                vm[x].ShowStatus();
            }
            vm[1].DispenseItem();
            vm[1].ShowStatus();
        }
    }
}
    