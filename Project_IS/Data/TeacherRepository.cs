using Project_IS.Abstractions;
using Project_IS.Models;
using System.Data.SQLite;

internal class TeacherRepository : ITeacherRepository
{
    private readonly string _connString;

    public TeacherRepository(string connString)
    {
        _connString = connString;
    }

    public IEnumerable<Teacher> GetAll()
    {
        var list = new List<Teacher>();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"
            SELECT t.Id, t.UserId,
                   u.FirstName, u.LastName, u.Username, u.Password, u.Role
            FROM Teachers t
            JOIN Users u ON u.Id = t.UserId";

        using var cmd = new SQLiteCommand(sql, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(MapTeacher(reader));
        }

        return list;
    }

    public Teacher GetById(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"
            SELECT t.Id, t.UserId,
                   u.FirstName, u.LastName, u.Username, u.Password, u.Role
            FROM Teachers t
            JOIN Users u ON u.Id = t.UserId
            WHERE t.Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null!;

        return MapTeacher(reader);
    }

    public Teacher GetByUserId(int userId)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"
            SELECT t.Id, t.UserId,
                   u.FirstName, u.LastName, u.Username, u.Password, u.Role
            FROM Teachers t
            JOIN Users u ON u.Id = t.UserId
            WHERE t.UserId = @uid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@uid", userId);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null!;

        return MapTeacher(reader);
    }

    public void Add(Teacher teacher)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"INSERT INTO Teachers (UserId) VALUES (@uid)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@uid", teacher.UserId); 

        cmd.ExecuteNonQuery();
    }

    public void Update(Teacher teacher)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"UPDATE Teachers SET UserId = @uid WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@uid", teacher.UserId);
        cmd.Parameters.AddWithValue("@id", teacher.TeacherId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"DELETE FROM Teachers WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }

    private Teacher MapTeacher(SQLiteDataReader reader)
    {
        return new Teacher
        {
            TeacherId = Convert.ToInt32(reader["Id"]),     
            UserId = Convert.ToInt32(reader["UserId"]),        

            FirstName = reader["FirstName"].ToString()!,
            LastName = reader["LastName"].ToString()!,
            Username = reader["Username"].ToString()!,
            Password = reader["Password"].ToString()!,
            Role = reader["Role"].ToString()!
        };
    }
}
