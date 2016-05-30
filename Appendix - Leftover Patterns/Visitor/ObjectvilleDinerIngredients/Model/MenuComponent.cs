using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Lib;
using ObjectvilleDinerIngredients.Model;

namespace Menus.Model
{
    public abstract class MenuComponent : IIngredient, IElement
    {
        #region Methods: Composite
        protected string _name;
        public virtual string Name { get { throw new NotSupportedException(); }}

        protected string _description;
        public virtual string Description { get { throw new NotSupportedException(); } }

        protected bool _vegetarian;
        public virtual bool Vegetarian { get { throw new NotSupportedException(); }}

        protected double _price;
        public virtual double Price { get { throw new NotSupportedException(); } }

        protected string _ingredientName;
        public string IngredientName { get; private set; }

        protected HealthRating _healthRating;
        public virtual HealthRating HealthRating { get; private set; }

        protected int _calories;
        public virtual int Calories { get; private set; }

        protected int _protein;
        public virtual int Protein { get; private set; }

        protected int _carbs;
        public virtual int Carbs { get; private set; }


        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Methods: Operation
        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IIterator<MenuComponent> CreateIterator()
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Methods: Visitor
        public virtual void Accept(IVisitor visitor)
        {
            visitor.VisitIngredients(this);
        }
        #endregion
    }
}
