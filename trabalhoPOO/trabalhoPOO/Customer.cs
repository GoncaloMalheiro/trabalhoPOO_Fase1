/*

 * Created by: GonçaloMalheiro
 * Email: a26064@alunos.ipca.pt
 * Descripton: Customer class used in "StandPeople" to manage restaurant reservations
 * Date: 15-11-2023

 */

using System;


namespace trabalhoPOO
{
    public class Customer : Person
    {
        #region Attributes

        #region Object Attributes

        ///<summary>
        ///The attributes of the customer class.
        ///</summary>

        private int idReserve; //identifies the customer's reservation id
        private int idCustomer; //identifies the customer's id
        private int numContact; //identifies the customer's contact number

        #endregion

        #region Class Attributes

        #endregion

        private static int totIdReserve; //Class Variable
        private static int totIdCustomer; //Class Variable

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Initialize class variable
        /// </summary>
        static Customer()
        {
            totIdReserve = 0; //Class Attribute
            totIdCustomer = 0; //Class Attribute
        }

        /// <summary>
        /// The default Constructor.
        /// Create a customer, using the default constructor
        /// </summary>
        public Customer()
        {
            name = "Goncalo";
            age = 18;
            numContact = 968666901;
            totIdReserve++; //Class attributes: Customer
            totIdCustomer++; //Class attributes: Customer
        }

        ///<summary>
        ///Create a customer: using polymorphism (same method, but different way of doing it (using parameters))
        ///</summary>

        public Customer(string n, int a, int nc)
        {
            name = n;
            age = a;
            numContact = nc;
            totIdReserve++; //Class attributes: Customer
            totIdCustomer++; //Class attributes: Customer
        }
        #endregion

        #region Properties


        #region Properties Class
        ///<summary>
        ///Property of total id reserve
        ///</summary>
        public static int TotIdReserve
        {
            get { return totIdReserve; } //value only controlled internally
        }

        ///<summary>
        ///Property of total id customer
        ///</summary>
        public static int TotIdCustomer
        {
            get { return totIdCustomer; } //value only controlled internally
        }

        #endregion

        #region Properties Object

        /// <summary>
        /// IdCustomer property
        /// </summary>
        public int IdCustomer
        {
            get { return idCustomer; } //value only controlled internally
        }

        /// <summary>
        /// IdReserve property
        /// </summary>
        
        public int IdReserve
        {
            get { return idReserve; }

        }

        /// <summary>
        ///Numcontact property
        /// </summary>
        public int NumContact
        {
            set { numContact = value; }
            get { return numContact; }
        }

        #endregion

        #endregion

        #region Override

        ///<summary>
        ///Testing if obj is Customer
        ///<summary>
        public override bool Equals(object obj)
        {
            Customer aux = (Customer)obj;
            if (this.name == aux.name && this.numContact == aux.numContact) return true;
            return false;

        }

        #endregion

        #region OtherMethods

        //Future methods that will be implemented in another class to manage customers (phase 2)

        //public bool InsertCustomerRestaurant(Customer c1)

        //public bool ExistCustomerRestaurant(Customer c1)

        //public bool ExistCustomerRestaurant(string name, int age, int cs)

        //public void ShowCustomers()

        //public int HowManyCustomers()

        //public int HowmanyCustomersExists(string nome)

        //public Customer[] CustomersExistings()

        #endregion

        #region Override

        #endregion

        #region Destructor 

        /// <summary>
        /// The default destructor
        /// </summary>

        ~Customer()
        {
            // Add any necessary cleanup code here
        }
        #endregion

        #endregion
    }
}
