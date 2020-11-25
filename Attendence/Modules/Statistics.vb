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
Module Statistics
    Public Function GetStandardDeviation(lst As List(Of Double)) As Double
        '-- From: https://social.msdn.microsoft.com/Forums/en-US/2ed768c8-2ebf-4639-9d2a-28beedd978e8/calculating-standard-deviation-in-visual-basic-2015
        '-- Note: This calculates "sample standard deviation" not for the whole population (so it matches with LibreOffice Calc does in its StDev function)
        Dim averageValue As Double
        Dim variance As Double
        Dim stdDevValue As Double

        averageValue = lst.Average

        variance = 0
        For Each i As Double In lst
            variance += (i - averageValue) ^ 2
        Next
        variance /= (lst.Count - 1)

        stdDevValue = Math.Sqrt(variance)

        Return stdDevValue
    End Function
End Module
