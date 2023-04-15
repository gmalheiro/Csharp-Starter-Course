using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoExcecoesPersonalizadasRuim.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkin, DateTime checkout)
        {

            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                return "Error in reservation: Reservation dates for update must be future dates";
            }
            if (checkout <= checkin)
            {
                return "Error in reservation: Check-Out must be after check-in in date" ;
            }

            CheckIn = checkin;
            CheckOut = checkout;
            return null;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber} , check-in {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}
