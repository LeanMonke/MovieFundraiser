using System;
using System.Collections.Generic;
using System.Text;

namespace MovieFundraiser
{
    class TicketHolder
    {
        //attributes for feilds//
        private string name;
        private int age;
        private int numberTickets;
        private bool credit;
        private List<string> snackOrder = new List<string>();
        private List<int> snackQuantity = new List<int>();
        private List<string> drinkOrder = new List<string>();
        private List<int> drinkQuantity = new List<int>();

        //contstructer - constructs an object of this class//
        public TicketHolder()
        {

        }
        //getage returns the value in the private age variable//
        public int getAge()
        {
            return 0;
        }
        //set age - sets the value of the private age variable
        public void setAge(int newAge)
        {

        }

        //calculateTotalCost- Will be used to calculate the total cost of the night//
        public float CalculateTotalCost()
        {
            return 0.0f;
        }
        //GenerateReciept-displays the receipt for the purchesed items//
        public string GenerateReciept()
        {
            return "";
        }
        //tostring-returns all the values stored in the private variable//
        public override string ToString()
        {
            return "";

        }




    }
}
