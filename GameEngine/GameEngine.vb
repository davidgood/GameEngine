Namespace GameEngine
    ''' <summary>
    '''     Abstract Base class for all game objects
    ''' </summary>
    Public MustInherit Class GameObject
        Public Property Position As Vector2D
        Public Property Velocity As Vector2D
        Public Property Acceleration As Vector2D
        Public Property Rotation As Double
        Public Property Scale As Vector2D
        Public Property IsActive As Boolean

        ' TODO: Implement Default Constructor
        public Sub New()
            ' Implement.  Hint, check Vector2D predefined Vectors
        End Sub

        Public Sub New(position As Vector2D)
            Me.New()
            ' Implement the rest of this constructor:            
        End Sub

        ' TODO: Week 1 - Implement basic transform methods
        Public Overridable Sub Update(deltaTime As Double)
            ' TODO: Implement Basic Physics
            ' Update velocity based on acceleration

            ' Apply friction

            ' Update position based on velocity

            ' Reset acceleration (forces are applied each frame)
        End Sub

        Public MustOverride Sub Draw()
    End Class
End Namespace