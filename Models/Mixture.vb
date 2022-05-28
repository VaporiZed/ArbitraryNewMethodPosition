Public Class Mixture 

	Property ID As Integer = -1 
	Property IsStillRelevant As Boolean
	Property MixtureID As Integer
	Property Name As String
	Property Monography As String
	Property Dosage As String
	Property Remark As String
	Property State As String
	Property VesselID As Integer
	Property Version As Integer
	Property VersionDate As String
	Property PlausibilityTestStatus As PlausibilityTestStatus = PlausibilityTestStatus.Unclear
	Property ProductionInstructionExists As Boolean
	Property IsBulkWare As Boolean
	Property BulkWareIsCurrentlyAvailable As Boolean
	Property ProductionProcessID As Integer
	Property ExpiringDate As New ExpiringDate
	Property ApplicationInfoID As Integer
	Property MustBeStoredCool As Boolean
	Property IsAllowedToBeStoredCool As Boolean
	Property MustBeProtectedFromSunlight As Boolean
	Property MustBeStoredInADryPlace As Boolean
	Property ShakeVesselPriorToUse As Boolean
	Property AdditionalInfos As String
	ReadOnly Property ProductionInfo As New List(Of ProductionInfo)

End Class