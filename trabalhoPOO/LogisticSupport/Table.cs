/*

 * Created by: GonçaloMalheiro
 * Email: a26064@alunos.ipca.pt
 * Descripton: Table class used in "LogisticSupport" to manage restaurant reservations
 * Date: 15-11-2023

 */

using System;


public enum TypeTable
{
    OCCUPIED,
    EMPTY,
}

namespace LogisticSupport
{
    public class Table

    {
        #region Attributes

        #region Attributes Object

        ///<summary>
        ///The attributes of the table class.
        ///</summary>

        private int numTable;//identifies the number of the table
        private int idTable; //identifies the id of the table
        private int capacity;//identifies the capacity of the table 
        private TypeTable occupation; //identifies if the table is busy or not ( i will see in next phase )

        #endregion

        #region Attributes Class

        private static int totIdTable; //Class Variable
        //in the next phase (i dont know if i will put totalCapacity;

        #endregion

        #endregion

        #region Methods 

        #region Constructor

        ///<summary>
        ///Initialize class variable
        ///</summary>
        static Table()
        {
            totIdTable = 0; //Class Attribute
        }

        ///<summary>
        ///The default Constructor.
        ///Create a table, using the default constructor
        ///</summary>
        public Table()
        {
            numTable = 10;
            capacity = 2;
            occupation = TypeTable.EMPTY; // ( i will see in the next phase)
            totIdTable++; //Class attributes: Table

        }

        ///<summary>
        ///Create a table: using polymorphism (same method, but different way of doing it (using parameters))
        ///</summary>
        public Table(int num, int c, TypeTable t)
        {
            numTable = num;
            capacity = c;
            occupation = t;
            totIdTable++; //Class attributes: Table
        }

        #endregion

        #region Properties

        #region Properties Class

        ///<summary>
        ///Property of total id table
        ///</summary>
        public static int TotIdTable
        {
            get { return totIdTable; } //value only controlled internally
        }

        #endregion

        #region Properties Object

        ///<summary>
        ///NumTable property
        ///<summary>

        public int NumTable
        {
            get { return numTable; } 
            set { numTable = value; }
        }

        ///<summary>
        ///Capacity property
        ///<summary>
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        ///<summary>
        ///TypeTable property
        ///<summary>
        public TypeTable Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        #endregion

        #endregion

        #region Overrides

        public override bool Equals(object obj)

        ///<summary>
        ///Testing if obj is Table
        ///<summary>

        {
            Table aux = (Table)obj;
            if (this.numTable == aux.numTable && this.capacity == aux.capacity && this.occupation == aux.occupation ) return true;
            return false;

        }

        #endregion

        #region OtherMethods

        //Other Methods implemented for phase 2 in future


        //public bool InsertTableRestaurant(Table t1)

        //public bool ExistTableRestaurant(Table t1)

        //public bool ExistTableRestaurant(int numTable, int capacity, TypeTable occupation)

        //public void ShowTables()

        //public int HowManyTables()

        //public int HowManyTablesExist(string num)

        //public Table[] TablesExistings()

        #endregion

        #region Destructor

        /// <summary>
        /// The default destructor
        /// </summary>

        ~Table()
        {

        }

        #endregion

        #endregion
    }
}
