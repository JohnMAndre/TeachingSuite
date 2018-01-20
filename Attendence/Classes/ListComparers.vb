Public Class StudentComparerByStudentID
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.StudentID.CompareTo(y.StudentID)
    End Function
End Class

Public Class StudentComparerByExtStudentID
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.ExtStudentID.CompareTo(y.ExtStudentID)
    End Function
End Class

Public Class StudentComparerByStudentGroup
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.StudentGroup.CompareTo(y.StudentGroup)
    End Function
End Class

Public Class StudentComparerByStudentTeam
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.StudentTeam.CompareTo(y.StudentTeam)
    End Function
End Class
Public Class StudentComparerByDateOfBirth
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.DateOfBirth.CompareTo(y.DateOfBirth)
    End Function
End Class
Public Class StudentComparerByGender
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.Gender.CompareTo(y.Gender)
    End Function
End Class
Public Class StudentComparerByTags
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.Tags.CompareTo(y.Tags)
    End Function
End Class
Public Class StudentComparerByLatestAttendenceStatus
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.LatestAttendenceStatus.CompareTo(y.LatestAttendenceStatus)
    End Function
End Class
Public Class StudentComparerByNickname
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.Nickname.CompareTo(y.Nickname)
    End Function
End Class
Public Class StudentComparerByLocalName
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.LocalName.CompareTo(y.LocalName)
    End Function
End Class
Public Class StudentComparerByAltNumber
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.AltNumber.CompareTo(y.AltNumber)
    End Function
End Class
Public Class StudentComparerByAdminNumber
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.AdminNumber.CompareTo(y.AdminNumber)
    End Function
End Class


