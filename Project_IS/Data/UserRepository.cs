using System;
using System.Collections.Generic;
using System.Data.SQLite;


using Project_IS.Models;
using Project_IS.Abstractions;




public class UserRepository : IUserRepository
{
    private readonly string _connectionString; 

    public UserRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<User> GetAll()
    {
        var users = new List<User>();

        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT Id, FirstName, Lastname, Username, Password, Role FROM Users";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            users.Add(new User
            {
                UserId = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Username = reader.GetString(3),
                Password = reader.GetString(4),
                Role = reader.GetString(5)
            });
        }

        return users;
    }

    public User GetById(int id)
    {
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"SELECT Id, FirstName, Lastname, Username, Password, Role 
                            FROM Users WHERE Id = @id";
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new User
            {
                UserId = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Username = reader.GetString(3),
                Password = reader.GetString(4),
                Role = reader.GetString(5)
            };
        }

        return null; // потом понять почему??
    }

    public User GetByUsername(string username)
    {
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"SELECT Id, Firstname, Lastname, Username, Password, Role 
                            FROM Users WHERE Username = @u";
        cmd.Parameters.AddWithValue("@u", username);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new User
            {
                UserId = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Username = reader.GetString(3),
                Password = reader.GetString(4),
                Role = reader.GetString(5)
            };
        }

        return null; // потом решить надо
    }

    public void Add(User user)
    {
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"INSERT INTO Users (FirstName, Lastname, Username, Password, Role)
                            VALUES (@v, @p, @u, @pass, @r)";

        cmd.Parameters.AddWithValue("@v", user.FirstName);
        cmd.Parameters.AddWithValue("@p", user.LastName);
        cmd.Parameters.AddWithValue("@u", user.Username);
        cmd.Parameters.AddWithValue("@pass", user.Password);
        cmd.Parameters.AddWithValue("@r", user.Role);

        cmd.ExecuteNonQuery(); 
    }

    public void Update(User user)
    {
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"UPDATE Users 
                            SET FirstName=@v, Lastname=@p, Username=@u, Password=@pass, Role=@r 
                            WHERE Id=@id";

        cmd.Parameters.AddWithValue("@v", user.FirstName);
        cmd.Parameters.AddWithValue("@p", user.LastName);
        cmd.Parameters.AddWithValue("@u", user.Username);
        cmd.Parameters.AddWithValue("@pass", user.Password);
        cmd.Parameters.AddWithValue("@r", user.Role);
        cmd.Parameters.AddWithValue("@id", user.UserId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM Users WHERE Id=@id";
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }
}
