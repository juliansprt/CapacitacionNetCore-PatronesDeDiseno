using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionNetCore_PatronesDeDiseno.PatronesDiseno.Estructurales
{
	public interface ICoffe
	{
		string Description { get; }
		double Cost { get; }
	}

    public class Espresso : ICoffe
    {
        public string Description => "Espresso";

        public double Cost => 2000;
    }


    #region Decoradores

    public abstract class CoffeDecorator : ICoffe
    {
        protected ICoffe _coffe;

        protected CoffeDecorator(ICoffe coffe)
        {
            _coffe = coffe;
        }

        public abstract string Description { get; }

        public abstract double Cost {get; }

    }


    public class ConLeche : CoffeDecorator
    {
        public ConLeche(ICoffe coffe) : base(coffe)
        {
        }

        public override string Description => $"{_coffe.Description}, con leche";
        public override double Cost => _coffe.Cost + 500;
    }

    public class ConCrema : CoffeDecorator
    {
        public ConCrema(ICoffe coffe) : base(coffe)
        {
        }

        public override string Description => $"{_coffe.Description}, con crema";

        public override double Cost => _coffe.Cost + 250;
    }
    #endregion
}
