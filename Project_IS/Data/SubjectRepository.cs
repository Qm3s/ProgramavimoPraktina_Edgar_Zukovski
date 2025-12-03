using Project_IS.Abstractions;
using Project_IS.Models;
using System.Data.SQLite;

internal class SubjectRepository : ISubjectRepository
{
    private readonly string _connString;

    public SubjectRepository(string connString)
    {
        _connString = connString;
    }

    public IEnumerable<Subject> GetAll()
    {
        var list = new List<Subject>();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, SubjectName FROM Subjects";

        using var cmd = new SQLiteCommand(sql, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Subject
            {
                Id = Convert.ToInt32(reader["Id"]),
                SubjectName = reader["SubjectName"].ToString()!
            });
        }

        return list;
    }

    public Subject GetById(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, SubjectName FROM Subjects WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
            return null;

        return new Subject
        {
            Id = Convert.ToInt32(reader["Id"]),
            SubjectName = reader["SubjectName"].ToString()!
        };
    }

    public Subject GetByName(string name)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, SubjectName FROM Subjects WHERE SubjectName = @name";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", name);

        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
            return null;

        return new Subject
        {
            Id = Convert.ToInt32(reader["Id"]),
            SubjectName = reader["SubjectName"].ToString()!
        };
    }

    public void Add(Subject subject)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "INSERT INTO Subjects (SubjectName) VALUES (@name)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", subject.SubjectName);

        cmd.ExecuteNonQuery();
    }

    public void Update(Subject subject)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "UPDATE Subjects SET SubjectName = @name WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", subject.SubjectName);
        cmd.Parameters.AddWithValue("@id", subject.Id);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "DELETE FROM Subjects WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }
}
