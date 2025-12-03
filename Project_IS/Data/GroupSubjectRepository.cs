using Project_IS.Abstractions;
using Project_IS.Models;
using System.Data.SQLite;




internal class GroupSubjectRepository : IGroupSubjectRepository
{
    private readonly string _conn;

    public GroupSubjectRepository(string conn)
    {
        _conn = conn;
    }

    public IEnumerable<int> GetSubjectsByGroup(int groupId)
    {
        var list = new List<int>();

        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = "SELECT SubjectId FROM GroupSubjects WHERE GroupId = @gid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@gid", groupId);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
            list.Add(Convert.ToInt32(reader["SubjectId"]));

        return list;
    }

    public IEnumerable<int> GetGroupsBySubject(int subjectId)
    {
        var list = new List<int>();

        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = "SELECT GroupId FROM GroupSubjects WHERE SubjectId = @sid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@sid", subjectId);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
            list.Add(Convert.ToInt32(reader["GroupId"]));

        return list;
    }

    public void Add(int groupId, int subjectId)
    {
        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = @"INSERT INTO GroupSubjects (GroupId, SubjectId)
                       VALUES (@gid, @sid)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@gid", groupId);
        cmd.Parameters.AddWithValue("@sid", subjectId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int groupId, int subjectId)
    {
        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = @"DELETE FROM GroupSubjects
                       WHERE GroupId = @gid AND SubjectId = @sid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@gid", groupId);
        cmd.Parameters.AddWithValue("@sid", subjectId);

        cmd.ExecuteNonQuery();
    }
}

