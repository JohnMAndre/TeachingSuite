'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Foobar Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < https: //www.gnu.org/licenses/>.

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
Public Class StudentComparerByTotalAbsences
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.TotalAbsences.CompareTo(y.TotalAbsences)
    End Function
End Class
Public Class StudentComparerByCurrentAbsences
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.CurrentAbsences.CompareTo(y.CurrentAbsences)
    End Function
End Class
Public Class StudentComparerByPresentationQuality
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.PresentationQuality.CompareTo(y.PresentationQuality)
    End Function
End Class
Public Class StudentComparerByWritingQuality
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.WritingQuality.CompareTo(y.WritingQuality)
    End Function
End Class
Public Class StudentComparerByAssignmentCount
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.AssignmentCount.CompareTo(y.AssignmentCount)
    End Function
End Class
Public Class StudentComparerByProcessedAssignments
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.ProcessedAssignments.CompareTo(y.ProcessedAssignments)
    End Function
End Class
Public Class StudentComparerBy
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.AdminNumber.CompareTo(y.AdminNumber)
    End Function
End Class
Public Class StudentComparerByHidden
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.Hidden.CompareTo(y.Hidden)
    End Function
End Class
Public Class StudentComparerByMeritPoints
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.MeritPoints.CompareTo(y.MeritPoints)
    End Function
End Class
Public Class StudentComparerByPlagiarismSeverity
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.PlagiarismSeverity.CompareTo(y.PlagiarismSeverity)
    End Function
End Class
Public Class StudentComparerByDraftsChecked
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.DraftsChecked.CompareTo(y.DraftsChecked)
    End Function
End Class
Public Class StudentComparerByOfficeHoursVisited
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.OfficeHoursVisited.CompareTo(y.OfficeHoursVisited)
    End Function
End Class
Public Class StudentComparerByResearchQuality
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.ResearchQuality.CompareTo(y.ResearchQuality)
    End Function
End Class
Public Class StudentComparerByPerformanceLastOnlineQuiz
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.PerformanceLastOnlineQuiz.CompareTo(y.PerformanceLastOnlineQuiz)
    End Function
End Class
Public Class StudentComparerByLocalNameLatinLetters
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        Return x.LocalNameLatinLetters.CompareTo(y.LocalNameLatinLetters)
    End Function
End Class
