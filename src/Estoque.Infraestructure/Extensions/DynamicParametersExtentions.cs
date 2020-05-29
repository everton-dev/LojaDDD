using Dapper;
using System;
using System.Data;

namespace Estoque.Infraestructure
{
    public static class DynamicParametersExtentions
    {
        public static void AddAtivo(this DynamicParameters p, bool value)
        {
            p.Add("@Ativo", value: value, dbType: DbType.Boolean, direction: System.Data.ParameterDirection.Input);
        }

        public static void AddUsuarioCriacao(this DynamicParameters p, string value)
        {
            p.Add("@UsuarioCriacao", value: value, dbType: DbType.String, direction: System.Data.ParameterDirection.Input);
        }

        public static void AddDataCriacao(this DynamicParameters p, DateTime value)
        {
            p.Add("@DataCriacao", value: value, dbType: DbType.DateTime, direction: System.Data.ParameterDirection.Input);
        }

        public static void AddUsuarioAtualizacao(this DynamicParameters p, string value)
        {
            p.Add("@UsuarioAtualizacao", value: value, dbType: DbType.String, direction: System.Data.ParameterDirection.Input);
        }

        public static void AddDataAtualizacao(this DynamicParameters p, DateTime? value)
        {
            p.Add("@DataAtualizacao", value: value, dbType: DbType.DateTime, direction: System.Data.ParameterDirection.Input);
        }

        public static void AddDefault(this DynamicParameters p, string name, object value)
        {
            DbType dbType;

            if (value is short)
                dbType = DbType.Int16;
            else if (value is int)
                dbType = DbType.Int32;
            else if (value is long)
                dbType = DbType.Int32;
            else if (value is decimal)
                dbType = DbType.Decimal;
            else if (value is float)
                dbType = DbType.Double;
            else if (value is string)
                dbType = DbType.String;
            else if (value is bool)
                dbType = DbType.Boolean;
            else if (value is Guid)
                dbType = DbType.Guid;
            else if (value is DateTime)
                dbType = DbType.DateTime;
            else if (value is DateTime?)
                dbType = DbType.DateTime;
            else
                dbType = DbType.String;

            p.Add(name, value: value, dbType: dbType, direction: System.Data.ParameterDirection.Input);
        }
    }
}