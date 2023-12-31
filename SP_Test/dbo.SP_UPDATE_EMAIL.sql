USE [DB_TEST_BA]
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_EMAIL]    Script Date: 3/5/2023 3:54:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_UPDATE_EMAIL] 
	-- Add the parameters for the stored procedure here
	@id int, 
	@email_address nvarchar(Max), 
	@cc nvarchar(Max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @Result bit;
	SET NOCOUNT ON;
	If ((SELECT COUNT(@email_address)FROM email WHERE id = @id and (is_deleted <> 1 or is_deleted is null)) >0)
    -- Insert statements for procedure here
	BEGIN
			UPDATE email
					set 
						email.email_address = @email_address,
						email.cc = @cc
					from email 
					WHERE email.id = @id and (is_deleted <> 1 or is_deleted is null)
			BEGIN
				set @Result = 1;
				select @Result as Rs
			END
		END
	ELSE
		BEGIN
			set @Result = 0;
			select @Result as Rs
		END
END