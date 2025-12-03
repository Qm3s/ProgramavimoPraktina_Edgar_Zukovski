using Project_IS.Abstractions;
using Project_IS.Models;
using System.Data.SQLite;

internal class StudentRepository : IStudentRepository
{
    private readonly string _connString;

    public StudentRepository(string connString)
    {
        _connString = connString;
    }

    public IEnumerable<Student> GetAll()
    {
        List<Student> list = new();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"SELECT s.Id, s.UserId, s.GroupId,
                              u.FirstName, u.LastName, u.Username, u.Password, u.Role
                       FROM Students s
                       JOIN Users u ON u.Id = s.UserId";

        using var cmd = new SQLiteCommand(sql, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(MapStudent(reader));
        }

        return list;
    }

    public Student GetById(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"SELECT s.Id, s.UserId, s.GroupId,
                              u.FirstName, u.LastName, u.Username, u.Password, u.Role
                       FROM Students s
                       JOIN Users u ON u.Id = s.UserId
                       WHERE s.Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null!; 

        return MapStudent(reader);
    }

    public Student GetByUserId(int userId)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"SELECT s.Id, s.UserId, s.GroupId,
                              u.FirstName, u.LastName, u.Username, u.Password, u.Role
                       FROM Students s
                       JOIN Users u ON u.Id = s.UserId
                       WHERE s.UserId = @uid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@uid", userId);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null!;

        return MapStudent(reader);
    }

    public void Add(Student student)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"INSERT INTO Students (UserId, GroupId)
                       VALUES (@uid, @gid)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@uid", student.UserId);
        cmd.Parameters.AddWithValue("@gid", student.GroupId);

        cmd.ExecuteNonQuery();
    }

    public void Update(Student student)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"UPDATE Students 
                   SET GroupId = @gid
                   WHERE Id = @sid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@gid", student.GroupId);
        cmd.Parameters.AddWithValue("@sid", student.StudentId);

        cmd.ExecuteNonQuery();
    }


    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"DELETE FROM Students WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }

    private Student MapStudent(SQLiteDataReader reader)
    {
        return new Student
        {
            StudentId = Convert.ToInt32(reader["Id"]), 
            UserId = Convert.ToInt32(reader["UserId"]),
            GroupId = reader["GroupId"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["GroupId"]),

            FirstName = reader["FirstName"].ToString()!,
            LastName = reader["LastName"].ToString()!,
            Username = reader["Username"].ToString()!,
            Password = reader["Password"].ToString()!,
            Role = reader["Role"].ToString()!
        };
    }


}
