

using System.Diagnostics.CodeAnalysis;

namespace GenericsAssignment
{
     public enum LifeStage: byte { Seed=0, Sprout, Stem, Flower };
    public class Flower : IEqualityComparer<Flower>, IComparer<Flower>
    {
        int ? heigth;
        public int? getHeigth()
        {
            if(heigth.HasValue)
                return heigth;
            return null;
        }
        public void setHeigth(int ?value)
        {
            heigth= value;
        }
        public string Name { get; set; }
        
        public LifeStage Stage { get; set; }
        
        public override string ToString()
        {
            return Name +" is now a " +Stage.ToString();
        }

        public bool Equals(Flower x, Flower y)
        {
            return x.Name == y.Name && x.Stage == y.Stage;
        }

        public int GetHashCode([DisallowNull] Flower obj)
        {
            return base.GetHashCode();
        }

        public int Compare(Flower x, Flower y)
        {
           if(x.Name.CompareTo(y.Name)<0)
                return -1;
           if(x.Name.CompareTo(y.Name)>0)
                return 1;
           if(x.Stage < y.Stage)
                return -1;
           if(x.Stage > y.Stage)
                return 1;
           return 0;
        }
    }
}
