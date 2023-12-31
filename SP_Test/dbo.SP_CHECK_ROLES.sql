USE [DB_TEST_BA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_ROLES]    Script Date: 2023/02/27 8:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_CHECK_ROLES] 
	-- Add the parameters for the stored procedure here
	@role_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from [dbo].[roles] as R 
	where R.id = @role_id and R.is_active = 1
END