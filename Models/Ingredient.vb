Public Class Ingredient
	Property ID As Integer = -1
	Property Name As String
	ReadOnly Property HazardInfo As New List(Of String)
	Property IsInHazardList As Boolean
	Property IsDeclarationFree As Boolean
	ReadOnly Property PreservativeIDs As New List(Of Integer)
	ReadOnly Property Store As New List(Of String)
End Class