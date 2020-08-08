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
Public Class ClassSelector

    Private m_classGroup As ClassGroup

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = classGroup

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If lstClasses.SelectedIndex > -1 Then
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Please select a class.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public ReadOnly Property SelectedClass As SchoolClass
        Get
            Return lstClasses.Items(lstClasses.SelectedIndex)
        End Get
    End Property

    Private Sub LoadClasses()
        lstClasses.Items.Clear()
        For Each objClass As SchoolClass In m_classGroup.Classes
            lstClasses.Items.Add(objClass)
        Next
    End Sub

    Private Sub ClassSelector_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadClasses()
    End Sub
End Class
