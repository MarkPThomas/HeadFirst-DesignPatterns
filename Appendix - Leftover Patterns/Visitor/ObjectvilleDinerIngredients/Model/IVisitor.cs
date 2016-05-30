using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectvilleDinerIngredients.Model
{
    public interface IVisitor
    {
        void VisitIngredients(IIngredient ingredient);
    }
}
