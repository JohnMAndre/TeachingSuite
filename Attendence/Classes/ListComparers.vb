'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.

Public Class StudentComparerByStudentID
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        If x.StudentID Is Nothing Then
            Return -1
        Else
            Return x.StudentID.CompareTo(y.StudentID)
        End If
    End Function
End Class

Public Class StudentComparerByExtStudentID
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        If x.ExtStudentID Is Nothing Then
            Return -1
        Else
            Return x.ExtStudentID.CompareTo(y.ExtStudentID)
        End If
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
        If x.StudentTeam Is Nothing Then
            Return -1
        Else
            Return x.StudentTeam.CompareTo(y.StudentTeam)
        End If
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
        If x.Tags Is Nothing Then
            Return -1
        Else
            Return x.Tags.CompareTo(y.Tags)
        End If
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
        If x.Nickname Is Nothing Then
            Return -1
        Else
            Return x.Nickname.CompareTo(y.Nickname)
        End If
    End Function
End Class
Public Class StudentComparerByLocalName
    Implements IComparer(Of Student)

    Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
        If x.LocalName Is Nothing Then
            Return -1
        Else
            Return x.LocalName.CompareTo(y.LocalName)
        End If
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
        If x.LocalNameLatinLetters Is Nothing Then
            Return -1
        Else
            Return x.LocalNameLatinLetters.CompareTo(y.LocalNameLatinLetters)
        End If
    End Function
End Class



Public Class ReportDataComparerByStudentID
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.StudentID Is Nothing Then
            Return -1
        Else
            Return x.StudentID.CompareTo(y.StudentID)
        End If
    End Function
End Class
Public Class ReportDataComparerByAdminNumber
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.AdminNumber.CompareTo(y.AdminNumber)
    End Function
End Class

Public Class ReportDataComparerByLocalName
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.LocalName Is Nothing Then
            Return -1
        Else
            Return x.LocalName.CompareTo(y.LocalName)
        End If
    End Function
End Class

Public Class ReportDataComparerByNickname
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Nickname Is Nothing Then
            Return -1
        Else
            Return x.Nickname.CompareTo(y.Nickname)
        End If
    End Function
End Class

Public Class ReportDataComparerByExtStudentID
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.ExtStudentID Is Nothing Then
            Return -1
        Else
            Return x.ExtStudentID.CompareTo(y.ExtStudentID)
        End If
    End Function
End Class

Public Class ReportDataComparerByTags
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Tags Is Nothing Then
            Return -1
        Else
            Return x.Tags.CompareTo(y.Tags)
        End If
    End Function
End Class

Public Class ReportDataComparerByPresentationQuality
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.PresentationQuality.CompareTo(y.PresentationQuality)
    End Function
End Class

Public Class ReportDataComparerByStudentGroup
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.StudentGroup.CompareTo(y.StudentGroup)
    End Function
End Class

Public Class ReportDataComparerByStudentTeam
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.StudentTeam Is Nothing Then
            Return -1
        Else
            Return x.StudentTeam.CompareTo(y.StudentTeam)
        End If
    End Function
End Class

Public Class ReportDataComparerByAltID
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.AltID.CompareTo(y.AltID)
    End Function
End Class

Public Class ReportDataComparerBySchoolClassName
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.SchoolClass Is Nothing Then
            Return -1
        Else
            Return x.SchoolClass.CompareTo(y.SchoolClass)
        End If
    End Function
End Class

Public Class ReportDataComparerByCountMatchingAssignmentsNormal
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.CountMatchingAssignmentsNormal.CompareTo(y.CountMatchingAssignmentsNormal)
    End Function
End Class

Public Class ReportDataComparerByAssignmentScoreFirst
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.AssignmentScoreFirst.CompareTo(y.AssignmentScoreFirst)
    End Function
End Class

Public Class ReportDataComparerByOverall
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Overall Is Nothing Then
            Return -1
        Else
            Return x.Overall.CompareTo(y.Overall)
        End If
    End Function
End Class

Public Class ReportDataComparerByImprovement
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Improvement Is Nothing Then
            Return -1
        Else
            Return x.Improvement.CompareTo(y.Improvement)
        End If
    End Function
End Class

Public Class ReportDataComparerByAssignmentScoreSecond
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        Return x.AssignmentScoreSecond.CompareTo(y.AssignmentScoreSecond)
    End Function
End Class

Public Class ReportDataComparerByOverall2
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Overall2 Is Nothing Then
            Return -1
        Else
            Return x.Overall2.CompareTo(y.Overall2)
        End If
    End Function
End Class

Public Class ReportDataComparerByImprovement2
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Improvement2 Is Nothing Then
            Return -1
        Else
            Return x.Improvement2.CompareTo(y.Improvement2)
        End If
    End Function
End Class

Public Class ReportDataComparerByCreator
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Creator Is Nothing Then
            Return -1
        Else
            Return x.Creator.CompareTo(y.Creator)
        End If
    End Function
End Class

Public Class ReportDataComparerByEditor
    Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData)

    Public Function Compare(x As ImportMarkingFromOtherSemesterFile.ReportData, y As ImportMarkingFromOtherSemesterFile.ReportData) As Integer Implements IComparer(Of ImportMarkingFromOtherSemesterFile.ReportData).Compare
        If x.Editor Is Nothing Then
            Return -1
        Else
            Return x.Editor.CompareTo(y.Editor)
        End If
    End Function
End Class
