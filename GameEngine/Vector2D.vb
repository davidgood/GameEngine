''' <summary>
'''     Core namespace for the 2D game engine
''' </summary>
Namespace GameEngine
    ''' <summary>
    '''     Represents a 2D vector for position, velocity, and other geometric calculations
    ''' </summary>
    Public Structure Vector2D
        Public Property X As Double
        Public Property Y As Double

        Public Sub New(x As Double, y As Double)
            Me.X = x
            Me.Y = y
        End Sub

        ' TODO: Week 1 - Implement correct and safe vector operations
        Public Shared Operator +(v1 As Vector2D, v2 As Vector2D) As Vector2D
            Return New Vector2D(0, 0) ' implement
        End Operator

        Public Shared Operator -(v1 As Vector2D, v2 As Vector2D) As Vector2D
            Return New Vector2D(0, 0) ' implement
        End Operator

        Public Shared Operator *(v As Vector2D, scalar As Double) As Vector2D
            Return New Vector2D(0, 0) ' implement
        End Operator


        ' Predefined vectors
        Public Shared ReadOnly Zero As Vector2D = New Vector2D(0, 0)
        Public Shared ReadOnly One As Vector2D = New Vector2D(1, 1)
        Public Shared ReadOnly UnitX As Vector2D = New Vector2D(1, 0)
        Public Shared ReadOnly UnitY As Vector2D = New Vector2D(0, 1)
    End Structure
End Namespace

