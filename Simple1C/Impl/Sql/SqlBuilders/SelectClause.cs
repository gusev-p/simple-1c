﻿using System.Collections.Generic;
using System.Text;

namespace Simple1C.Impl.Sql.SqlBuilders
{
    public class SelectClause
    {
        public SelectClause(string tableName, string tableAlias)
        {
            TableName = tableName;
            TableAlias = tableAlias;
            JoinClauses = new List<JoinClause>();
            Fields = new List<SelectField>();
        }

        public List<SelectField> Fields { get; private set; }
        public List<JoinClause> JoinClauses { get; private set; }
        public string TableName { get; private set; }
        public string TableAlias { get; private set; }

        public string GetSql()
        {
            var b = new StringBuilder();
            b.Append("select");
            var isFirst = true;
            foreach (var f in Fields)
            {
                if (isFirst)
                    isFirst = false;
                else
                    b.Append(",");
                b.Append("\r\n\t");
                SqlHelpers.WriteReference(b, f.TableName, f.Name);
                SqlHelpers.WriteAlias(b, f.Alias);
            }
            b.Append("\r\nfrom ");
            SqlHelpers.WriteDeclaration(b, TableName, TableAlias);
            foreach (var join in JoinClauses)
            {
                b.Append("\r\n");
                b.Append(join.JoinKind);
                b.Append(" join ");
                SqlHelpers.WriteDeclaration(b, join.TableName, join.TableAlias);
                b.Append(" on ");
                foreach (var eq in join.EqConditions)
                {
                    SqlHelpers.WriteReference(b, join.TableAlias, eq.FieldName);
                    b.Append(" = ");
                    if (eq.ComparandConstantValue != null)
                        b.Append(eq.ComparandConstantValue);
                    else
                        SqlHelpers.WriteReference(b, eq.ComparandTableName, eq.ComparandFieldName);
                }
            }
            return b.ToString();
        }
    }
}