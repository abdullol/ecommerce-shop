using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    class SpecificationEvaluator<TEntity> where TEntity:BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery,
            ISpecification<TEntity> spec)
        {
            var query = inputQuery;
            if (spec.Criteria!=null)
            {
                // generic solution for Where Clause
                query = query.Where(spec.Criteria);
            }

            // generic solution for Include Statement
            query = spec.Includes.Aggregate(query, (current, include) =>
              current.Include(include));

            return query;
        }
    }
}
