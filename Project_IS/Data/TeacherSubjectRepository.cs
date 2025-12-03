using System;
using System.Collections.Generic;
using System.Data.SQLite;


using Project_IS.Models;
using Project_IS.Abstractions;

internal class TeacherSubjectRepository : ITeacherSubjectRepository
{
    private readonly string _conn;

    public TeacherSubjectRepository(string conn)
    {
        _conn = conn;
    }

    public IEnumerable<int> GetSubjectsByTeacher(int teacherId)
    {
        var list = new List<int>();

        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = "SELECT SubjectId FROM TeacherSubjects WHERE TeacherId = @tid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@tid", teacherId);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
            list.Add(Convert.ToInt32(reader["SubjectId"]));

        return list;
    }

    public IEnumerable<int> GetTeachersBySubject(int subjectId)
    {
        var list = new List<int>();

        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = "SELECT TeacherId FROM TeacherSubjects WHERE SubjectId = @sid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@sid", subjectId);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
            list.Add(Convert.ToInt32(reader["TeacherId"]));

        return list;
    }

    public void Add(int teacherId, int subjectId)
    {
        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = @"INSERT INTO TeacherSubjects (TeacherId, SubjectId)
                       VALUES (@tid, @sid)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@tid", teacherId);
        cmd.Parameters.AddWithValue("@sid", subjectId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int teacherId, int subjectId)
    {
        using var conn = new SQLiteConnection(_conn);
        conn.Open();

        string sql = @"DELETE FROM TeacherSubjects
                       WHERE TeacherId = @tid AND SubjectId = @sid";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@tid", teacherId);
        cmd.Parameters.AddWithValue("@sid", subjectId);

        cmd.ExecuteNonQuery();
    }
}
