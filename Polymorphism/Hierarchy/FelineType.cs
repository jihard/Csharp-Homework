using System;

namespace Hierarchy
{
    public abstract class FelineType : MammalType
    {
        private string breed;

        protected FelineType(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }
    }
}