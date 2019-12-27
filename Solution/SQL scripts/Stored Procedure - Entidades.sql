USE CSGestion
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-12-22
-- Description:	Devuelve las Entidades
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Entidades') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Entidades
GO

CREATE PROCEDURE usp_Entidades
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT e.IdEntidad, e.RazonSocial, e.NombreFantasia, e.Apellido, e.Nombre, e.CUIT, e.EsActivo
			FROM Entidad AS e
	END