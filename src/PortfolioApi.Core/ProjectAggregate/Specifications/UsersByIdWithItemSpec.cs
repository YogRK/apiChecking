using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using PortfolioApi.Core.model;

namespace PortfolioApi.Core.ProjectAggregate.Specifications;
public class UsersByIdWithItemSpec : Specification<Users>,ISingleResultSpecification
{
  public UsersByIdWithItemSpec(int Id)
  {
    Query.Where(users => users.Id == Id)
      .Include(users => users.About);
  }
}
