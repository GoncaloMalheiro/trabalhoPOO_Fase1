/*

 * Created by: GonçaloMalheiro
 * Email: a26064@alunos.ipca.pt
 * Descripton: Reservation class used in "LogisticSupport" to manage restaurant reservations
 * Date: 15-11-2023

 */

using System;

public enum TypeReservation
{
    BUSY,
    BLANK,
    CANCELLEED,

}

namespace LogisticSupport
{
    public class Reservation

    {
        #region Attributes

        #region Attributes Object

        ///<summary>
        ///The attributes of the reservation class.
        ///</summary>

        private int numReservation;//identifies the number of the reservation
        private int idReservation; //identifies the id of the reservation
        private string date; //identifies the day of the date of the reservation
        private int numTable; //identifies the number of the table
        private TypeReservation status; //identifies if the reservation if it is (busy,blank, or cancelled) ( i will see in next phase )

        #endregion

        #region Attributes Class

        private static int totIdReservation; //Class Variable
        private static int totIdNumReservation; //Class Variable (will see next phase)

        #endregion

        #endregion

        #region Methods 

        #region Constructor

        ///<summary>
        ///Initialize class variable
        ///</summary>
        static Reservation()
        {
            totIdReservation = 0; //Class Attribute
            totIdNumReservation = 0; //Class Attribute (will see next phase)
        }

        ///<summary>
        ///The default Constructor.
        ///Create a reservation, using the default constructor
        ///</summary>
        public Reservation()
        {
            numTable = 10;
            date = "10:Hours";
            status = TypeReservation.BLANK; // ( i will see in the next phase)
            totIdNumReservation++; //Class attributes: Reservation (i will see in the next phase)
            totIdReservation++; //Class attributes: Reservation

        }

        ///<summary>
        ///Create a reservation: using polymorphism (same method, but different way of doing it (using parameters))
        ///</summary>
        public Reservation(int num, string d, TypeReservation s)
        {
            numTable = num;
            date = d;
            status = s;
            totIdNumReservation++; //Class attributes: Reservation (i will see in the next phase)
            totIdReservation++; //Class attributes: Reservation
        }

        #endregion

        #region Properties

        #region Properties Class

        ///<summary>
        ///Property of total id reservation
        ///</summary>
        public static int TotIdReservation
        {
            get { return totIdReservation; } //value only controlled internally
        }

        ///<summary>
        ///Property of total number of reservations
        ///</summary>

        public static int TotIdNumReservation
        {
            get { return totIdNumReservation; } //value only controlled internally
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
        ///Date property
        ///<summary>
        public string Date 
        {
            get { return date; }
            set { date = value; }
        }

        ///<summary>
        ///TypeOccupation property
        ///<summary>
        public TypeReservation Occupation
        {
            get { return status; }
            set { status = value; }
        }

        #endregion

        #endregion

        #region Overrides

        public override bool Equals(object obj)

        ///<summary>
        ///Testing if obj is Reseravtion
        ///<summary>

        {
            Reservation aux = (Reservation)obj;
            if (this.numTable == aux.numTable && this.date == aux.date && this.status == aux.status) return true;
            return false;

        }

        #endregion

        #region OtherMethods

        //Other Methods implemented for phase 2 in future


        //public bool InsertReservationsRestaurant(Reservation t1)

        //public bool ExistReservationsRestaurant(Reservation t1)

        //public bool ExistReservationsRestaurant(on)

        //public void ShowReservationss()

        //public int HowManyReservationss()

        //public int HowManyReservationsExist(string num)

        //public Reservation[] ReservationssExistings()

        #endregion

        #region Destructor

        /// <summary>
        /// The default destructor
        /// </summary>

        ~Reservation()
        {

        }

        #endregion

        #endregion

    }
}
