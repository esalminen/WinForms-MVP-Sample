using MVP_RJCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MVP_RJCode._Repositories
{
    public class ParcelRepository : BaseRepository, IParcelRepository
    {
        public ParcelRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ParcelModel parcelModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into MyParcels values (@parcelId, @address, @productTypeId, @productTypeName)";
                command.Parameters.Add("@parcelId", SqlDbType.NVarChar).Value = parcelModel.ParcelId;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = parcelModel.Address;
                command.Parameters.Add("@productTypeId", SqlDbType.NVarChar).Value = parcelModel.ProductTypeId;
                command.Parameters.Add("@productTypeName", SqlDbType.NVarChar).Value = parcelModel.ProductTypeName;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"delete from MyParcels where parcelId=@parcelId";
                command.Parameters.Add("@parcelId", SqlDbType.NVarChar).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ParcelModel parcelModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update MyParcels 
                                        set address=@address, productTypeId=@productTypeId, productTypeName=@productTypeName
                                        where parcelId=@parcelId";
                command.Parameters.Add("@parcelId", SqlDbType.NVarChar).Value = parcelModel.ParcelId;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = parcelModel.Address;
                command.Parameters.Add("@productTypeId", SqlDbType.NVarChar).Value = parcelModel.ProductTypeId;
                command.Parameters.Add("@productTypeName", SqlDbType.NVarChar).Value = parcelModel.ProductTypeName;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ParcelModel> GetAll()
        {
            var parcelList = new List<ParcelModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select * from MyParcels";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var parcelModel = new ParcelModel();
                        parcelModel.ParcelId = reader[0].ToString();
                        parcelModel.Address = reader[1].ToString();
                        parcelModel.ProductTypeId = reader[2].ToString();
                        parcelModel.ProductTypeName = reader[3].ToString();
                        parcelList.Add(parcelModel);
                    }
                }

            }
            return parcelList;

        }

        public IEnumerable<ParcelModel> GetByValue(string value)
        {
            var parcelList = new List<ParcelModel>();
            int parcelId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string valueString = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select * from MyParcels where parcelId=@id or productTypeName like '%'+@product+'%'";
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = parcelId;
                command.Parameters.Add("@product", SqlDbType.NVarChar).Value = valueString;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var parcelModel = new ParcelModel();
                        parcelModel.ParcelId = reader[0].ToString();
                        parcelModel.Address = reader[1].ToString();
                        parcelModel.ProductTypeId = reader[2].ToString();
                        parcelModel.ProductTypeName = reader[3].ToString();
                        parcelList.Add(parcelModel);
                    }
                }

            }
            return parcelList;
        }
    }
}
