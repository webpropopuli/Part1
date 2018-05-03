using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProj
{
    public class VendingMachine
    {
        private string _location;
        private int _capacity;
        private string _model;

        public VendingMachine()
            {
            Console.WriteLine("New Machine created");
            this.Location = this.Model = ""; 
            this._capacity = 0;
            }

        public VendingMachine(string loc, string mdl = "[unknown]", int cap = 125)
        {
            Console.WriteLine( "New Machine created" );
            this.Location = loc;
            this.Model = mdl;
            this.Capacity = cap;
        }

        public VendingMachine(int maxItems)
        {
            Console.WriteLine("New Machine created");
            this.Capacity = maxItems;
            this.Model = "[unknown]";
        }

        public void DispenseItem()
        {
            Console.WriteLine("Dispensing item now...");
            this.Capacity--;
            return;
        }


        public void ShowStatus(int y = 0)
        {
            Console.WriteLine(
                "Machine" + y + " " + this.Model + 
                " is located in " + this.Location + 
                "(Available: " + this.Capacity +")");
        }


        public int Capacity
        {
            get => _capacity; set => _capacity = value; 
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
            VendingMachine [] vm = new VendingMachine[4];

            vm[0] = new VendingMachine();
            vm[1] = new VendingMachine(300);
            vm[2] = new VendingMachine("Hallway");
            vm[3] = new VendingMachine();

            vm[0].Location = "Lobby";
            vm[0].Model = "ChangeSiphon500";
            vm[0].Capacity = 100;

            vm[1].Location = "Kitchen 1";
            vm[1].Model = "JavaFlogger";

            for (int x=0; x < vm.Length; x++)
            {
                vm[x].ShowStatus(x);
                Math.Pow( 2, 6 );
            }
            vm[1].DispenseItem();
            vm[1].ShowStatus();
        }
    }
}
    