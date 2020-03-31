Namespace Globals

    Public Class GlobalVariable

        Public Structure DatabaseError
            Private _trash As String
            Public Shared DuplicateRecord As String = "The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship.  Change the data in the field or fields that contain duplicate data, remove the index, or redefine the index to permit duplicate entries and try again."
            Public Shared OpenedExclusively As String = "opened exclusively by another user"
        End Structure

        Private Shared m_strConnectionString As String

        Public Shared Property ConnectionString() As String
            Get
                Return m_strConnectionString
            End Get
            Set(ByVal Value As String)
                m_strConnectionString = Value
            End Set
        End Property



    End Class

End Namespace
