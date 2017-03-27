
#if WINDOWS
#define NATIVE_LONG_32_BIT_ON_64_BIT_SYSTEMS
#endif

using System;

namespace ODE
{
    public struct nulong : IEquatable<nulong>, IEquatable<uint>, IEquatable<ulong>
    {
#if NATIVE_LONG_32_BIT_ON_64_BIT_SYSTEMS
        private readonly UInt32 m_data;
#else
        private readonly UIntPtr m_data;
#endif

        public nulong(uint data)
        {
#if NATIVE_LONG_32_BIT_ON_64_BIT_SYSTEMS
            m_data = (UInt32)data;
#else
            m_data = (UIntPtr)data;
#endif
        }

        public nulong(ulong data)
        {
#if NATIVE_LONG_32_BIT_ON_64_BIT_SYSTEMS
            m_data = (UInt32)data;
#else
            m_data = (UIntPtr)data;
#endif
        }

        public uint ToUInt32()
        {
            return (uint)m_data;
        }

        public ulong ToUInt64()
        {
            return (ulong)m_data;
        }

        public bool Equals(nulong o)
        {
            return m_data == o.m_data;
        }

        public bool Equals(uint o)
        {
            return ToUInt64() == (ulong)o;
        }

        public bool Equals(ulong o)
        {
            return ToUInt64() == o;
        }

        public static bool operator==(nulong a, nulong b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(nulong a, nulong b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(nulong a, uint b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(nulong a, uint b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(nulong a, ulong b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(nulong a, ulong b)
        {
            return !a.Equals(b);
        }

        public static explicit operator uint(nulong a)
        {
            return a.ToUInt32();
        }

        public static implicit operator ulong(nulong a)
        {
            return a.ToUInt64();
        }

        public static implicit operator nulong(uint a)
        {
            return new nulong(a);
        }

        public static explicit operator nulong(ulong a)
        {
            return new nulong(a);
        }

        public override bool Equals(object obj)
        {
            if( obj is nulong)
            {
                return Equals((nulong)obj);
            }
            else if(obj is uint)
            {
                return Equals((uint)obj);
            }
            else if (obj is ulong)
            {
                return Equals((ulong)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return m_data.GetHashCode();
        }

        public override string ToString()
        {
            return m_data.ToString();
        }
    }
}
