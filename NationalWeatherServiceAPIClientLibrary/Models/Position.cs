using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public class Position : IPosition, IEqualityComparer<Position>, IEquatable<Position>
    {
        public double? Altitude { get; }

        public double Latitude { get; }

        public double Longitude { get; }

        public Position(double latitude, double longitude, double? altitude = null)
        {
            Altitude = altitude;
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return string.Format($"Latitude: {Latitude}, Longitude: {Longitude}, Altitude: {Altitude?.ToString() ?? "N/A"}");
        }

        public override bool Equals(object obj)
        {
            return (this == (obj as Position));
        }
        public bool Equals(Position other)
        {
            return (this == other);
        }
        public bool Equals([AllowNull] Position x, [AllowNull] Position y)
        {
            return x.Equals(y);
        }

        public static bool operator ==(Position lhs, Position rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (ReferenceEquals(null, rhs) || ReferenceEquals(null, lhs))
            {
                return false;
            }

            if (lhs.Latitude != rhs.Latitude || lhs.Longitude != rhs.Longitude)
            {
                return false;
            }

            return lhs.Altitude.HasValue == rhs.Altitude.HasValue && lhs.Altitude == rhs.Altitude;
        }

        public static bool operator !=(Position lhs, Position rhs) => !(lhs == rhs);

        public override int GetHashCode()
        {
            var hash = 675 ^ Latitude.GetHashCode();
            hash = (hash * 675) ^ Longitude.GetHashCode();
            hash = (hash * 675) ^ Altitude.GetValueOrDefault().GetHashCode();
            return hash;
        }
        public int GetHashCode([DisallowNull] Position obj) => obj.GetHashCode();

    }
}
