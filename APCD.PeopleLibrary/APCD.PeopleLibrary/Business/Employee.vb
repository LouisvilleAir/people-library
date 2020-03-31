Imports APCD.PeopleLibrary.Data

Namespace Business

    <Serializable()> Public Class Employee

#Region "----- objects -----"

        Private m_dtbAPCDProgramIDs As DataTable
        Public Property APCDProgramIDs As DataTable
            Get
                Return m_dtbAPCDProgramIDs
            End Get
            Set(ByVal value As DataTable)
                m_dtbAPCDProgramIDs = value
            End Set
        End Property

#End Region '----- objects -----

        Private m_intEmployeeID As Int32
        Private m_strFirstName As String
        Private m_strLastName As String
        Private m_strMiddleName As String
        Private m_strNickName As String
        Private m_strUserName As String
        Private m_dtStartTime As Date
        Private m_dtEndTime As Date
        Private m_intReportsTo As Int32
        Private m_dtBeginDate As Date
        Private m_dtEndDate As Date
        Private m_dtAddDate As Date
        Private m_intAddedBy As Int32

        Public Property EmployeeID() As Int32
            Get
                Return m_intEmployeeID
            End Get
            Set(ByVal value As Int32)
                m_intEmployeeID = value
            End Set
        End Property

        Public Property FirstName() As String
            Get
                Return m_strFirstName
            End Get
            Set(ByVal value As String)
                m_strFirstName = value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return m_strLastName
            End Get
            Set(ByVal value As String)
                m_strLastName = value
            End Set
        End Property

        Public Property MiddleName() As String
            Get
                Return m_strMiddleName
            End Get
            Set(ByVal value As String)
                m_strMiddleName = value
            End Set
        End Property

        Public Property NickName() As String
            Get
                Return m_strNickName
            End Get
            Set(ByVal value As String)
                m_strNickName = value
            End Set
        End Property

        Public Property UserName() As String
            Get
                Return m_strUserName
            End Get
            Set(ByVal value As String)
                m_strUserName = value
            End Set
        End Property

        Public Property StartTime() As Date
            Get
                Return m_dtStartTime
            End Get
            Set(ByVal value As Date)
                m_dtStartTime = value
            End Set
        End Property

        Public Property EndTime() As Date
            Get
                Return m_dtEndTime
            End Get
            Set(ByVal value As Date)
                m_dtEndTime = value
            End Set
        End Property

        Public Property ReportsTo() As Int32
            Get
                Return m_intReportsTo
            End Get
            Set(ByVal value As Int32)
                m_intReportsTo = value
            End Set
        End Property

        Public Property BeginDate() As Date
            Get
                Return m_dtBeginDate
            End Get
            Set(ByVal value As Date)
                m_dtBeginDate = value
            End Set
        End Property

        Public Property EndDate() As Date
            Get
                Return m_dtEndDate
            End Get
            Set(ByVal value As Date)
                m_dtEndDate = value
            End Set
        End Property


        Public Property AddDate() As Date
            Get
                Return m_dtAddDate
            End Get
            Set(ByVal value As Date)
                m_dtAddDate = value
            End Set
        End Property


        Public Property AddedBy() As Int32
            Get
                Return m_intAddedBy
            End Get
            Set(ByVal value As Int32)
                m_intAddedBy = value
            End Set
        End Property

    End Class

End Namespace

