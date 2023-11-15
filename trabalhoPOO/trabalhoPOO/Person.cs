/*
 
 * Created by: GonçaloMalheiro
 * Email: a26064@alunos.ipca.pt
 * Descripton: Person class used in "StandPeople" to manage restaurant reservations
 * Date: 15-11-2023

 */

using System;

namespace trabalhoPOO
{
    public class Person
    {
        #region Attributes

        #region Attributes Object

        /// <summary>
        /// Attributes of the person class
        /// </summary>

        public string name; // Identifies the person name
        public int age; // Identifies the age of the person

        #endregion

        #region Attributes Class

        /// <summary>
        /// Attributes of the person class
        /// </summary>

        private static int totPersons; // Class Variable

        #endregion

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initialize class variable
        /// </summary>
        static Person()
        {
            totPersons = 0; // Class Attribute
        }

        /// <summary>
        /// The default Constructor.
        /// Create a Person using the default constructor.
        /// Will not be used because I will not create people only customers and employees.
        /// </summary>
        public Person()
        {
            name = "Rui";
            age = 18;
            totPersons++; // Class Attribute
        }

        /// <summary>
        /// Create a person using polymorphism 
        /// (same method but a different way of doing it (using parameters)).
        /// Will not be used because I will only create employees and customers.
        /// </summary>
        public Person(string n, int a)
        {
            name = n;
            age = a;
            totPersons++;
        }

        #endregion

        #region Properties 

        #region Properties Class

        /// <summary>
        /// Property of total Persons
        /// </summary>
        public static int TotPersons
        {
            get { return totPersons; } // Value only controlled internally
        }

        #endregion

        #region Properties Object

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Age property
        /// </summary>
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        #endregion

        #endregion

        #region OtherMethods

        //This Class will not have other methods implemented, because it will not be necessary to create "persons" in this project ( only customers will be created and employees).
       
        #endregion

        #region Override
        //Is not necessary to have a override in this class
        #endregion

        #region Destructor

        /// <summary>
        /// The default destructor
        /// </summary>
        ~Person()
        {
           
        }

        #endregion

        #endregion
    }
}

