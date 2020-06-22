namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_06
{
    public sealed class ProductSerialNumber
    {
        public ProductSerialNumber(
            string productSeries, int model, long id)
        {
            ProductSeries = productSeries;
            Model = model;
            Id = id;
        }

        public string ProductSeries { get; }
        public int Model { get; }
        public long Id { get; }


        public override int GetHashCode()
        {
            int hashCode = ProductSeries.GetHashCode();
            hashCode ^= Model;  // Xor (eXclusive OR)
            hashCode ^= Id.GetHashCode();  // Xor (eXclusive OR)
            return hashCode;
        }

        public override bool Equals(object? obj)
        {
            if(obj is null)
            {
                return false;
            }
            if(ReferenceEquals(this, obj))
            {
                return true;
            }
            if(this.GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((ProductSerialNumber)obj);
        }

        public bool Equals(ProductSerialNumber? obj)
        {
            // STEP 3: Possibly check for equivalent hash codes
            // if (this.GetHashCode() != obj.GetHashCode())
            // {
            //    return false;
            // } 

            // STEP 4: Check base.Equals if base overrides Equals()
            // System.Diagnostics.Debug.Assert(
            //     base.GetType() != typeof(object));
            // if ( base.Equals(obj) )
            // {
            //    return false;
            // } 

            // STEP 1: Check for null
            return ((obj is object)
                // STEP 5: Compare identifying fields for equality.
                && (ProductSeries == obj.ProductSeries) &&
                (Model == obj.Model) &&
                (Id == obj.Id));
        }

        public static bool operator ==(
            ProductSerialNumber leftHandSide,
            ProductSerialNumber rightHandSide)
        {

            // Check if leftHandSide is null
            // (operator == would be recursive)
            if(leftHandSide is null)
            {
                // Return true if rightHandSide is also null
                // and false otherwise
                return rightHandSide is null;
            }

            return (leftHandSide.Equals(rightHandSide));
        }

        public static bool operator !=(
            ProductSerialNumber leftHandSide,
            ProductSerialNumber rightHandSide)
        {
            return !(leftHandSide == rightHandSide);
        }
    }

}
