using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionNetCore_PatronesDeDiseno.PatronesDiseno.Creacionales
{

    public interface IPan
    {
        string Name { get; }
    }

    public class Baguette : IPan
    {
        public string Name => "Baguette";
    }

    public class Rollo : IPan
    {
        public string Name => "Rollo";
    }

    #region Factory

    public abstract class PanFactory
    {
        public abstract IPan CreatePan();
    }

    public class BaguetteFactory : PanFactory
    {
        public override IPan CreatePan()
        {
            return new Baguette();
        }
    }

    public class RolloFactory : PanFactory
    {
        public override IPan CreatePan()
        {
            return new Rollo();
        }
    }


    #endregion



}
