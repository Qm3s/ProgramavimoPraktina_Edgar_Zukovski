using Project_IS.Abstractions;
using Project_IS.Models;
using System.Data.SQLite;


internal class GradeRepository : IGradeRepository
{
    private readonly string _connString;

    public GradeRepository(string connString)
    {
        _connString = connString;
    }

    public IEnumerable<Grade> GetAll()
    {
        var list = new List<Grade>();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, StudentId, SubjectId, Grade FROM Grades";

        using var cmd = new SQLiteCommand(sql, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Grade
            {
                Id = Convert.ToInt32(reader["Id"]),
                StudentId = Convert.ToInt32(reader["StudentId"]),
                SubjectId = Convert.ToInt32(reader["SubjectId"]),
                Value = Convert.ToInt32(reader["Grade"])
            });
        }

        return list;
    }

    public Grade? GetById(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, StudentId, SubjectId, Grade FROM Grades WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null;

        return new Grade
        {
            Id = Convert.ToInt32(reader["Id"]),
            StudentId = Convert.ToInt32(reader["StudentId"]),
            SubjectId = Convert.ToInt32(reader["SubjectId"]),
            Value = Convert.ToInt32(reader["Grade"])
        };
    }

    public IEnumerable<Grade> GetByStudentId(int studentId)
    {
        var list = new List<Grade>();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, StudentId, SubjectId, Grade FROM Grades WHERE StudentId = @sid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@sid", studentId);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Grade
            {
                Id = Convert.ToInt32(reader["Id"]),
                StudentId = Convert.ToInt32(reader["StudentId"]),
                SubjectId = Convert.ToInt32(reader["SubjectId"]),
                Value = Convert.ToInt32(reader["Grade"])
            });
        }

        return list;
    }

    public IEnumerable<Grade> GetBySubjectId(int subjectId)
    {
        var list = new List<Grade>();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, StudentId, SubjectId, Grade FROM Grades WHERE SubjectId = @sub";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@sub", subjectId);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Grade
            {
                Id = Convert.ToInt32(reader["Id"]),
                StudentId = Convert.ToInt32(reader["StudentId"]),
                SubjectId = Convert.ToInt32(reader["SubjectId"]),
                Value = Convert.ToInt32(reader["Grade"])
            });
        }

        return list;
    }

    public void Add(Grade grade)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"INSERT INTO Grades (StudentId, SubjectId, Grade) 
                       VALUES (@stud, @sub, @grade)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@stud", grade.StudentId);
        cmd.Parameters.AddWithValue("@sub", grade.SubjectId);
        cmd.Parameters.AddWithValue("@grade", grade.Value);

        cmd.ExecuteNonQuery();
    }

    public void Update(Grade grade)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = @"UPDATE Grades 
                       SET StudentId = @stud, SubjectId = @sub, Grade = @grade
                       WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@stud", grade.StudentId);
        cmd.Parameters.AddWithValue("@sub", grade.SubjectId);
        cmd.Parameters.AddWithValue("@grade", grade.Value);
        cmd.Parameters.AddWithValue("@id", grade.Id);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "DELETE FROM Grades WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }
}

