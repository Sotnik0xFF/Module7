using System;

namespace Module7
{
    public abstract class BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        private TKey id;

        public BaseEntity()
        {
        }

        public virtual TKey Id
        {
            get => id;
            protected set => id = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseEntity<TKey>))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }
                
            if (GetType() != obj.GetType())
            {
                return false;
            }

            if (Id == null || ((BaseEntity<TKey>)obj).Id == null)
            {
                return false;
            }

            return Id.Equals(((BaseEntity<TKey>)obj).Id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public static bool operator == (BaseEntity<TKey> left, BaseEntity<TKey> right)
        {
            if  (Object.Equals(left, null))
            {
                return Object.Equals(right, null) ? true: false;
            }
            return left.Equals(right);
        }

        public static bool operator != (BaseEntity<TKey> left, BaseEntity<TKey> right)
        {
            return !(left == right);
        }
    }
}
