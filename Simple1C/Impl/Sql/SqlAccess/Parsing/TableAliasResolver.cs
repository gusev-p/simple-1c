using System.Collections.Generic;
using Simple1C.Impl.Sql.SqlAccess.Syntax;
using Simple1C.Impl.Sql.Translation;

namespace Simple1C.Impl.Sql.SqlAccess.Parsing
{
    internal class TableAliasResolver : SqlVisitor
    {
        private Dictionary<string, SelectFieldExpression> aliasedExpressions =
            new Dictionary<string, SelectFieldExpression>();

        private bool inOrderBy;

        public static void Process(ISqlElement element)
        {
            new TableAliasResolver().Visit(element);
        }

        public override SelectFieldExpression VisitSelectField(SelectFieldExpression clause)
        {
            if (!string.IsNullOrEmpty(clause.Alias))
                aliasedExpressions[clause.Alias] = clause;
            return base.VisitSelectField(clause);
        }

        public override ISqlElement VisitColumnReference(ColumnReferenceExpression expression)
        {
            SelectFieldExpression selectExpression;
            if (inOrderBy
                && !string.IsNullOrEmpty(expression.Name)
                && aliasedExpressions.TryGetValue(expression.Name, out selectExpression))
                return selectExpression.Expression;
            return base.VisitColumnReference(expression);
        }

        public override OrderByClause VisitOrderBy(OrderByClause element)
        {
            inOrderBy = true;
            var result = base.VisitOrderBy(element);
            inOrderBy = false;
            return result;
        }

        public override SqlQuery VisitSqlQuery(SqlQuery sqlQuery)
        {
            var previous = aliasedExpressions;
            aliasedExpressions = new Dictionary<string, SelectFieldExpression>();
            var result = base.VisitSqlQuery(sqlQuery);
            aliasedExpressions = previous;
            return result;
        }
    }
}