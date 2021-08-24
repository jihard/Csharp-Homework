using System;

namespace Hierarchy
{
    public abstract class MammalType : Animal
    {
        private string _livingRegion;

        protected MammalType(string name, double weight, string livingRegion) 
        : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return this._livingRegion; }
            set { this._livingRegion = value; }
        }
    }
}