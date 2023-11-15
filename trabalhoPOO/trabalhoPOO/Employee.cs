/*
 
 * Created by: GonçaloMalheiro
 * Email: a26064@alunos.ipca.pt
 * Descripton: Employee class used in "StandPeople" to manage restaurant reservations
 * Date: 15-11-2023

 */

using System;

public enum TypeEmployee
{
    CHEF,
    WAITER,
}

namespace trabalhoPOO
{
    public class Employee : Person

    {
        #region Attributes

        #region Attributes Object

        ///<summary>
        ///The attributes of the employee class.
        ///</summary>

        private int idEmployee; //identifies the employee id
        private TypeEmployee type; //identifies the type of employee

        #endregion

        #region Attributes Class

        private static int totIdEmployee; //Class Variable

        #endregion

        #endregion

        #region Methods 

        #region Constructor

        ///<summary>
        ///Initialize class variable
        ///</summary>
        static Employee()
        {
            totIdEmployee = 0; //Class Attribute
        }

        ///<summary>
        ///The default Constructor.
        ///Create a employee, using the default constructor
        ///</summary>
        public Employee()
        {
            name = "Goncalo";
            age = 18;
            type = TypeEmployee.WAITER;
            totIdEmployee++; //Class attributes: Employee
        }

        ///<summary>
        ///Create a employee: using polymorphism (same method, but different way of doing it (using parameters))
        ///</summary>
        public Employee(string n, int a, TypeEmployee t)
        {
            name = n;
            age = a;
            type = t;
            totIdEmployee++; //Class attributes: Employee
        }

        #endregion

        #region Properties

        #region Properties Class

        ///<summary>
        ///Property of total id employee
        ///</summary>
        public static int TotIdEmployee
        {
            get { return totIdEmployee; } //value only controlled internally
        }

        #endregion

        #region Properties Object

        ///<summary>
        ///IdEmployee property
        ///<summary>

        public int IdEmployee
        {
            get { return idEmployee; } //value only controlled internally
        }

        ///<summary>
        ///TypeEmployee property
        ///<summary>

        public TypeEmployee Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

        #endregion

        #region Overrides

        public override bool Equals(object obj)

        ///<summary>
        ///Testing if obj is Employee 
        ///<summary>

        {
            Employee aux = (Employee)obj;
            if (this.name == aux.name && this.type == aux.type) return true;
            return false;

        }

        #endregion

        #region OtherMethods

        //Other Methods implemented for phase 2 in future


        //public bool InsertEmployeeRestaurant(Employee e1)

        //public bool ExistEmployeeRestaurant(Employee e1)

        //public bool ExistEmployeeRestaurant(string name, int age, TypeEmployee t)

        //public void ShowEmployees()

        //public int HowManyEmployees()

        //public int HowManyEmployeesExist(string nome)

        //public Employee[] EmployeesExistings()

        #endregion

        #region Destructor

        /// <summary>
        /// The default destructor
        /// </summary>

        ~Employee()
        {

        }

        #endregion

        #endregion

    }
}