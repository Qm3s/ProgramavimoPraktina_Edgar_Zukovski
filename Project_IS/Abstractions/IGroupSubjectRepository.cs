using System;
using System.Collections.Generic;
using System.Data.SQLite;


using Project_IS.Models;
using Project_IS.Abstractions;


public interface IGroupSubjectRepository
{
    IEnumerable<int> GetSubjectsByGroup(int groupId);
    IEnumerable<int> GetGroupsBySubject(int subjectId);
    void Add(int groupId, int subjectId);
    void Delete(int groupId, int subjectId);
}


