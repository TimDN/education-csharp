using System;
using System.Collections.Generic;
using System.Text;

namespace Dummy.Bookings
{
    public class Reservation
    {
        private User _reservedBy;

        public Reservation(User reservedBy)
        {
            if (reservedBy is null) throw new ArgumentNullException(nameof(reservedBy));
            ReservedBy = reservedBy;
        }

        public User ReservedBy 
        {
            get
            {
                return _reservedBy;
            }
            set
            {
                if (value is null) throw new ArgumentNullException(nameof(ReservedBy));
                _reservedBy = value;
            }
        }

        public bool CanCancel(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));

            return user.IsAdmin || user == ReservedBy;
        }
    }
}
