CREATE PROCEDURE [dbo].[Factorial_SP]
(
    @Number Integer,
    @RetVal Integer OUTPUT
)
AS
    DECLARE @In Integer
    DECLARE @Out Integer
    IF @Number != 1
        BEGIN
        SELECT @In = @Number - 1
            EXEC Factorial_SP @In, @Out OUTPUT
        SELECT @RetVal = @Number * @Out
    END
        ELSE
            BEGIN
                SELECT @RetVal = 1
            END

RETURN
GO
